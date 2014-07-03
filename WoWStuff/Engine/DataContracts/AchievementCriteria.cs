using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Engine.DataContracts
{
  [DataContract]
  class AchievementCriteria
  {
    [DataMember(Name = "description")]
    public string Description { get; set; }

    [DataMember(Name = "id")]
    public int Id { get; set; }

    [DataMember(Name = "max")]
    public int Max { get; set; }

    [DataMember(Name = "orderIndex")]
    public int OrderIndex { get; set; }
  }
}
