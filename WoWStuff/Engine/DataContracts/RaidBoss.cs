using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Engine.DataContracts
{
  [DataContract]
  public class RaidBoss
  {
    [DataMember(Name = "name")]
    public string Name { get; set; }

    [DataMember(Name = "id")]
    public int Id { get; set; }

    [DataMember(Name = "normalKills")]
    public int NormalKills { get; set; }

    [DataMember(Name = "heroicKills")]
    public int HeroicKills { get; set; }
  }
}
