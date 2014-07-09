using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Engine.DataContracts
{
  [DataContract]
  public class BattlegroupInfo
  {
    [DataMember(Name = "name")]
    public string Name { get; set; }

    [DataMember(Name = "slug")]
    public string SLUG { get; set; }
  }
}
