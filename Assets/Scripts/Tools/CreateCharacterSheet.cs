using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class CreateCharacterSheet : MonoBehaviour
{
    
    public static void Create()
    {

        CharacterSheet character = new CharacterSheet();

        character.Name = CharacterStatic.name;
        character.Description = CharacterStatic.charDescription;

        for(int i = 0; i<CharacterStatic.statsLable.Count; i++)
        {
            Statistic statisticToAdd = new Statistic(CharacterStatic.statsLable[i], 
                CharacterStatic.statsValue[i].ToArray());
            character.Stats.Add(statisticToAdd);
        }

        for (int i = 0; i < CharacterStatic.abilityLable.Count; i++)
        {
            Ability abilityToAdd = new Ability();
            abilityToAdd.BuildAbility(CharacterStatic.abilityLable[i],
                CharacterStatic.abilityDescription[i],
                CharacterStatic.abilityValue[i]);
            character.Abilities.Add(abilityToAdd);
        }

        for (int i = 0; i < CharacterStatic.skillLable.Count; i++)
        {
            Skill skillToAdd = new Skill();
            skillToAdd.BuildSkill(CharacterStatic.skillLable[i],
                CharacterStatic.skillDescription[i],
                CharacterStatic.skillValue[i]);
            character.Skills.Add(skillToAdd);
        }

        for (int i = 0; i < CharacterStatic.eqLable.Count; i++)
        {
            Eq eqToAdd = new Eq();
            eqToAdd.BuildEq(CharacterStatic.eqLable[i],
                CharacterStatic.eqDescription[i]);
            character.equipment.Add(eqToAdd);
        }

        string toSave = JsonUtility.ToJson(character);
        File.WriteAllText(ProfileStatic.ProfileFolderPath + character.Name + ".dat", Crypter.Crypting(toSave));
        File.Delete(ProfileStatic.ProfileFolderPath + character.Name + ".dat.meta");

    }
}
