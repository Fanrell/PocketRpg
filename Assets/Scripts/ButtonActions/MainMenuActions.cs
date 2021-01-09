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
    public Canvas addProfileCanvas;
    public InputField addProfileInput;
    public Dropdown profileDrop;

    public void Test()
    {
        CharacterSheet test;

    }
    public void Close()
    {
        Application.Quit();
    }

    public void Back()
    {
        SceneManager.LoadScene(0);
    }

    public void AddProfile()
    {
        addProfileCanvas.enabled = true;
    }

    public void DeleteProfile()
    {
        int toDelete = profileDrop.value;

        Directory.Delete(Paths._profilePath + profileDrop.options[toDelete].text, recursive: true);
        SceneManager.LoadScene(1);
    }

    public void GoToProfiles()
    {
        SceneManager.LoadScene(1);
    }

    public void GoToCharacterSheetProfile()
    {
        SceneManager.LoadScene(2);
    }

    public void DeleteCharacterSheet()
    {
        DeleteDrop.Delete(ref profileDrop);
    }

    private void CreateProfileDirectory(List<Dropdown.OptionData> list)
    {
       foreach(var item in list)
        {
            if(!Directory.Exists(Paths._profilePath+item.text))
            {
                Directory.CreateDirectory(Paths._profilePath + item.text);
            }
        }
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

    public void AddProfileToDrop()
    {
        string profileNameToAdd = addProfileInput.text;
        profileDrop.options.Add(new Dropdown.OptionData(profileNameToAdd));
    }


    public void ConfirmProfileSelection()
    {
        Debug.Log(File.Exists(Paths._profilePath));
        ProfileStatic.ProfileName = profileDrop.options[profileDrop.value].text;
        CreateProfileDirectory(profileDrop.options);
        SceneManager.LoadScene(0);
        ProfileStatic.ProfileFolderPath = Paths._profilePath + ProfileStatic.ProfileName+"/";

    }

    public void CharcterSheetCreator()
    {
        SceneManager.LoadScene(3);
    }

    public void ShowCharacterInfo()
    {
        CharacterSheet tmpChar;
        string charString;
        int index = profileDrop.value;
        charString = File.ReadAllText(ProfileStatic.ProfileFolderPath + profileDrop.options[index].text + ".dat");
        charString = Decrypter.Decrypting(charString);
        tmpChar = JsonUtility.FromJson<CharacterSheet>(charString);

        Debug.Log(tmpChar.name);

        tmpChar.CharToStatic();

        SceneManager.LoadScene(8);
    }
}
