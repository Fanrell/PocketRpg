using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CharacterEqCreator : MonoBehaviour
{
    private InputField eqLabel;
    private InputField eqDescription;
    private Dropdown eqDrop;
    private void Start()
    {
        eqLabel = GameObject.FindGameObjectWithTag("Name").GetComponent<InputField>();
        eqDescription = GameObject.FindGameObjectWithTag("Description").GetComponent<InputField>();
        eqDrop = FindObjectOfType<Dropdown>();
        FillDrop.Fill(ref eqDrop, CharacterStatic.eqLable);
    }

    public void AddAction()
    {

        try
        {
            CharacterStatic.eqLable.Add(eqLabel.text);
            CharacterStatic.eqDescription.Add(eqDescription.text);
        }
        catch (Exception e)
        {
            return;
        }
        Debug.Log(CharacterStatic.eqDescription[CharacterStatic.eqDescription.Count - 1]);
        AddDrop.Add(ref eqDrop, eqLabel);

    }
    public void EditAction()
    {
        int selcestedIndex = eqDrop.value;

        try
        {
            CharacterStatic.eqLable[selcestedIndex] = eqLabel.text;
            CharacterStatic.eqDescription[selcestedIndex] = eqDescription.text;
        }
        catch (Exception e)
        {
            return;
        }

        eqDrop.options[selcestedIndex].text = eqLabel.text;

        eqDrop.captionText.text = eqLabel.text;

    }

    public void DeleteAction()
    {
        int selected = eqDrop.value;
        ListDeleter.DeleteFromList(CharacterStatic.eqLable, selected);
        ListDeleter.DeleteFromList(CharacterStatic.eqDescription, selected);

        DeleteDrop.Delete(ref eqDrop, CharacterStatic.eqLable, new InputField[] { eqLabel, eqDescription });



    }

    public void NextSceene()
    {
        CreateCharacterSheet.Create();

        SceneManager.LoadScene(2);
    }
}
