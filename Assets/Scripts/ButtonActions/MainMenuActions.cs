using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.IO;
using System.Collections.Generic;
using System.Text;

public class MainMenuActions : MonoBehaviour
{
    public Canvas addProfileCanvas;
    public Dropdown profileDrop;


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

        Directory.Delete(ProfileFilePath._profilePath + profileDrop.options[toDelete].text);
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

    private void CreateProfileDirectory(List<Dropdown.OptionData> list)
    {
       foreach(var item in list)
        {
            if(!Directory.Exists(ProfileFilePath._profilePath+item.text))
            {
                Directory.CreateDirectory(ProfileFilePath._profilePath + item.text);
            }
        }
    }


    public void ConfirmProfileSelection()
    {
        Debug.Log(File.Exists(ProfileFilePath._profilePath));
        ProfileStatic.ProfileName = profileDrop.options[profileDrop.value].text;
        CreateProfileDirectory(profileDrop.options);
        SceneManager.LoadScene(0);
    }
}
