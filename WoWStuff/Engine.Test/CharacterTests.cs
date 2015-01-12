using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Engine.DataContracts;
using Engine.Explorer;


namespace Engine.Test
{
  [TestClass]
  public class CharacterTests
  {
    private static WoWExplorer TheWoWExplorer;
    private static string TheApiKey = "twz3ufwuydydnhha5rkk8rjfjuqzm4c8"; // To get your api key, register at https://dev.battle.net/

    private static string CharacterName = "Mixup";
    private static string RealmName = "ShadowSong";

    [ClassInitialize]
    public static void ClassInit(TestContext context)
    {
      TheWoWExplorer = new WoWExplorer(Explorer.Optionals.Region.EU, Explorer.Optionals.Locale.en_GB, TheApiKey);
    }

    [TestMethod]
    public void GetBasicCharacterDataFromRealm()
    {
      var Character = TheWoWExplorer.GetCharacter(RealmName, CharacterName);

      Assert.IsNull(Character.CharacterAchievements);
      Assert.IsNull(Character.CharacterAppearance);
      Assert.IsNull(Character.Guild);
      Assert.IsNull(Character.Items);
      Assert.IsNull(Character.Mounts);
      Assert.IsNull(Character.Pets);
      Assert.IsNull(Character.PetSlots);
      Assert.IsNull(Character.Professions);
      Assert.IsNull(Character.Progression);
      Assert.IsNull(Character.Reputation);
      Assert.IsNull(Character.Stats);
      Assert.IsNull(Character.Talents);
      Assert.IsNull(Character.Titles);

      Assert.IsTrue(Character.Name.Equals(CharacterName, StringComparison.OrdinalIgnoreCase));
      Assert.AreEqual(100, Character.Level);
      Assert.AreEqual(CharacterClass.ROGUE, Character.yourClass);
      Assert.AreEqual(CharacterGender.FEMALE, Character.Gender);
      Assert.AreEqual(CharacterRace.HUMAN, Character.Race);
    }

    [TestMethod]
    public void GetBasicCharacterDataFromRealm_WithCharacterAchievements()
    {
      var Character = TheWoWExplorer.GetCharacter(RealmName, CharacterName, Explorer.Optionals.CharacterOptions.GetAchievements);

      Assert.IsNotNull(Character.CharacterAchievements);
      Assert.IsNull(Character.CharacterAppearance);
      Assert.IsNull(Character.Guild);
      Assert.IsNull(Character.Items);
      Assert.IsNull(Character.Mounts);
      Assert.IsNull(Character.Pets);
      Assert.IsNull(Character.PetSlots);
      Assert.IsNull(Character.Professions);
      Assert.IsNull(Character.Progression);
      Assert.IsNull(Character.Reputation);
      Assert.IsNull(Character.Stats);
      Assert.IsNull(Character.Talents);
      Assert.IsNull(Character.Titles);

      Assert.IsTrue(Character.Name.Equals(CharacterName, StringComparison.OrdinalIgnoreCase));
      Assert.AreEqual(100, Character.Level);
      Assert.AreEqual(CharacterClass.ROGUE, Character.yourClass);
      Assert.AreEqual(CharacterGender.FEMALE, Character.Gender);
      Assert.AreEqual(CharacterRace.HUMAN, Character.Race);
    }

    [TestMethod]
    public void GetBasicCharacterDataFromRealm_WithCharacterAppearance()
    {
      var Character = TheWoWExplorer.GetCharacter(RealmName, CharacterName, Explorer.Optionals.CharacterOptions.GetAppearance);

      Assert.IsNull(Character.CharacterAchievements);
      Assert.IsNotNull(Character.CharacterAppearance);
      Assert.IsNull(Character.Guild);
      Assert.IsNull(Character.Items);
      Assert.IsNull(Character.Mounts);
      Assert.IsNull(Character.Pets);
      Assert.IsNull(Character.PetSlots);
      Assert.IsNull(Character.Professions);
      Assert.IsNull(Character.Progression);
      Assert.IsNull(Character.Reputation);
      Assert.IsNull(Character.Stats);
      Assert.IsNull(Character.Talents);
      Assert.IsNull(Character.Titles);

      Assert.IsTrue(Character.Name.Equals(CharacterName, StringComparison.OrdinalIgnoreCase));
      Assert.AreEqual(100, Character.Level);
      Assert.AreEqual(CharacterClass.ROGUE, Character.yourClass);
      Assert.AreEqual(CharacterGender.FEMALE, Character.Gender);
      Assert.AreEqual(CharacterRace.HUMAN, Character.Race);
    }

