using System.Net.Mime;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.IO;
using System.Collections.Generic;
using System.Text;

public class MainMenuActions : MonoBehaviour
{

    public void Close()
    {
        Application.Quit();
    }

    public void GoToCharacterSheetProfile()
    {
        SceneManager.LoadScene(2);
    }

    public void GoToProfiles()
    {
        SceneManager.LoadScene(1);
    }

    public void CharInfo()
    {
        InputField[] fileds = FindObjectsOfType<InputField>();
        for(int i = 0; i<fileds.Length; i++)
        {
            switch(fileds[i].tag.ToLower())
            {
                case("description"):
                CharacterStatic.charDescription = fileds[i].text;
                break;
                case("name"):
                CharacterStatic.name = fileds[i].text;
                break;
            }
        }
        SceneManager.LoadScene(4);
    }
}
