using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class FillList
{
    public static void FillSkill(List<SkillModel> fromCharacter)
    {
        foreach (var item in fromCharacter)
        {
            CharacterStatic.skillDescription.Add(item.SkillDescription);
            CharacterStatic.skillLable.Add(item.SkillLabel);
            CharacterStatic.skillValue.Add(item.SkillLevel);
        }
    }

    public static void FillAblity(List<AbilityModel> fromCharacter)
    {
        foreach (var item in fromCharacter)
        {
            CharacterStatic.abilityDescription.Add(item.AbilityDescription);
            CharacterStatic.abilityLable.Add(item.AbilityLabel);
            CharacterStatic.abilityValue.Add(item.AbilityKnown);
        }
    }

    public static void FillStats(List<StatisticModel> fromCharacter)
    {
        foreach (var item in fromCharacter)
        {
            CharacterStatic.statsLable.Add(item.Label);
            CharacterStatic.statsValue.Add(item.StatisticFields);
        }
    }

    public static void FillEq(List<ItemModel> fromCharacter)
    {
        foreach (var item in fromCharacter)
        {
            CharacterStatic.eqLable.Add(item.ItemName);
            CharacterStatic.eqDescription.Add(item.ItemDescription);
        }
    }
}
