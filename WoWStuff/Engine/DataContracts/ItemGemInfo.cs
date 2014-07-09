using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Engine.DataContracts
{
  [DataContract]
  public class ItemGemInfo
  {
    [DataMember(Name = "bonus")]
    public ItemGemBonusInfo Bonus { get; set; }

    [DataMember(Name = "type")]
    public ItemGemType Type { get; set; }
  }
}
