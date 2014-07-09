using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Engine.DataContracts
{
  [DataContract]
  public class ItemSocket
  {
    [DataMember(Name = "type")]
    public string Type { get; set; }
  }
}
