using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Engine.DataContracts
{
  [DataContract]
  public class CharacterRatedBattlegrounds
  {
    [DataMember(Name = "name")]
    public string Name { get; set; }

    [DataMember(Name = "played")]
    public int Played { get; set; }

    [DataMember(Name = "won")]
    public int Won { get; set; }
  }
}
