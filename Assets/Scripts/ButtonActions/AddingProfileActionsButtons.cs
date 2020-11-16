using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddingProfileActionsButtons : MonoBehaviour
{
    public Dropdown profileListDrop;
    public InputField profileName;
    public Canvas addingCanvas;
    public Text errorText;
    public void AddProfile()
    {
        Dropdown.OptionData tmp = new Dropdown.OptionData { text = profileName.text };
        bool conflict = false;
        foreach(var item in profileListDrop.options)
        {
            if(item.text == tmp.text)
            {
                conflict = true;
                break;
            }
        }

        if (!conflict)
        {
            profileListDrop.options.Add(new Dropdown.OptionData { text = profileName.text });
            if (profileListDrop.options.Count == 1)
            {
                profileListDrop.captionText.text = profileListDrop.options[0].text;
            }
            profileName.text = "";
            addingCanvas.enabled = false;
        }
        else
        {
            errorText.text = "This profile already exsits";
        }
    }
}
