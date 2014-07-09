using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Engine.DataContracts
{
  [DataContract]
  public class ChallengeMember
  {
    [DataMember(Name = "character")]
    public ChallengeMemberCharacter Character { get; set; }

    [DataMember(Name = "spec")]
    public CharacterTalentSpec Spec { get; set; }
  }
}
