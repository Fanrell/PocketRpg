using System.ComponentModel;
using System;
using UnityEngine;
using UnityEngine.UI;

public class SkillBehaviour : MonoBehaviour
{
    private InputField skillLabel;
    private InputField skillDescription;
    private InputField skillLevel;
    private Dropdown skillDrop;
    void Start()
    {
        skillLabel = GameObject.FindGameObjectWithTag("Name").GetComponent<InputField>();
        skillDescription = GameObject.FindGameObjectWithTag("Description").GetComponent<InputField>();
        skillLevel = GameObject.FindGameObjectWithTag("input").GetComponent<InputField>();
        skillDrop = FindObjectOfType<Dropdown>();
        FillDrop.Fill(ref skillDrop, CharacterStatic.skillLable);

    }

    public void SelectAnotherStat()
    {
        int indexSelect = skillDrop.value;
        skillLabel.text = CharacterStatic.skillLable[indexSelect];
        skillDescription.text = CharacterStatic.skillDescription[indexSelect];
        skillLevel.text = CharacterStatic.skillValue[indexSelect].ToString();
    }

}
