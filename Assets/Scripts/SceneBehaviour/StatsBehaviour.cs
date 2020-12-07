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
        Debug.Log(statsFields.Length);
        statsDrop = FindObjectOfType<Dropdown>();
        foreach(var item in CharacterStatic.statsLable)
        {
            statsDrop.options.Add(new Dropdown.OptionData(item));
        }
        slots = GameObject.FindGameObjectWithTag("Slots").GetComponent<InputField>();
        slots.text = 5.ToString();
        
    }

    public void ToggleVisibleFileds()
    {
        int slot = System.Convert.ToInt32(slots.text);
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

    private void CleanFields()
    {
        label.text = "";
                foreach(var item in statsFields)
                {
                    item.GetComponent<InputField>().text = "";
                }
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
