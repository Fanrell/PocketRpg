using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public static class CreateStatic 
{
    public static string name;
    public static string description;
    public static List<Dropdown.OptionData> stats;
    public static List<Dropdown.OptionData> ability;
    public static List<Dropdown.OptionData> skills;

    public static void Clear()
    {
        name = "";
        description = "";
        stats = new List<Dropdown.OptionData>();
        ability = new List<Dropdown.OptionData>();
        skills = new List<Dropdown.OptionData>();

    }

}
