using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Engine.DataContracts
{
  [DataContract]
  public class CharacterReputation
  {
    [DataMember(Name = "id")]
    public int Id { get; set; }

    [DataMember(Name = "name")]
    public string Name { get; set; }

    [DataMember(Name = "standing")]
    public int Standing { get; set; }

    [DataMember(Name = "value")]
    public int Value { get; set; }

    [DataMember(Name = "max")]
    public int Max { get; set; }
  }
}
