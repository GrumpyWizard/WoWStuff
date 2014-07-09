using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Engine.DataContracts
{
  [DataContract]
  public class AchievementData
  {
    [DataMember(Name = "achievements")]
    public IEnumerable<AchievementList> Lists { get; set; }
  }
}
