using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Security.Cryptography;

namespace Engine.JSON
{
  public static class JSONHandler
  {
    # region GetJSON
    /// <summary>
    /// Creates a connection to the requested url and gets the stream as response, returned as a string...
    /// 
    /// </summary>
    
    public static string GetJSON(string url)
    {
      HttpWebRequest req = WebRequest.Create(url) as HttpWebRequest;
      return GetJSON(req);
    }

    public static string GetJSON(HttpWebRequest httpWebReq)
    {
      try
      {
        HttpWebResponse httpWebResponse = httpWebReq.GetResponse() as HttpWebResponse;

        StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream(), Encoding.UTF8);
        return streamReader.ReadToEnd();
      }
      catch (WebException e)
      {
        using (HttpWebResponse myHttpWebResponse = e.Response as HttpWebResponse)
        {
          if (myHttpWebResponse == null)
          {
            Console.WriteLine("myHttpWebResponse is null!");
            //throw some exception...; //{@}
          }

          //error handler; //{@} .. is this really necessary though?

          switch (myHttpWebResponse.StatusCode)
          {
            //case HttpStatusCode.OK: return "success";
            case HttpStatusCode.InternalServerError:    //500
            case HttpStatusCode.NotFound:               //404
            default:
              //throw exception //{@}
              return "fail";
          }
        }
      }
    }
    #endregion

    #region Serialization
    /// <summary>
    /// JSON Serialization. These are the methods that are called.
    /// </summary>

    // Gets a JSON string from a requested url and returns the correct Object Type containing the data within the string.
    public static T FromJSON<T>(string url) where T : class
    {
      HttpWebRequest req = WebRequest.Create(url) as HttpWebRequest;
      return FromJSON<T>(req);
    }

    public static T FromJSON<T>(HttpWebRequest httpWebReq) where T : class
    {
      using (MemoryStream memStream = new MemoryStream(Encoding.UTF8.GetBytes(GetJSON(httpWebReq))))
      {
        DataContractJsonSerializer dataContractJsonSerializer = new DataContractJsonSerializer(typeof(T));
        return dataContractJsonSerializer.ReadObject(memStream) as T;
      }
    }

    // see http://blizzard.github.io/api-wow-docs/#features/authentication
    public static T FromJSON<T>(string url, string publicAuthKey, string privateAuthKey) where T : class
    {
      HttpWebRequest httpWebReq = WebRequest.Create(url) as HttpWebRequest;
      DateTime date = DateTime.Now.ToUniversalTime();
      httpWebReq.Date = date;

      string stringToSign = httpWebReq.Method + "\n"
                            + date.ToString("r") + "\n"
                            + httpWebReq.RequestUri.AbsolutePath + "\n";

      byte[] buffer = Encoding.UTF8.GetBytes(stringToSign);

      HMACSHA1 hmac = new HMACSHA1(Encoding.UTF8.GetBytes(privateAuthKey));

      string signature = Convert.ToBase64String(hmac.ComputeHash(buffer));

      httpWebReq.Headers[HttpRequestHeader.Authorization] = "BNET " 
                                                            + publicAuthKey 
                                                            + ":" 
                                                            + signature;

      return FromJSON<T>(httpWebReq);
    }

    public static T FromJSONStream<T>(StreamReader streamReader) where T : class
    {
      using (MemoryStream memStream = new MemoryStream(Encoding.UTF8.GetBytes(streamReader.ReadToEnd())))
      {
        DataContractJsonSerializer dataContractJsonSerializer = new DataContractJsonSerializer(typeof(T));
        return dataContractJsonSerializer.ReadObject(memStream) as T;
      }
    }

    public static T FromJSONString<T>(string str) where T : class
    {
      using (MemoryStream memStream = new MemoryStream(Encoding.UTF8.GetBytes(str)))
      {
        DataContractJsonSerializer dataContractJsonSerializer = new DataContractJsonSerializer(typeof(T));
        return dataContractJsonSerializer.ReadObject(memStream) as T;
      }
    }

    // Serialzing Object to JSON strings. Handling is not yet fully implemented.
    public static string ToJSON<T>(T obj) where T : class
    {
      using (MemoryStream memStream = new MemoryStream())
      {
        DataContractJsonSerializer dataContractJsonSerializer = new DataContractJsonSerializer(typeof(T));
        dataContractJsonSerializer.WriteObject(memStream, obj);
        return Encoding.UTF8.GetString(memStream.ToArray());
      }
    }

    #endregion
  }
}
