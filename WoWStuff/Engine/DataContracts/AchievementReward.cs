using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Engine.DataContracts
{
  public class AchievementReward
  {
    [DataMember(Name = "id")]
    public int Id { get; set; }

    [DataMember(Name = "name")]
    public string Description { get; set; }

    [DataMember(Name = "icon")]
    public string Icon { get; set; }

    [DataMember(Name = "quality")]
    public int Quality { get; set; }

    [DataMember(Name = "tooltipParams")]
    public ItemTooltipParameters TooltipParams { get; set; }
  }
}