    [TestMethod]
    public void GetBasicCharacterDataFromRealm_WithGuild()
    {
      var Character = TheWoWExplorer.GetCharacter(RealmName, CharacterName, Explorer.Optionals.CharacterOptions.GetGuild);

      Assert.IsNull(Character.CharacterAchievements);
      Assert.IsNull(Character.CharacterAppearance);
      Assert.IsNotNull(Character.Guild);
      Assert.IsNull(Character.Items);
      Assert.IsNull(Character.Mounts);
      Assert.IsNull(Character.Pets);
      Assert.IsNull(Character.PetSlots);
      Assert.IsNull(Character.Professions);
      Assert.IsNull(Character.Progression);
      Assert.IsNull(Character.Reputation);
      Assert.IsNull(Character.Stats);
      Assert.IsNull(Character.Talents);
      Assert.IsNull(Character.Titles);

      Assert.IsTrue(Character.Name.Equals(CharacterName, StringComparison.OrdinalIgnoreCase));
      Assert.AreEqual(100, Character.Level);
      Assert.AreEqual(CharacterClass.ROGUE, Character.yourClass);
      Assert.AreEqual(CharacterGender.FEMALE, Character.Gender);
      Assert.AreEqual(CharacterRace.HUMAN, Character.Race);      
    }

    [TestMethod]
    public void GetBasicCharacterDataFromRealm_WithItems()
    {
      var Character = TheWoWExplorer.GetCharacter(RealmName, CharacterName, Explorer.Optionals.CharacterOptions.GetItems);

      Assert.IsNull(Character.CharacterAchievements);
      Assert.IsNull(Character.CharacterAppearance);
      Assert.IsNull(Character.Guild);
      Assert.IsNotNull(Character.Items);
      Assert.IsNull(Character.Mounts);
      Assert.IsNull(Character.Pets);
      Assert.IsNull(Character.PetSlots);
      Assert.IsNull(Character.Professions);
      Assert.IsNull(Character.Progression);
      Assert.IsNull(Character.Reputation);
      Assert.IsNull(Character.Stats);
      Assert.IsNull(Character.Talents);
      Assert.IsNull(Character.Titles);

      Assert.IsTrue(Character.Name.Equals(CharacterName, StringComparison.OrdinalIgnoreCase));
      Assert.AreEqual(100, Character.Level);
      Assert.AreEqual(CharacterClass.ROGUE, Character.yourClass);
      Assert.AreEqual(CharacterGender.FEMALE, Character.Gender);
      Assert.AreEqual(CharacterRace.HUMAN, Character.Race); 
    }

    [TestMethod]
    public void GetBasicCharacterDataFromRealm_WithMounts()
    {
      var Character = TheWoWExplorer.GetCharacter(RealmName, CharacterName, Explorer.Optionals.CharacterOptions.GetMounts);

      Assert.IsNull(Character.CharacterAchievements);
      Assert.IsNull(Character.CharacterAppearance);
      Assert.IsNull(Character.Guild);
      Assert.IsNull(Character.Items);
      Assert.IsNotNull(Character.Mounts);
      Assert.IsNull(Character.Pets);
      Assert.IsNull(Character.PetSlots);
      Assert.IsNull(Character.Professions);
      Assert.IsNull(Character.Progression);
      Assert.IsNull(Character.Reputation);
      Assert.IsNull(Character.Stats);
      Assert.IsNull(Character.Talents);
      Assert.IsNull(Character.Titles);

      Assert.IsTrue(Character.Name.Equals(CharacterName, StringComparison.OrdinalIgnoreCase));
      Assert.AreEqual(100, Character.Level);
      Assert.AreEqual(CharacterClass.ROGUE, Character.yourClass);
      Assert.AreEqual(CharacterGender.FEMALE, Character.Gender);
      Assert.AreEqual(CharacterRace.HUMAN, Character.Race);
      Assert.IsTrue(Character.Mounts.NumCollected > 1);
    }

