using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Engine.DataContracts
{
  [DataContract]
  public class ItemSourceInfo
  {
    [DataMember(Name = "sourceId")]
    public int SourceId { get; set; }

    [DataMember(Name = "sourceType")]
    public string SourceType { get; set; }
  }
}
