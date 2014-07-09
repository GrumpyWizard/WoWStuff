using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Engine.DataContracts
{
  [DataContract]
  public class Character
  {
    /// <summary>
    /// Source: http://blizzard.github.io/api-wow-docs/#character-profile-api
    /// </summary>

    [DataMember(Name = "achievementPoints")]
    public int AchievementPoints { get; set; }

    [DataMember(Name = "battleGroup")]
    public string BattleGroup { get; set; }

    [DataMember(Name = "calcClass")]
    public char CalcClass { get; set; }
    
    [DataMember(Name = "class")]
    public CharacterClass @class { get; set; }

    [DataMember(Name = "gender")]
    public CharacterGender gender { get; set; }

    [DataMember(Name = "lastModified")]
    public string LastModified { get; set; }

    [DataMember(Name = "level")]
    public int Level { get; set; }

    [DataMember(Name = "name")]
    public string Name { get; set; }

    [DataMember(Name = "race")]
    public CharacterRace race { get; set; }

    [DataMember(Name = "realm")]
    public string Realm { get; set; }

    [DataMember(Name = "thumbnail")]
    public string ThumbNail { get; set; }

    // The remaining data members are optional. They are requested through the 'fields' query string parameter.
    // Example: http://us.battle.net/api/wow/character/Medivh/Uther?fields=guild,items,professions,reputation,stats

    [DataMember(Name = "achievements")]
    public Achievements CharacterAchievements { get; set; }

    [DataMember(Name = "appearance")]
    public CharacterAppearance CharacterAppearance { get; set; }

    [DataMember(Name = "feed")]
    public IEnumerable<CharacterFeed> Feed { get; set; }

    [DataMember(Name = "guild")]
    public CharacterGuild Guild { get; set; }

    [DataMember(Name = "hunterPets")]
    public IEnumerable<CharacterHunterPet> HunterPets { get; set; }

    [DataMember(Name = "items")]
    public CharacterEquipment Items { get; set; }

    [DataMember(Name = "mounts")]
    public CharacterMounts Mounts { get; set; }

    [DataMember(Name = "pets")]
    public CharacterPets Pets { get; set; }

    [DataMember(Name = "petSlots")]
    public IEnumerable<CharacterPetSlot> PetSlots { get; set; }

    [DataMember(Name = "professions")]
    public CharacterProfessions Professions { get; set; }

    [DataMember(Name = "progression")]
    public Progression Progression { get; set; }

    [DataMember(Name = "pvp")]
    public CharacterPvP PvP { get; set; }

    [DataMember(Name = "quests")]
    public IEnumerable<int> Quests { get; set; }

    [DataMember(Name = "reputation")]
    public IEnumerable<CharacterReputation> Reputation { get; set; }

    [DataMember(Name = "stats")]
    public CharacterStats Stats { get; set; }

    [DataMember(Name = "talents")]
    public IEnumerable<CharacterTalent> Talents { get; set; }

    [DataMember(Name = "titles")]
    public IEnumerable<CharacterTitle> Titles { get; set; }

    public CharacterClass Class { get { return (CharacterClass)Enum.Parse(typeof(CharacterClass), Enum.GetName(typeof(CharacterClass), @class).Replace(' ', '_')); } }
    public CharacterRace Race { get { return (CharacterRace)Enum.Parse(typeof(CharacterRace), Enum.GetName(typeof(CharacterRace), race).Replace(' ', '_')); } }
    public CharacterGender Gender { get { return (CharacterGender)Enum.Parse(typeof(CharacterGender), Enum.GetName(typeof(CharacterGender), gender).Replace(' ', '_')); } }

    public override bool Equals(object obj)
    {
      return base.Equals(obj);
    }

    public override int GetHashCode()
    {
      return base.GetHashCode();
    }

    public static bool operator ==(Character c1, Character c2)
    {
      if (c1.AchievementPoints == c2.AchievementPoints &&
          c1.BattleGroup == c2.BattleGroup &&
          c1.CalcClass == c2.CalcClass &&
          c1.@Class == c2.@Class &&
          c1.Gender == c2.Gender &&
          c1.LastModified == c2.LastModified &&
          c1.Level == c2.Level &&
          c1.Name == c2.Name &&
          c1.Race == c2.Race &&
          c1.Realm == c2.Realm &&
          c1.ThumbNail == c2.ThumbNail)
      {
        return true;
      }
      return false;
    }

    public static bool operator !=(Character c1, Character c2)
    {
      return !(c1 == c2);
    }
  }
}
