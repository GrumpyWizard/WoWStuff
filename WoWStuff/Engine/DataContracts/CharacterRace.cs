using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Engine.DataContracts
{
  [DataContract]
  public enum CharacterRace
  {
    HUMAN             = 1,
    ORC               = 2,
    DWARF             = 3,
    NIGHT_ELF         = 4,
    UNDEAD            = 5,
    TAUREN            = 6,
    GNOME             = 7,
    TROLL             = 8,
    GOBLIN            = 9,
    BLOOD_ELF         = 10,
    DRAENEI           = 11,
    WORGEN            = 22,
    PANDAREN_NEUTRAL  = 24,
    PANDAREN_ALLIANCE = 25,
    PANDAREN_HORDE    = 26
  }
}
