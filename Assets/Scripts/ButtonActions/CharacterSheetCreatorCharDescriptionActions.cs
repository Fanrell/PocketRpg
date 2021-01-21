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
        SceneManager.LoadScene(4);
    }
}
