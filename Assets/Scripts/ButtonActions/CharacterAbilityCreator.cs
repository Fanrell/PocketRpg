using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CharacterAbilityCreator : MonoBehaviour
{
    private InputField abilityLabel;
    private InputField abilityDescription;
    private Toggle abilityLevel;
    private Dropdown abilityDrop;

    private void Start()
    {
        abilityLabel = GameObject.FindGameObjectWithTag("Name").GetComponent<InputField>();
        abilityDescription = GameObject.FindGameObjectWithTag("Description").GetComponent<InputField>();
        abilityLevel = GameObject.FindGameObjectWithTag("input").GetComponent<Toggle>();
        abilityDrop = FindObjectOfType<Dropdown>();
    }

    public void AddAction()
    {

        try
        {
            CharacterStatic.abilityLable.Add(abilityLabel.text);
            CharacterStatic.abilityDescription.Add(abilityDescription.text);
            CharacterStatic.abilityValue.Add(abilityLevel.isOn);
        }
        catch (Exception e)
        {
            return;
        }

        AddDrop.Add(ref abilityDrop, abilityLabel);



    }
    public void EditAction()
    {
        int selcestedIndex = abilityDrop.value;

        try
        {
            CharacterStatic.abilityLable[selcestedIndex] = abilityLabel.text;
            CharacterStatic.abilityDescription[selcestedIndex] = abilityDescription.text;
            CharacterStatic.abilityValue.Add(abilityLevel.isOn);
        }
        catch (Exception e)
        {
            return;
        }

        abilityDrop.options[selcestedIndex].text = abilityLabel.text;

        abilityDrop.captionText.text = abilityLabel.text;

    }

    public void DeleteAction()
    {
        int selected = abilityDrop.value;
        ListDeleter.DeleteFromList(CharacterStatic.abilityLable, selected);
        ListDeleter.DeleteFromList(CharacterStatic.abilityValue, selected);
        ListDeleter.DeleteFromList(CharacterStatic.abilityDescription, selected);
        DeleteDrop.Delete(ref abilityDrop, CharacterStatic.abilityLable, new InputField[] { abilityLabel, abilityDescription }, abilityLevel);

    }

    public void NextScene()
    {
        CreateCharacterSheet.Create();

        SceneManager.LoadScene(2);
    }
}
