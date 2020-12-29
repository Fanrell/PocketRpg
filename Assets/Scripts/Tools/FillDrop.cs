using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

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
        foreach(FileInfo sheet in sheets)
        {
            string sheetName = sheet.Name.Split('.')[0];
            drop.options.Add(new Dropdown.OptionData(sheetName));
        }

        drop.captionText.text = drop.options[0].text;
    }
}
