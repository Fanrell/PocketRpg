using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// Static class to fill Dropdown Unity component.
/// </summary>
public static class FillDrop
{

    public static void Fill(ref Dropdown drop, List<string> labels)
    {
        foreach (var item in labels)
        {
            drop.options.Add(new Dropdown.OptionData(item));
        }

        if (drop.options.Count > 0)
        {
            drop.value = 0;
            drop.captionText.text = drop.options[0].text;
        }
    }

    public static void Fill(ref Dropdown drop, string profilePath)
    {
        DirectoryInfo directory = new DirectoryInfo(profilePath);
        FileInfo[] sheets = directory.GetFiles("*.dat");
        if (sheets.Length > 0)
        {
            foreach (FileInfo sheet in sheets)
            {
                string sheetName = sheet.Name.Split('.')[0];
                drop.options.Add(new Dropdown.OptionData(sheetName));
            }

            drop.captionText.text = drop.options[0].text;
        }
    }
    /// <summary>
    /// Static method to find and save Profiles (Folders) to Dropdown component.
    /// </summary>
    /// <param name="drop">Ref to Dropdown component</param>
    /// <param name="pathToProfiles">path saved in string to place with profiles folders</param>
    public static void FillProfiles(ref Dropdown drop, string pathToProfiles)
    {
        DirectoryInfo directory = new DirectoryInfo(pathToProfiles);
        var dirs = directory.GetDirectories();
        if (dirs.Length > 0)
        {
            foreach (var folders in dirs)
            {
                drop.options.Add(new Dropdown.OptionData(folders.Name));
            }
            drop.captionText.text = drop.options[0].text;
        }
    }
}