    [TestMethod]
    public void GetBasicCharacterDataFromRealm_WithPets()
    {
      var Character = TheWoWExplorer.GetCharacter(RealmName, CharacterName, Explorer.Optionals.CharacterOptions.GetPets);

      Assert.IsNull(Character.CharacterAchievements);
      Assert.IsNull(Character.CharacterAppearance);
      Assert.IsNull(Character.Guild);
      Assert.IsNull(Character.Items);
      Assert.IsNull(Character.Mounts);
      Assert.IsNotNull(Character.Pets);
      Assert.IsNull(Character.PetSlots);
      Assert.IsNull(Character.Professions);
      Assert.IsNull(Character.Progression);
      Assert.IsNull(Character.Reputation);
      Assert.IsNull(Character.Stats);
      Assert.IsNull(Character.Talents);
      Assert.IsNull(Character.Titles);

      Assert.IsTrue(Character.Name.Equals(CharacterName, StringComparison.OrdinalIgnoreCase));
      Assert.AreEqual(100, Character.Level);
      Assert.AreEqual(CharacterClass.ROGUE, Character.yourClass);
      Assert.AreEqual(CharacterGender.FEMALE, Character.Gender);
      Assert.AreEqual(CharacterRace.HUMAN, Character.Race);
      Assert.IsTrue(Character.Pets.NumCollected > 1);
    }

    [TestMethod]
    public void GetBasicCharacterDataFromRealm_WithPetSlots()
    {
      var Character = TheWoWExplorer.GetCharacter(RealmName, CharacterName, Explorer.Optionals.CharacterOptions.GetPetSlots);

      Assert.IsNull(Character.CharacterAchievements);
      Assert.IsNull(Character.CharacterAppearance);
      Assert.IsNull(Character.Guild);
      Assert.IsNull(Character.Items);
      Assert.IsNull(Character.Mounts);
      Assert.IsNull(Character.Pets);
      Assert.IsNotNull(Character.PetSlots);
      Assert.IsNull(Character.Professions);
      Assert.IsNull(Character.Progression);
      Assert.IsNull(Character.Reputation);
      Assert.IsNull(Character.Stats);
      Assert.IsNull(Character.Talents);
      Assert.IsNull(Character.Titles);

      Assert.IsTrue(Character.Name.Equals(CharacterName, StringComparison.OrdinalIgnoreCase));
      Assert.AreEqual(100, Character.Level);
      Assert.AreEqual(CharacterClass.ROGUE, Character.yourClass);
      Assert.AreEqual(CharacterGender.FEMALE, Character.Gender);
      Assert.AreEqual(CharacterRace.HUMAN, Character.Race);
      Assert.IsTrue(Character.PetSlots.Count() > 0);
    }

    [TestMethod]
    public void GetBasicCharacterDataFromRealm_WithProfessions()
    {
      var Character = TheWoWExplorer.GetCharacter(RealmName, CharacterName, Explorer.Optionals.CharacterOptions.GetProfessions);

      Assert.IsNull(Character.CharacterAchievements);
      Assert.IsNull(Character.CharacterAppearance);
      Assert.IsNull(Character.Guild);
      Assert.IsNull(Character.Items);
      Assert.IsNull(Character.Mounts);
      Assert.IsNull(Character.Pets);
      Assert.IsNull(Character.PetSlots);
      Assert.IsNotNull(Character.Professions);
      Assert.IsNull(Character.Progression);
      Assert.IsNull(Character.Reputation);
      Assert.IsNull(Character.Stats);
      Assert.IsNull(Character.Talents);
      Assert.IsNull(Character.Titles);

      Assert.IsTrue(Character.Name.Equals(CharacterName, StringComparison.OrdinalIgnoreCase));
      Assert.AreEqual(100, Character.Level);
      Assert.AreEqual(CharacterClass.ROGUE, Character.yourClass);
      Assert.AreEqual(CharacterGender.FEMALE, Character.Gender);
      Assert.AreEqual(CharacterRace.HUMAN, Character.Race);
    }

