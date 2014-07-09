using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Engine.DataContracts
{
  [DataContract]
  public class CharacterPets
  {
    [DataMember(Name = "collected")]
    public IEnumerable<CharacterPet> Collected { get; set; }

    [DataMember(Name = "numCollected")]
    public int NumCollected { get; set; }

    [DataMember(Name = "numNotCollected")]
    public int NumNotCollected { get; set; }
  }
}
