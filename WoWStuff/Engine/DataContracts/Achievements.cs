using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Engine.DataContracts
{
  [DataContract]
  class Achievements
  {
    [DataMember(Name = "achievementsCompleted")]
    public IEnumerable<int> AchievementsCompleted { get; set; }

    [DataMember(Name = "achievementsCompletedTimestamp")]
    public IEnumerable<long> AchievemntsCompletedTimeStamp { get; set; }

    [DataMember(Name = "criteria")]
    public IEnumerable<long> Criteria { get; set; }

    [DataMember(Name = "criteriaCreated")]
    public IEnumerable<long> CriteriaCreated { get; set; }

    [DataMember(Name = "criteriaQuantity")]
    public IEnumerable<long> CriteriaQuantity { get; set; }

    [DataMember(Name = "criteriaTimestamp")]
    public IEnumerable<long> CriteriaTimeStamp { get; set; }
  }
}