    [TestMethod]
    public void GetBasicCharacterDataFromRealm_WithProgression()
    {
      var Character = TheWoWExplorer.GetCharacter(RealmName, CharacterName, Explorer.Optionals.CharacterOptions.GetProgression);

      Assert.IsNull(Character.CharacterAchievements);
      Assert.IsNull(Character.CharacterAppearance);
      Assert.IsNull(Character.Guild);
      Assert.IsNull(Character.Items);
      Assert.IsNull(Character.Mounts);
      Assert.IsNull(Character.Pets);
      Assert.IsNull(Character.PetSlots);
      Assert.IsNull(Character.Professions);
      Assert.IsNotNull(Character.Progression);
      Assert.IsNull(Character.Reputation);
      Assert.IsNull(Character.Stats);
      Assert.IsNull(Character.Talents);
      Assert.IsNull(Character.Titles);

      Assert.IsTrue(Character.Name.Equals(CharacterName, StringComparison.OrdinalIgnoreCase));
      Assert.AreEqual(100, Character.Level);
      Assert.AreEqual(CharacterClass.ROGUE, Character.yourClass);
      Assert.AreEqual(CharacterGender.FEMALE, Character.Gender);
      Assert.AreEqual(CharacterRace.HUMAN, Character.Race);
    }

    [TestMethod]
    public void GetBasicCharacterDataFromRealm_WithReputation()
    {
      var Character = TheWoWExplorer.GetCharacter(RealmName, CharacterName, Explorer.Optionals.CharacterOptions.GetReputation);

      Assert.IsNull(Character.CharacterAchievements);
      Assert.IsNull(Character.CharacterAppearance);
      Assert.IsNull(Character.Guild);
      Assert.IsNull(Character.Items);
      Assert.IsNull(Character.Mounts);
      Assert.IsNull(Character.Pets);
      Assert.IsNull(Character.PetSlots);
      Assert.IsNull(Character.Professions);
      Assert.IsNull(Character.Progression);
      Assert.IsNotNull(Character.Reputation);
      Assert.IsNull(Character.Stats);
      Assert.IsNull(Character.Talents);
      Assert.IsNull(Character.Titles);

      Assert.IsTrue(Character.Name.Equals(CharacterName, StringComparison.OrdinalIgnoreCase));
      Assert.AreEqual(100, Character.Level);
      Assert.AreEqual(CharacterClass.ROGUE, Character.yourClass);
      Assert.AreEqual(CharacterGender.FEMALE, Character.Gender);
      Assert.AreEqual(CharacterRace.HUMAN, Character.Race);
    }

    [TestMethod]
    public void GetBasicCharacterDataFromRealm_WithStats()
    {
      var Character = TheWoWExplorer.GetCharacter(RealmName, CharacterName, Explorer.Optionals.CharacterOptions.GetStats);

      Assert.IsNull(Character.CharacterAchievements);
      Assert.IsNull(Character.CharacterAppearance);
      Assert.IsNull(Character.Guild);
      Assert.IsNull(Character.Items);
      Assert.IsNull(Character.Mounts);
      Assert.IsNull(Character.Pets);
      Assert.IsNull(Character.PetSlots);
      Assert.IsNull(Character.Professions);
      Assert.IsNull(Character.Progression);
      Assert.IsNull(Character.Reputation);
      Assert.IsNotNull(Character.Stats);
      Assert.IsNull(Character.Talents);
      Assert.IsNull(Character.Titles);

      Assert.IsTrue(Character.Name.Equals(CharacterName, StringComparison.OrdinalIgnoreCase));
      Assert.AreEqual(100, Character.Level);
      Assert.AreEqual(CharacterClass.ROGUE, Character.yourClass);
      Assert.AreEqual(CharacterGender.FEMALE, Character.Gender);
      Assert.AreEqual(CharacterRace.HUMAN, Character.Race);
    }

