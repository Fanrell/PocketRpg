using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
/// <summary>
/// class is set of action for buttons from CharacterSheetLook scene
/// </summary>
public class CharacterSheetLookActions : MonoBehaviour
{
    /// <summary>
    /// Change scene to CharacterSheetList scene (scene 2)
    /// </summary>
    public void BackToCharacterSheetList()
    {
        SceneManager.LoadScene(2);
    }
    /// <summary>
    /// Load character sheet creator (scene 3)
    /// </summary>
    public void EditCharSheet()
    {
        SceneManager.LoadScene(3);
    }
}
