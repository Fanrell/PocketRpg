using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterStatsCreator : MonoBehaviour
{
    private Dropdown statsDrop;
    public void AddAction()
    {
        statsDrop = FindObjectOfType<Dropdown>();
        GameObject[] statsFields = GameObject.FindGameObjectsWithTag("input");
        InputField labelSlot = GameObject.FindGameObjectWithTag("Name").GetComponent<InputField>();
        int slots = System.Convert.ToInt32(
            GameObject.FindGameObjectWithTag("Slots").
            GetComponent<InputField>().text);
        List<int> statsList = new List<int>();
        for(int i = 0; i<slots; i++)
        {
            try
            {
                statsList.Add(
                    System.Convert.ToInt32(statsFields[i].GetComponent<InputField>().text));
            }
            catch(Exception e)
            {
                return;
            }
        }

        CharacterStatic.statsLable.Add(labelSlot.text);
        CharacterStatic.statsValue.Add(statsList);
        statsDrop.options.Add(new Dropdown.OptionData(labelSlot.text));
        statsDrop.value = statsDrop.options.Count - 1;
        statsDrop.captionText.text = labelSlot.text;
        GameObject.FindGameObjectWithTag("EditButton").GetComponent<Button>().interactable = true;

    }
     public void EditAction()
    {
        GameObject[] statsFields = GameObject.FindGameObjectsWithTag("input");
        InputField labelSlot = GameObject.FindGameObjectWithTag("Name").GetComponent<InputField>();
        int slots = System.Convert.ToInt32(
            GameObject.FindGameObjectWithTag("Slots").
            GetComponent<InputField>().text);
        List<int> statsList = new List<int>();
        for(int i = 0; i<slots; i++)
        {
            try
            {
                statsList.Add(
                    System.Convert.ToInt32(statsFields[i].GetComponent<InputField>().text));
            }
            catch (Exception e)
            {
                return;
            }
        }

        CharacterStatic.statsLable[statsDrop.value] = labelSlot.text;
        CharacterStatic.statsValue[statsDrop.value] = statsList;

        statsDrop.options[statsDrop.value] = new Dropdown.OptionData(labelSlot.text);
        statsDrop.captionText.text = labelSlot.text;

    }

    public void DeleteAction()
    {
        Debug.Log(CharacterStatic.statsValue.Count);
        int selected = statsDrop.value;
        ListDeleter.DeleteFromList(CharacterStatic.statsLable, selected);
        ListDeleter.DeleteFromList(CharacterStatic.statsValue, selected);
        Debug.Log(CharacterStatic.statsValue.Count);
        statsDrop.ClearOptions();

        FillDrop.Fill(ref statsDrop, CharacterStatic.statsLable);


    }
}
