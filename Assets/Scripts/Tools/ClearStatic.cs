using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ClearStatic
{
    public static void Clear()
    {
        CharacterStatic.abilityDescription = new List<string>();
        CharacterStatic.abilityLable = new List<string>();
        CharacterStatic.abilityValue = new List<bool>();
        CharacterStatic.skillDescription = new List<string>();
        CharacterStatic.skillLable = new List<string>();
        CharacterStatic.skillValue = new List<int>();
        CharacterStatic.statsLable = new List<string>();
        CharacterStatic.statsValue = new List<List<int>>();
        CharacterStatic.charDescription = "";
        CharacterStatic.name = "";
    }
}
