using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Engine.DataContracts
{
  [DataContract]
  class AchievementInfo
  {
    [DataMember(Name = "accountWide")]
    public bool AccountWide { get; set; }

    [DataMember(Name = "criteria")]
    public IEnumerable<AchievementCriteria> Criteria { get; set; }
    
    [DataMember(Name = "description")]
    public string Description { get; set; }

    [DataMember(Name = "factionId")]
    public int FactionId { get; set; }
    
    [DataMember(Name = "icon")]
    public string Icon { get; set; }
    
    [DataMember(Name = "id")]
    public int Id { get; set; }
    
    [DataMember(Name = "points")]
    public int Points { get; set; }
    
    [DataMember(Name = "reward")]
    public string Reward { get; set; }    
    
    [DataMember(Name = "rewardItems")]
    public IEnumerable<AchievementReward> RewardItems { get; set; }    
    
    [DataMember(Name = "title")]
    public string Title { get; set; }
  }
}
