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
        int profileToDelete = profileDrop.value;
        profileDrop.options.Remove(profileDrop.options[profileToDelete]);
        switch(profileDrop.options.Count)
        {
            case 0:
                profileDrop.captionText.text = "<<Create Profile>>";
                break;
            default:
                profileDrop.value = profileDrop.options.Count - 1;
                break;
        }
    }

    public void GoToProfiles()
    {
        SceneManager.LoadScene(1);
    }

    public void GoToCharacterSheetProfile()
    {
        SceneManager.LoadScene(2);
    }

    private void WriteListToFile(List<Dropdown.OptionData> list)
    {
        using(StreamWriter writer = new StreamWriter(ProfileFilePath.ProfilePath+"profile.prof",false))
        {
            
            foreach(var item in list)
            {
                writer.WriteLine( item.text );
                Debug.Log(item.text);
                
            }
            writer.Close();
        }
        Debug.Log(File.Exists(ProfileFilePath.ProfilePath + "profile.prof"));
    }

    public void ConfirmProfileSelection()
    {
        ProfileStatic.ProfileName = profileDrop.options[profileDrop.value].text;
        WriteListToFile(profileDrop.options);
        SceneManager.LoadScene(0);
    }
}
