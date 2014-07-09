using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Engine.DataContracts
{
  [DataContract]
  public enum CharacterPowerType
  {
    [EnumMember(Value = "focus")]
    FOCUS,
    [EnumMember(Value = "rage")]
    RAGE,
    [EnumMember(Value = "mana")]
    MANA,
    [EnumMember(Value = "energy")]
    ENERGY,
    [EnumMember(Value = "runic-power")]
    RUNICPOWER
  }
}
