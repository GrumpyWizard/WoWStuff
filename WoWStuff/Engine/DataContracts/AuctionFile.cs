using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Engine.DataContracts
{
  [DataContract]
  public class AuctionFile
  {
    [DataMember(Name = "url")]
    public string URL { get; set; }

    [DataMember(Name = "lastModified")]
    public long LastModified { get; set; }
  }
}
