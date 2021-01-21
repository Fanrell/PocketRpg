using UnityEngine;
using UnityEngine.UI;

public class CharacterSheetCreatorDescription : MonoBehaviour
{
    [SerializeField]
    private InputField _name;
    [SerializeField]
    private InputField _description;

    void Start()
    {
        _name.text = CharacterStatic.name;
        _description.text = CharacterStatic.charDescription;
    }

}
