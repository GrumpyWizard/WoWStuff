using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Engine.DataContracts
{
  [DataContract]
  public class GuildMember
  {
    [DataMember(Name = "character")]
    public GuildCharacter Character { get; set; }

    [DataMember(Name = "rank")]
    public int Rank { get; set; }
  }
}
