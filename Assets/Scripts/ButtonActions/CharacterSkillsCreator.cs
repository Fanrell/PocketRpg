﻿using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CharacterSkillsCreator : MonoBehaviour
{
    private InputField skillLabel;
    private InputField skillDescription;
    private InputField skillLevel;
    private Dropdown skillDrop;
    private void Start()
    {
        skillLabel = GameObject.FindGameObjectWithTag("Name").GetComponent<InputField>();
        skillDescription = GameObject.FindGameObjectWithTag("Description").GetComponent<InputField>();
        skillLevel = GameObject.FindGameObjectWithTag("input").GetComponent<InputField>();
        skillDrop = FindObjectOfType<Dropdown>();
    }

    public void AddAction()
    {

        try
        {
            CharacterStatic.skillLable.Add(skillLabel.text);
            CharacterStatic.skillDescription.Add(skillDescription.text);
            CharacterStatic.skillValue.Add(Convert.ToInt32(skillLevel.text));
        }
        catch(Exception e)
        {
            return;
        }

        AddDrop.Add(ref skillDrop, skillLabel);

    }
    public void EditAction()
    {
        int selcestedIndex = skillDrop.value;

        try
        {
            CharacterStatic.skillLable[selcestedIndex] = skillLabel.text;
            CharacterStatic.skillDescription[selcestedIndex] = skillDescription.text;
            CharacterStatic.skillValue[selcestedIndex] = Convert.ToInt32(skillLevel.text);
        }
        catch(Exception e)
        {
            return;
        }

        skillDrop.options[selcestedIndex].text = skillLabel.text;

        skillDrop.captionText.text = skillLabel.text;

    }

    public void DeleteAction()
    {
        int selected = skillDrop.value;
        ListDeleter.DeleteFromList(CharacterStatic.skillLable, selected);
        ListDeleter.DeleteFromList(CharacterStatic.skillValue, selected);
        ListDeleter.DeleteFromList(CharacterStatic.skillDescription, selected);

        DeleteDrop.Delete(ref skillDrop, CharacterStatic.skillLable, new InputField[] { skillLabel, skillLevel, skillDescription });



    }

    public void NextSceene()
    {
        SceneManager.LoadScene(6);

    }
}
