using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public static class DeleteDrop
{
    public static void Delete(ref Dropdown drop, List<string> labels, InputField[] inputs)
    {
        drop.ClearOptions();
        if (labels.Count > 0)
        {
            FillDrop.Fill(ref drop, labels);
        }
        else
        {
            foreach (var item in inputs)
            {
                item.text = null;
            }
        }
        if (drop.options.Count == 0)
            GameObject.FindGameObjectWithTag("EditButton").GetComponent<Button>().interactable = false;
    }

    public static void Delete(ref Dropdown drop, List<string> labels, InputField[] inputs, Toggle check)
    {
        Delete(ref drop, labels, inputs);
        check.isOn = false;
    }

    public static void Delete(ref Dropdown drop, List<string> labels, GameObject[] inputs)
    {
        List<InputField> tmp = new List<InputField>();
        foreach(var item in inputs)
        {
            tmp.Add(item.GetComponent<InputField>());
        }
        Delete(ref drop, labels, tmp.ToArray());
    }
}
