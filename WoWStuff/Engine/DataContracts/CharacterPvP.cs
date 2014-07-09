using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Engine.DataContracts
{
  [DataContract]
  public class CharacterPvP
  {
    [DataMember(Name = "arenaTeams")]
    public IEnumerable<CharacterArenaTeam> ArenaTeams { get; set; }

    [DataMember(Name = "ratedBattlegrounds")]
    public CharacterRatedBattlegrounds RatedBattlegrounds { get; set; }

    [DataMember(Name = "totalHonorableKills")]
    public int TotalHonorableKills { get; set; }
  }
}
