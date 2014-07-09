﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Engine.DataContracts
{
  [DataContract]
  public class ItemWeaponInfo
  {
    [DataMember(Name = "damage")]
    public ItemWeaponDamage Damage { get; set; }

    [DataMember(Name = "weaponSpeed")]
    public double WeaponSpeed { get; set; }

    [DataMember(Name = "dps")]
    public double Dps { get; set; }
  }
}
