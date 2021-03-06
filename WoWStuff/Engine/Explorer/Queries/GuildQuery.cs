﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Explorer.Optionals;


namespace Engine.Explorer.Queries
{
  public static class GuildQuery
  {
    public static string buildOptionalQuery(GuildOptions realmOptions)
    {
      string query = "&fields=";
      List<string> tmp = new List<string>();

      if ((realmOptions & GuildOptions.GetMembers) == GuildOptions.GetMembers)
        tmp.Add("members");

      if ((realmOptions & GuildOptions.GetAchievements) == GuildOptions.GetAchievements)
        tmp.Add("achievements");

      if ((realmOptions & GuildOptions.GetNews) == GuildOptions.GetNews)
        tmp.Add("news");

      if (tmp.Count == 0) return string.Empty;

      query += string.Join(",", tmp.ToArray());

      return query;
    }
  }
}
