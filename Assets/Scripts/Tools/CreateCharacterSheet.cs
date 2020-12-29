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

        //using (StreamWriter file = File.CreateText(ProfileStatic.ProfileFolderPath + "\\" + ProfileStatic.ProfileName + "\\" + character.Name + ".char"))
            string toSave = JsonUtility.ToJson(character);
        Debug.Log(toSave);
        File.WriteAllText(ProfileStatic.ProfileFolderPath + character.Name + ".dat", toSave);

    }
}
