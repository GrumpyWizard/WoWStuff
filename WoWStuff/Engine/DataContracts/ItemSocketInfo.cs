using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Engine.DataContracts
{
  [DataContract]
  public class ItemSocketInfo
  {
    [DataMember(Name = "sockets")]
    public IEnumerable<ItemSocket> Sockets { get; set; }  
  }
}
