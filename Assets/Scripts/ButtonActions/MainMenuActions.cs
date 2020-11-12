using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuActions : MonoBehaviour
{
    public void Close()
    {
        Application.Quit();
    }

    public void Back()
    {
        SceneManager.LoadScene(0);
    }

    public void GoToProfiles()
    {
        SceneManager.LoadScene(1);
    }

    public void GoToCharacterSheetList()
    {
        SceneManager.LoadScene(2);
    }
}
