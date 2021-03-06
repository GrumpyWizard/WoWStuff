﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Engine.DataContracts
{
  [DataContract]
  public class Realm
  {
    [DataMember(Name = "type")]
    private string type { get; set; }

    [DataMember(Name = "queue")]
    public bool Queue { get; set; }

    [DataMember(Name = "status")]
    public bool Status { get; set; }

    [DataMember(Name = "population")]
    private string population { get; set; }

    [DataMember(Name = "name")]
    public string Name { get; set; }

    [DataMember(Name = "slug")]
    public string Slug { get; set; }

    public RealmType Type { get { return (RealmType)Enum.Parse(typeof(RealmType), type, true); } }

    public RealmPopulation Population { get { return (RealmPopulation)Enum.Parse(typeof(RealmPopulation), population, true); } }
  }
}
