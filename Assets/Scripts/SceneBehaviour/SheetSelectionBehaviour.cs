using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SheetSelectionBehaviour : MonoBehaviour
{
    public Dropdown sheetDrop;
    // Start is called before the first frame update
    void Start()
    {
        FillDrop.Fill(ref sheetDrop, ProfileStatic.ProfileFolderPath);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
