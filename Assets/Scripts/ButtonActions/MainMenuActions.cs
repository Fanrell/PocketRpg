using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuActions : MonoBehaviour
{
    [SerializeField]
    public Canvas addProfileCanvas = new Canvas();

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

    public void GoToProfiles()
    {
        SceneManager.LoadScene(1);
    }

    public void GoToCharacterSheetList()
    {
        SceneManager.LoadScene(2);
    }
}
