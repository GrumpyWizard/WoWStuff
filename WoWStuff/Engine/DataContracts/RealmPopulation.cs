using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Engine.DataContracts
{
  [DataContract]
  public enum RealmPopulation
  {
    [EnumMember(Value = "low")]
    LOW,
    [EnumMember(Value = "medium")]
    MEDIUM,
    [EnumMember(Value = "high")]
    HIGH,
    [EnumMember(Value = "n/a")]
    NA
  }
}
