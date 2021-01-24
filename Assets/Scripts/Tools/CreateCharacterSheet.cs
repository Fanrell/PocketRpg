using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine; 

public class CreateCharacterSheet : MonoBehaviour
{
    
    public static void Create()
    {

        CharacterSheet character = new CharacterSheet();

        character.characterInfo = CharInfoBuilder.Build
            (
            CharacterStatic.name, CharacterStatic.charDescription
            );

        for(int i = 0; i<CharacterStatic.statsLable.Count; i++)
        {
            character.Stats.Add
                (
                StatisticBuilder.Build(CharacterStatic.statsLable[i],
                CharacterStatic.statsValue[i])
                );
        }

        for (int i = 0; i < CharacterStatic.abilityLable.Count; i++)
        {
            
            character.Abilities.Add(AbilityBuilder.Build
                (
                CharacterStatic.abilityLable[i],
                CharacterStatic.abilityDescription[i],
                CharacterStatic.abilityValue[i])
                );
        }

        for (int i = 0; i < CharacterStatic.skillLable.Count; i++)
        {
            character.Skills.Add(SkillBuilder.Build
                (
                CharacterStatic.skillLable[i],
                CharacterStatic.skillDescription[i],
                CharacterStatic.skillValue[i])
                );
        }

        for (int i = 0; i < CharacterStatic.eqLable.Count; i++)
        {

            character.Inventory.Add(ItemBuilder.Build
                (
                CharacterStatic.eqLable[i],
                CharacterStatic.eqDescription[i])
                );
        }

        string toSave = JsonUtility.ToJson(character);
        Debug.Log(toSave);
        File.WriteAllText(ProfileStatic.ProfileFolderPath + character.characterInfo.CharacterName + ".dat", Crypter.Crypting(toSave));
        File.Delete(ProfileStatic.ProfileFolderPath + character.characterInfo.CharacterName + ".dat.meta");

    }
}
