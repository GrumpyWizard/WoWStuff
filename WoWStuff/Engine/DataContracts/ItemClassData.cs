using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Engine.DataContracts
{
  [DataContract]
  public class ItemClassData
  {
    [DataMember(Name = "classes")]
    public IEnumerable<ItemClassInfo> Classes { get; set; }
  }
}
