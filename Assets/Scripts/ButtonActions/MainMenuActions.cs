using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

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

}
