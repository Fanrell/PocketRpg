using System.Collections;
using System.Collections.Generic;
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
        
        if(drop.options.Count > 0)
        {
            drop.value = 0;
            drop.captionText.text = drop.options[0].text;
        }
    }
}
