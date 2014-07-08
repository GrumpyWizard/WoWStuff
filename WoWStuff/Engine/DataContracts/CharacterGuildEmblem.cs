using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Engine.DataContracts
{
  [DataContract]
  public class CharacterGuildEmblem
  {
    [DataMember(Name = "backgroundColor")]
    public string BackgroundColor { get; set; }

    [DataMember(Name = "border")]
    public int Border { get; set; }

    [DataMember(Name = "borderColor")]
    public string BorderColor { get; set; }

    [DataMember(Name = "icon")]
    public int Icon { get; set; }

    [DataMember(Name = "iconColor")]
    public string IconColor { get; set; }
  }
}
