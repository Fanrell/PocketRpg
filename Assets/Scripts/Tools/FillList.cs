using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class FillList
{
    public static void FillSkill(List<Skill> fromCharacter)
    {
        foreach (var item in fromCharacter)
        {
            CharacterStatic.skillDescription.Add(item.Discription);
            CharacterStatic.skillLable.Add(item.Label);
            CharacterStatic.skillValue.Add((int)item.Level);
        }
    }

    public static void FillAblity(List<Ability> fromCharacter)
    {
        foreach (var item in fromCharacter)
        {
            CharacterStatic.abilityDescription.Add(item.Discription);
            CharacterStatic.abilityLable.Add(item.Label);
            CharacterStatic.abilityValue.Add(item.possess);
        }
    }

    public static void FillStats(List<Statistic> fromCharacter)
    {
        foreach (var item in fromCharacter)
        {
            CharacterStatic.statsLable.Add(item.label);
            CharacterStatic.statsValue.Add(item.Stats);
        }
    }

    public static void FillEq(List<Eq> fromCharacter)
    {
        foreach (var item in fromCharacter)
        {
            CharacterStatic.eqLable.Add(item.Label);
            CharacterStatic.eqDescription.Add(item.Discription);
        }
    }
}
