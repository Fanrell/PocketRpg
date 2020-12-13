using System.ComponentModel;
using System;
using UnityEngine;
using UnityEngine.UI;

public class StatsBehaviour : MonoBehaviour
{
    private GameObject[] statsFields;
    private InputField slots;
    private Dropdown statsDrop;
    private InputField label;
    void Start()
    {
        statsFields = GameObject.FindGameObjectsWithTag("input");
        label = GameObject.FindGameObjectWithTag("Name").GetComponent<InputField>();
        statsDrop = FindObjectOfType<Dropdown>();
        FillDrop.Fill(ref statsDrop, CharacterStatic.statsLable);
        slots = GameObject.FindGameObjectWithTag("Slots").GetComponent<InputField>();
        slots.text = 5.ToString();
        
    }

    public void ToggleVisibleFileds()
    {
        int slot;
        try
        {
             slot = System.Convert.ToInt32(slots.text);
        }
        catch(Exception e)
        {
            slot = 1;
        }
        int tmpSlot = 1;
        slot = Mathf.Clamp(slot,1,5);
        foreach(var item in statsFields)
        {
            if(tmpSlot > slot)
                item.GetComponent<InputField>().interactable = false;
            else
                item.GetComponent<InputField>().interactable = true;
            tmpSlot++;
        }
        slots.text = slot.ToString();
    }

    public void SelectAnotherStat()
    {
        int indexSelect = statsDrop.value;
        slots.text = CharacterStatic.statsValue[indexSelect].Count.ToString(); 
        label.text = CharacterStatic.statsLable[indexSelect];
        for(int i = 0; i< 5 ; i++)
        {
            if(i < CharacterStatic.statsValue[indexSelect].Count)
                statsFields[i].GetComponent<InputField>().text = CharacterStatic.statsValue[indexSelect][i].ToString();
            else
                statsFields[i].GetComponent<InputField>().text = "";
        }
        ToggleVisibleFileds();
        Debug.Log(indexSelect);
    }

}
