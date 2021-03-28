using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections.Generic;
using System;
using UnityEngine.SceneManagement;
using System.IO;

public class CharacterSheetLookBehaviour : MonoBehaviour
{
    [Header("Elements")]
    [SerializeField] GameObject infoPanel;
    [SerializeField] GameObject dynamicPanel;
    [SerializeField] GameObject dynamicContent;
    [SerializeField] GameObject infoFiled;
    [SerializeField] GameObject namePlace;
    [SerializeField] GameObject valuePlace;
    [SerializeField] GameObject boolPlace;
    [SerializeField] GameObject descriptionPlace;

    private List<GameObject> childsObjects = new List<GameObject>();

    public void Start()
    {
        ShowCharInfo();
    }

    public void ShowCharInfo()
    {
        infoPanel.SetActive(true);
        dynamicPanel.SetActive(false);
        var panels = infoPanel.GetComponentsInChildren<TMP_InputField>();
        foreach(var item in panels)
        {
            switch(item.tag)
            {
                case ("Name"):
                    item.text = CharacterStatic.name;
                    break;
                case ("Description"):
                    item.text = CharacterStatic.charDescription;
                    break;
            }
        }
    }

    public void ShowDynamic(string name)
    {
        ClearDynamicChild();
        infoPanel.SetActive(false);
        dynamicPanel.SetActive(true);
        GenerateData(name);

    }

    private void ClearDynamicChild()
    {
        foreach (var item in childsObjects)
            Destroy(item);
    }

    private void GenerateData(string dataType)
    {
        switch(dataType)
        {
            case ("statistic"):
                StatisticGenerate();
                break;
            case ("skill"):
                SkillGenerate();
                break;
            case ("ability"):
                AbilityGenerate();
                break;
            case ("eq"):
                EqGenerate();
                break;
        }
    }

    private void EqGenerate()
    {
        for (int i = 0; i < CharacterStatic.eqLable.Count; i++)
        {
            var newInfoPlace = Instantiate(infoFiled, dynamicContent.transform);
            childsObjects.Add(newInfoPlace);
            var newNamePlace = Instantiate(namePlace, newInfoPlace.transform);
            newNamePlace.GetComponent<TMP_Text>().text = CharacterStatic.eqLable[i];
            var newDescriptionPlace = Instantiate(descriptionPlace, newInfoPlace.transform);
            newDescriptionPlace.GetComponent<TMP_InputField>().text = CharacterStatic.eqDescription[i];
        }
    }

    private void AbilityGenerate()
    {
        for (int i = 0; i < CharacterStatic.abilityLable.Count; i++)
        {
            var newInfoPlace = Instantiate(infoFiled, dynamicContent.transform);
            childsObjects.Add(newInfoPlace);
            var newNamePlace = Instantiate(namePlace, newInfoPlace.transform);
            newNamePlace.GetComponent<TMP_Text>().text = CharacterStatic.abilityLable[i];
            var newValuePlace = Instantiate(boolPlace, newInfoPlace.transform);
            newValuePlace.GetComponent<Toggle>().isOn = CharacterStatic.abilityValue[i];
            var newDescriptionPlace = Instantiate(descriptionPlace, newInfoPlace.transform);
            newDescriptionPlace.GetComponent<TMP_InputField>().text = CharacterStatic.abilityDescription[i];
        }
    }

    private void SkillGenerate()
    {
        for (int i = 0; i < CharacterStatic.skillLable.Count; i++)
        {
            var newInfoPlace = Instantiate(infoFiled, dynamicContent.transform);
            childsObjects.Add(newInfoPlace);
            var newNamePlace = Instantiate(namePlace, newInfoPlace.transform);
            newNamePlace.GetComponent<TMP_Text>().text = CharacterStatic.skillLable[i];
            var newValuePlace = Instantiate(valuePlace, newInfoPlace.transform);
            newValuePlace.GetComponent<TMP_InputField>().text = CharacterStatic.skillValue[i].ToString();
            var newDescriptionPlace = Instantiate(descriptionPlace, newInfoPlace.transform);
            newDescriptionPlace.GetComponent<TMP_InputField>().text = CharacterStatic.skillDescription[i];
        }

    }

    private void StatisticGenerate()
    {
        for (int i = 0; i < CharacterStatic.statsLable.Count; i++)
        {
            var newInfoPlace = Instantiate(infoFiled, dynamicContent.transform);
            childsObjects.Add(newInfoPlace);
            var newNamePlace = Instantiate(namePlace, newInfoPlace.transform);
            newNamePlace.GetComponent<TMP_Text>().text = CharacterStatic.statsLable[i];

            foreach (var statVale in CharacterStatic.statsValue[i])
            {
                var newValePlace = Instantiate(valuePlace, newInfoPlace.transform);
                newValePlace.GetComponent<TMP_InputField>().text = statVale.ToString();
            }
        }
    }
}
