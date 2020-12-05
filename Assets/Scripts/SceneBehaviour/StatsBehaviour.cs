using System;
using UnityEngine;
using UnityEngine.UI;

public class StatsBehaviour : MonoBehaviour
{
    private GameObject[] statsFields;
    private InputField slots;
    private Dropdown statsDrop;
    void Start()
    {
        statsFields = GameObject.FindGameObjectsWithTag("input");
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
}
