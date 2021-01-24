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
        {
            foreach (var item in GameObject.FindGameObjectsWithTag("HiddenButton"))
            {
                item.GetComponent<Button>().interactable = true;
            }
        }
    }

    public static void Add(ref Dropdown drop, List<string> labels)
    {
        if (labels.Count > 0)
        {
            foreach (var item in GameObject.FindGameObjectsWithTag("HiddenButton"))
            {
                item.GetComponent<Button>().interactable = true;
            }
            foreach(var item in labels)
            {
                drop.options.Add(new Dropdown.OptionData(item));
            }
            drop.captionText.text = labels[0];
        }

    }
}
