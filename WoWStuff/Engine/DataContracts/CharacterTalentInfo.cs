using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Engine.DataContracts
{
  [DataContract]
  public class CharacterTalentInfo
  {
    [DataMember(Name = "tier")]
    public int Tier { get; set; }

    [DataMember(Name = "column")]
    public int Column { get; set; }

    [DataMember(Name = "spell")]
    public CharacterTalentSpell Spell { get; set; }
  }
}
