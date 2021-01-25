using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CharacterSheetCreatorCharDescriptionActions : MonoBehaviour
{
    public void SaveCharInfo()
    {
        InputField[] fileds = FindObjectsOfType<InputField>();
        for (int i = 0; i < fileds.Length; i++)
        {
            switch (fileds[i].tag.ToLower())
            {
                case ("description"):
                    CharacterStatic.charDescription = fileds[i].text;
                    break;
                case ("name"):
                    CharacterStatic.name = fileds[i].text;
                    break;
            }
        }
        if(AvaiableCheck(CharacterStatic.name))
            SceneManager.LoadScene(4);
    }

    private bool AvaiableCheck(string name)
    {
        bool isAviable = !File.Exists(ProfileStatic.ProfileFolderPath + "/" + name + ".dat");
        return isAviable;
    }
}
