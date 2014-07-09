using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Engine.DataContracts
{
  [DataContract]
  public class ItemGemType
  {
    [DataMember(Name = "type")]
    public string Color { get; set; }
  }
}
