﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Engine.DataContracts
{
  [DataContract]
  public class Challenges
  {
    [DataMember(Name = "challenge")]
    public IEnumerable<Challenge> Challenge { get; set; }
  }
}
