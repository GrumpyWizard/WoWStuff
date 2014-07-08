using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Engine.DataContracts
{
  [DataContract]
  public class CharacterTalentSpec
  {
    [DataMember(Name = "backgroundImage")]
    public string BackgroundImage { get; set; }

    [DataMember(Name = "description")]
    public string Description { get; set; }

    [DataMember(Name = "icon")]
    public string Icon { get; set; }

    [DataMember(Name = "name")]
    public string Name { get; set; }

    [DataMember(Name = "order")]
    public int Order { get; set; }

    [DataMember(Name = "role")]
    public string Role { get; set; }
  }
}