    [TestMethod]
    public void GetBasicCharacterDataFromRealm_WithTalents()
    {
      var Character = TheWoWExplorer.GetCharacter(RealmName, CharacterName, Explorer.Optionals.CharacterOptions.GetTalents);

      Assert.IsNull(Character.CharacterAchievements);
      Assert.IsNull(Character.CharacterAppearance);
      Assert.IsNull(Character.Guild);
      Assert.IsNull(Character.Items);
      Assert.IsNull(Character.Mounts);
      Assert.IsNull(Character.Pets);
      Assert.IsNull(Character.PetSlots);
      Assert.IsNull(Character.Professions);
      Assert.IsNull(Character.Progression);
      Assert.IsNull(Character.Reputation);
      Assert.IsNull(Character.Stats);
      Assert.IsNotNull(Character.Talents);
      Assert.IsNull(Character.Titles);

      Assert.IsTrue(Character.Name.Equals(CharacterName, StringComparison.OrdinalIgnoreCase));
      Assert.AreEqual(100, Character.Level);
      Assert.AreEqual(CharacterClass.ROGUE, Character.yourClass);
      Assert.AreEqual(CharacterGender.FEMALE, Character.Gender);
      Assert.AreEqual(CharacterRace.HUMAN, Character.Race);
    }

    [TestMethod]
    public void GetBasicCharacterDataFromRealm_WithTitles()
    {
      var Character = TheWoWExplorer.GetCharacter(RealmName, CharacterName, Explorer.Optionals.CharacterOptions.GetTitles);

      Assert.IsNull(Character.CharacterAchievements);
      Assert.IsNull(Character.CharacterAppearance);
      Assert.IsNull(Character.Guild);
      Assert.IsNull(Character.Items);
      Assert.IsNull(Character.Mounts);
      Assert.IsNull(Character.Pets);
      Assert.IsNull(Character.PetSlots);
      Assert.IsNull(Character.Professions);
      Assert.IsNull(Character.Progression);
      Assert.IsNull(Character.Reputation);
      Assert.IsNull(Character.Stats);
      Assert.IsNull(Character.Talents);
      Assert.IsNotNull(Character.Titles);

      Assert.IsTrue(Character.Name.Equals(CharacterName, StringComparison.OrdinalIgnoreCase));
      Assert.AreEqual(100, Character.Level);
      Assert.AreEqual(CharacterClass.ROGUE, Character.yourClass);
      Assert.AreEqual(CharacterGender.FEMALE, Character.Gender);
      Assert.AreEqual(CharacterRace.HUMAN, Character.Race);
    }

    [TestMethod]
    public void GetAllCharacterDataFromRealm()
    {
       var Character = TheWoWExplorer.GetCharacter(RealmName, CharacterName, Explorer.Optionals.CharacterOptions.GetEverything);

      Assert.IsNotNull(Character.CharacterAchievements);
      Assert.IsNotNull(Character.CharacterAppearance);
      Assert.IsNotNull(Character.Guild);
      Assert.IsNotNull(Character.Items);
      Assert.IsNotNull(Character.Mounts);
      Assert.IsNotNull(Character.Pets);
      Assert.IsNotNull(Character.PetSlots);
      Assert.IsNotNull(Character.Professions);
      Assert.IsNotNull(Character.Progression);
      Assert.IsNotNull(Character.Reputation);
      Assert.IsNotNull(Character.Stats);
      Assert.IsNotNull(Character.Talents);
      Assert.IsNotNull(Character.Titles);

      Assert.IsTrue(Character.Name.Equals(CharacterName, StringComparison.OrdinalIgnoreCase));
      Assert.AreEqual(100, Character.Level);
      Assert.AreEqual(CharacterClass.ROGUE, Character.yourClass);
      Assert.AreEqual(CharacterGender.FEMALE, Character.Gender);
      Assert.AreEqual(CharacterRace.HUMAN, Character.Race);
      // Additional Assertions
      //Character.Talents.ElementAt(0).Glyphs.ToString
    }

  }
}
