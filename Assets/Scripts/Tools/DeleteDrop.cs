using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// Tools set focused on delete elements from dropdown component.
/// </summary>
public static class DeleteDrop
{
    /// <summary>
    /// Save values from inputs fields to dropdown component.
    /// </summary>
    /// <param name="drop">Dropdown object.</param>
    /// <param name="labels">List of labels where you wanna delete values.</param>
    /// <param name="inputs">Array of InputFields to save in dropdown.</param>
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
            foreach (var item in GameObject.FindGameObjectsWithTag("HiddenButton"))
            {
                item.GetComponent<Button>().interactable = false;
            }
    }

    public static void Delete(ref Dropdown drop, List<string> labels, InputField[] inputs, Toggle check)
    {
        Delete(ref drop, labels, inputs);
        check.isOn = false;
    }

    public static void Delete(ref Dropdown drop, List<string> labels, GameObject[] inputs)
    {
        List<InputField> tmp = new List<InputField>();
        foreach (var item in inputs)
        {
            tmp.Add(item.GetComponent<InputField>());
        }
        Delete(ref drop, labels, tmp.ToArray());
    }

    public static void Delete(ref Dropdown drop)
    {
        int value = drop.value;
        File.Delete(ProfileStatic.ProfileFolderPath + "/" + drop.options[value].text + ".dat");

        drop.ClearOptions();
        FillDrop.Fill(ref drop, ProfileStatic.ProfileFolderPath);
    }
}