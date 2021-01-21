using UnityEngine;
using UnityEngine.UI;

public class EqBehaviour : MonoBehaviour
{
    private InputField eqLabel;
    private InputField eqDescription;
    private Dropdown eqDrop;
    // Start is called before the first frame update
    void Start()
    {
        eqLabel = GameObject.FindGameObjectWithTag("Name").GetComponent<InputField>();
        eqDescription = GameObject.FindGameObjectWithTag("Description").GetComponent<InputField>();
        eqDrop = FindObjectOfType<Dropdown>();
        FillDrop.Fill(ref eqDrop, CharacterStatic.eqLable);
    }

    // Update is called once per frame
    public void SelectAnotherStat()
    {
        int indexSelect = eqDrop.value;
        eqLabel.text = CharacterStatic.eqLable[indexSelect];
        eqDescription.text = CharacterStatic.eqDescription[indexSelect];
    }
}
