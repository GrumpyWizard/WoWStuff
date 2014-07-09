using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Engine.DataContracts
{
  [DataContract]
  public class ItemClassInfo
  {
    [DataMember(Name = "class")]
    public int Class { get; set; }

    [DataMember(Name = "name")]
    public string Name { get; set; }
  }
}
