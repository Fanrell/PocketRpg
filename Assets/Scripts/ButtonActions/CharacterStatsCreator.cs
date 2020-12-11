using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CharacterStatsCreator : MonoBehaviour
{
    private Dropdown statsDrop;
    private GameObject[] statsFields;
    private InputField labelSlot;

    private void Start()
    {
        statsDrop = FindObjectOfType<Dropdown>();
        statsFields = GameObject.FindGameObjectsWithTag("input");
        labelSlot  = GameObject.FindGameObjectWithTag("Name").GetComponent<InputField>();
    }

    public void AddAction()
    {

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
        AddDrop.Add(ref statsDrop, labelSlot);
        statsDrop.captionText.text = labelSlot.text;

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
            int selected = statsDrop.value;
            ListDeleter.DeleteFromList(CharacterStatic.statsLable, selected);
            ListDeleter.DeleteFromList(CharacterStatic.statsValue, selected);
            DeleteDrop.Delete(ref statsDrop, CharacterStatic.statsLable, statsFields);
    }

    public void NextScene()
    {
        SceneManager.LoadScene(5);
    }
}
