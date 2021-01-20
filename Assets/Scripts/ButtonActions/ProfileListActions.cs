using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
/// <summary>
/// Set of methods for ProfileListScene
/// </summary>
public class ProfileListActions : MonoBehaviour
{ 
    [SerializeField]
    [Tooltip("Canvas with form to add profile")]
    private Canvas addProfileCanvas;
    [SerializeField]
    [Tooltip("Inputfield with name of new profile")]
    private InputField addProfileInput;
    [SerializeField]
    [Tooltip("Place to write error message")]
    private Text ErrorField;
    [SerializeField]
    [Tooltip("Dropdown of profiles")]
    private Dropdown profileDrop;
    /// <summary>
    /// Show hidden form for creat new profile
    /// </summary>
    public void ShowProfileAddForm()
    {
        addProfileCanvas.enabled = true;
    }
    /// <summary>
    /// Delete profile from dropdown and from resource folder
    /// </summary>
    public void DeleteProfile()
    {
        int toDelete = profileDrop.value;

        Directory.Delete(ProfileStatic.ProfilePath + profileDrop.options[toDelete].text, recursive: true);
        SceneManager.LoadScene(1);
    }
    /// <summary>
    /// Add profile to Dropdown if name is avaiable and restart this scene.
    /// If not show error message.
    /// </summary>
    public void AddProfileToDrop()
    {
            string profileNameToAdd = addProfileInput.text;
        if(CreateProfileDirectory(profileNameToAdd))
        {
            SceneManager.LoadScene(1);
        }
        else
        {
            ErrorField.text = "This profile already exsist";
        }
    }
    /// <summary>
    /// Confirm selection profile, save profile name in static class and load Main Menu (Scene 0)
    /// </summary>
    public void ConfirmProfileSelection()
    {
        ProfileStatic.ProfileName = profileDrop.options[profileDrop.value].text;
        ProfileStatic.ProfileFolderPath = ProfileStatic.ProfilePath + ProfileStatic.ProfileName + "/";
        BackToMainMenu();
    }
    /// <summary>
    /// Back to Main Menu (scene 0)
    /// </summary>
    public void BackToMainMenu()
    {
        SceneManager.LoadScene(0);
    }
    /// <summary>
    /// Try if profile name is avaiable and create folder
    /// </summary>
    /// <param name="profileName">Path to place where profiles are saved</param>
    /// <returns>bool value which mean name is avaiable or not</returns>
    private bool CreateProfileDirectory(string profileName)
    {
        bool isAvaiable = true;
        if (!Directory.Exists(ProfileStatic.ProfilePath + profileName))
        {
            Directory.CreateDirectory(ProfileStatic.ProfilePath + profileName);
        }
        else
        {
            isAvaiable = false;
        }
        return isAvaiable;
    }
}
