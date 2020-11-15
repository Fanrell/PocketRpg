using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddingProfileActionsButtons : MonoBehaviour
{
    public Dropdown profileListDrop;
    public InputField profileName;
    public Canvas addingCanvas;
    public void AddProfile()
    {
            profileListDrop.options.Add(new Dropdown.OptionData { text = profileName.text });
        if(profileListDrop.options.Count == 1)
        {
            profileListDrop.captionText.text = profileListDrop.options[0].text;
        }
        profileName.text = "";
        addingCanvas.enabled = false;
    }
}
