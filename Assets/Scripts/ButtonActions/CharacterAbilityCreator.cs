using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterAbilityCreator : MonoBehaviour
{
    private InputField abilityLabel;
    private InputField abilityDescription;
    private Toggle abilityLevel;
    private Dropdown abilityDrop;
    public void AddAction()
    {
        abilityLabel = GameObject.FindGameObjectWithTag("Name").GetComponent<InputField>();
        abilityDescription = GameObject.FindGameObjectWithTag("Description").GetComponent<InputField>();
        abilityLevel = GameObject.FindGameObjectWithTag("input").GetComponent<Toggle>();
        abilityDrop = FindObjectOfType<Dropdown>();

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

        abilityDrop.captionText.text = abilityLabel.text;

        abilityDrop.options.Add(new Dropdown.OptionData(abilityLabel.text.ToString()));
        abilityDrop.value = abilityDrop.options.Count - 1;

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
        abilityDrop.ClearOptions();

        FillDrop.Fill(ref abilityDrop, CharacterStatic.abilityLable);
        if (abilityDrop.options.Count > 0)
        {
            GameObject.FindGameObjectWithTag("MainCamera").GetComponent<AbilityBehaviour>().SelectAnotherStat();
        }

    }
}
