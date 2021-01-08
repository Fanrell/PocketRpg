using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SheetSelectionBehaviour : MonoBehaviour
{
    public Dropdown sheetDrop;
    void Start()
    {
        FillDrop.Fill(ref sheetDrop, ProfileStatic.ProfileFolderPath);
        ClearStatic.Clear();
    }

}
