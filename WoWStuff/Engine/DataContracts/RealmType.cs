using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Engine.DataContracts
{
  [DataContract]
  public enum RealmType
  {
    [EnumMember(Value = "pve")]
    PVE,
    [EnumMember(Value = "pvp")]
    PVP,
    [EnumMember(Value = "rp")]
    RP,
    [EnumMember(Value = "rppvp")]
    RPPVP
  }
}
