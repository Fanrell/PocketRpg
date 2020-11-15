using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuBehaviour : MonoBehaviour
{
    public Button characterSheetScreen;
    public Text profileName;

    // Start is called before the first frame update
    void Start()
    {
        if(ProfileStatic.ProfileName == null)
        {
            profileName.text = "<<No Profile Selected>>";
            characterSheetScreen.interactable = false;
        }
        else
        {
            profileName.text = ProfileStatic.ProfileName;
            characterSheetScreen.interactable = true;
        }
    }
}
