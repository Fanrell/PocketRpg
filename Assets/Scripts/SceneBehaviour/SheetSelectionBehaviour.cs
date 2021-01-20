using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SheetSelectionBehaviour : MonoBehaviour
{
    public Dropdown sheetDrop;
    void Start()
    {
        if(ProfileStatic.ProfileFolderPath == null)
            SceneManager.LoadScene(0);
        else
            FillDrop.Fill(ref sheetDrop, ProfileStatic.ProfileFolderPath);
        ClearStatic.Clear();
    }

}
