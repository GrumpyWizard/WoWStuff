using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Engine.DataContracts
{
  [DataContract]
  public class Guild
  {
    [DataMember(Name = "achievementPoints")]
    public int AchievementPoints { get; set; }

    [DataMember(Name = "achievements")]
    public Achievements Achievements { get; set; }

    [DataMember(Name = "battlegroup")]
    public string Battlegroup { get; set; }

    [DataMember(Name = "emblem")]
    public GuildEmblem Emblem { get; set; }

    [DataMember(Name = "lastModified")]
    public long LastModified { get; set; }

    [DataMember(Name = "level")]
    public int Level { get; set; }

    [DataMember(Name = "members")]
    public IEnumerable<GuildMember> Members { get; set; }

    [DataMember(Name = "name")]
    public string Name { get; set; }

    [DataMember(Name = "news")]
    public IEnumerable<GuildNews> News { get; set; }

    [DataMember(Name = "realm")]
    public string Realm { get; set; }

    [DataMember(Name = "side")]
    private int side { get; set; }
  }
}
