﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Engine.DataContracts
{
  [DataContract]
  public class CharacterRaceInfo
  {
    [DataMember(Name = "id")]
    public int Id { get; set; }

    [DataMember(Name = "mask")]
    public int Mask { get; set; }

    [DataMember(Name = "side")]
    public string Side { get; set; }

    [DataMember(Name = "name")]
    public string Name { get; set; }
  }
}
