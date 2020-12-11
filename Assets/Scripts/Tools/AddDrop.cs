using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public static class AddDrop
{
    public static void Add(ref Dropdown drop, InputField label)
    {
        drop.captionText.text = label.text;

        drop.options.Add(new Dropdown.OptionData(label.text));
        drop.value = drop.options.Count - 1;

        if (drop.options.Count > 0)
            GameObject.FindGameObjectWithTag("EditButton").GetComponent<Button>().interactable = true;
    }
}
