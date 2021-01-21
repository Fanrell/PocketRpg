using UnityEngine;
using UnityEngine.UI;

public class AbilityBehaviour : MonoBehaviour
{
    private InputField abilityLabel;
    private InputField abilityDescription;
    private Toggle abilityLevel;
    private Dropdown abilityDrop;
    void Start()
    {
        abilityLabel = GameObject.FindGameObjectWithTag("Name").GetComponent<InputField>();
        abilityDescription = GameObject.FindGameObjectWithTag("Description").GetComponent<InputField>();
        abilityLevel = GameObject.FindGameObjectWithTag("input").GetComponent<Toggle>();
        abilityDrop = FindObjectOfType<Dropdown>();
        FillDrop.Fill(ref abilityDrop, CharacterStatic.abilityLable);

    }
    /// <summary>
    /// Method for show value from selected option from dropdown.
    /// </summary>
    public void SelectAnotherStat()
    {
        int indexSelect = abilityDrop.value;
        abilityLabel.text = CharacterStatic.abilityLable[indexSelect];
        abilityDescription.text = CharacterStatic.abilityDescription[indexSelect];
        abilityLevel.isOn = CharacterStatic.abilityValue[indexSelect];
    }

}
