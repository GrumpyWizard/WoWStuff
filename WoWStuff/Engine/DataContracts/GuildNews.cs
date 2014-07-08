using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Engine.DataContracts
{
  [DataContract]
  public class GuildNews
  {
    [DataMember(Name = "achievement")]
    public AchievementInfo Achievement { get; set; }

    [DataMember(Name = "character")]
    public string Character { get; set; }

    [DataMember(Name = "itemId")]
    public int ItemID { get; set; }

    [DataMember(Name = "timestamp")]
    public long Timestamp { get; set; }

    [DataMember(Name = "type")]
    public string Type { get; set; }

    [DataMember(Name = "levelUp")]  //{@} required field??
    public int LevelUp { get; set; }
  }
}
