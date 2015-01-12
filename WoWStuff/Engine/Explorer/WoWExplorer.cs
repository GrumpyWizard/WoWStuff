using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json;
using Engine.DataContracts;
using Engine.Utilities.JSON;
using Engine.Explorer.Interface;
using Engine.Explorer.Optionals;
using Engine.Explorer.Queries;


namespace Engine.Explorer
{
  public class WoWExplorer : IExplorer
  {
    public Region Region { get; set; }
    public Locale Locale { get; set; }
    public string APIKey { get; set; }
    public string Host   { get; set; }


    public WoWExplorer(Region aRegion, Locale aLocale, string anAPIKey)
    {
      Region = aRegion;
      Locale = aLocale;
      APIKey = anAPIKey;

      switch (Region)
      {
        case Region.US:
          Host = "https://us.api.battle.net";
          break;
        case Region.KR:
          Host = "https://kr.api.battle.net";
          break;
        case Region.TW:
          Host = "https://tw.api.battle.net";
          break;
        case Region.CN:
          Host = "https://www.battlenet.com.cn/";
          break;
        case Region.SEA:
          Host = "https://sea.api.battle.net";
          break;
        case Region.EU:
        default:
          Host = "https://eu.api.battle.net";
          break;
      }
    }


    #region Character


    public Character GetCharacter(string realm, string name)
    {
      return GetCharacter(Region, realm, name, CharacterOptions.None);
    }


    public Character GetCharacter(string realm, string name, CharacterOptions characterOptions)
    {
      return GetCharacter(Region, realm, name, characterOptions);
    }


    public Character GetCharacter(Region region, string realm, string name)
    {
      return GetCharacter(region, realm, name, CharacterOptions.None);
    }


    public Character GetCharacter(Region region, string realm, string name, CharacterOptions characterOptions)
    {
      Character character;

      TryGetData<Character>(
          string.Format(@"{0}/wow/character/{1}/{2}?locale={3}{4}&apikey={5}", Host, realm, name, Locale, CharacterQuery.buildOptionalQuery(characterOptions), APIKey),
          out character);

      return character;
    }


    #endregion


    #region JSON Data Retrieval


    private T GetData<T>(string url) where T : class
    {
      return JSONHandler.FromJSON<T>(url);
    }

    private void TryGetData<T>(string url, out T requestedObject) where T : class
    {
      try
      {
        requestedObject = JSONHandler.FromJSON<T>(url);
      }
      catch (Exception ex)
      {
        requestedObject = null;
        throw ex;
      }
    }


    #endregion


  }
}
