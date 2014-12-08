using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Explorer.Optionals
{
  [Flags]
  public enum GuildOptions
  {
    None = 0,
    GetMembers = 1,
    GetAchievements = 2,
    GetNews = 4,
    GetEverything = GetMembers | GetAchievements | GetNews
  }
}
