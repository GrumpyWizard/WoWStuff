﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Engine.DataContracts
{
  [DataContract]
  public class ChallengeTime
  {
    [DataMember(Name = "hours")]
    public int Hours { get; set; }

    [DataMember(Name = "minutes")]
    public int Minutes { get; set; }

    [DataMember(Name = "seconds")]
    public int Seconds { get; set; }

    [DataMember(Name = "milliseconds")]
    public int Milliseconds { get; set; }

    [DataMember(Name = "time")]
    public long Time { get; set; }

    public string TimeString
    {
      get
      {
        string strTime = Seconds + "." + Milliseconds + "s";

        if (Minutes > 0 || Hours > 0) { strTime = Minutes + "m " + strTime; };
        if (Hours > 0) { strTime += Hours + "h " + strTime; };

        return strTime;
      }
    }
  }
}
