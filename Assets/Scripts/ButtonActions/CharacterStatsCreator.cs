using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterStatsCreator : MonoBehaviour
{
    public void AddAction()
    {
        Dropdown statsDrop = FindObjectOfType<Dropdown>();
        GameObject[] statsFields = GameObject.FindGameObjectsWithTag("input");
        InputField labelSlot = GameObject.FindGameObjectWithTag("Name").GetComponent<InputField>();
        int slots = System.Convert.ToInt32(
            GameObject.FindGameObjectWithTag("Slots").
            GetComponent<InputField>().text);
        List<int> statsList = new List<int>();
        for(int i = 0; i<slots; i++)
        {
            statsList.Add( 
                System.Convert.ToInt32( statsFields[i].GetComponent<InputField>().text));
        }

        CharacterStatic.statsLable.Add(labelSlot.text);
        CharacterStatic.statsValue.AddLast(statsList);

        statsDrop.options.Add(new Dropdown.OptionData(labelSlot.text));

    }
}
