using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json;
using Engine.DataContracts;
using Engine.Utilities;
using Engine.Utilities.JSON;
using Engine.Explorer.Optionals;

namespace Engine.Explorer.Interface
{
  public interface IExplorer
  {
    Character GetCharacter(string realm, string name);
    Character GetCharacter(string realm, string name, CharacterOptions characterOptions);
    Character GetCharacter(Region region, string realm, string name);
    Character GetCharacter(Region region, string realm, string name, CharacterOptions characterOptions);
  }
}
