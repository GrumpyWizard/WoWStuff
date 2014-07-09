using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Engine.DataContracts
{
  [DataContract]
  public class CharacterProfessions
  {
    [DataMember(Name = "primary")]
    public IEnumerable<CharacterProfession> Primary { get; set; }

    [DataMember(Name = "secondary")]
    public IEnumerable<CharacterProfession> Secondary { get; set; }
  }
}
