using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Engine.DataContracts
{
  [DataContract]
  public class Challenge
  {
    [DataMember(Name = "groups")]
    public IEnumerable<ChallengeGroup> Groups { get; set; }

    [DataMember(Name = "map")]
    public ChallengeMap Map { get; set; }
  }
}
