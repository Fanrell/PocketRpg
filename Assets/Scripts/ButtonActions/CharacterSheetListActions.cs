using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

/// <summary>
/// Class is set of actions for buttons at CharacterSheetList scene
/// </summary>
public class CharacterSheetListActions : MonoBehaviour
{
    [SerializeField]
    [Tooltip("Dropdown of characterSheets")]
    private Dropdown characterSheetList;
    /// <summary>
    /// Switch scene to MainMenu (scene 0)
    /// </summary>
    public void BackToMainMenu()
    {
        SceneManager.LoadScene(0);
    }
    /// <summary>
    /// Switch scene to ProfileList scene (scene 1)
    /// </summary>
    public void GoToProfiles()
    {
        SceneManager.LoadScene(1);
    }
    /// <summary>
    /// Delete CharacterSheet file and from dropdown
    /// </summary>
    public void DeleteCharacterSheet()
    {
        DeleteDrop.Delete(ref characterSheetList);
    }
    /// <summary>
    /// Switch to CharacterSheetCreator (scene 3)
    /// </summary>
    public void CharcterSheetCreator()
    {
        SceneSwitchStatic.SceneToSwitch = 2;
        SceneManager.LoadScene(3);
    }
    /// <summary>
    /// Decrypt character sheet from file and show information on screen at CharacterSheetInfo scene (scene 8)
    /// </summary>
    public void ShowCharacterInfo()
    {
        CharacterSheet tmpChar;
        string charString;
        int index = characterSheetList.value;
        charString = File.ReadAllText(ProfileStatic.ProfileFolderPath + characterSheetList.options[index].text + ".dat");
        charString = Decrypter.Decrypting(charString);
        tmpChar = JsonUtility.FromJson<CharacterSheet>(charString);

        tmpChar.CharToStatic();

        SceneManager.LoadScene(8);
    }
}
