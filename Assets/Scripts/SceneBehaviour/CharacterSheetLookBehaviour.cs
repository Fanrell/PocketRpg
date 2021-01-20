using UnityEngine;
using UnityEngine.UI;

public class CharacterSheetLookBehaviour : MonoBehaviour
{
    [SerializeField]
    private Text[] texts;

    // Start is called before the first frame update
    void Start()
    {
        string charText = LoadStaticToCharSheet.LoadName();
        string statText = LoadStaticToCharSheet.LoadStats();
        string ablText = LoadStaticToCharSheet.LoadAbility();
        string skillText = LoadStaticToCharSheet.LoadSkills();
        string eqText = LoadStaticToCharSheet.LoadEq();


        texts[0].text = charText.ToString();
        texts[1].text = eqText.ToString();
        texts[2].text = statText.ToString();
        texts[3].text = ablText.ToString();
        texts[4].text = skillText.ToString();
    }
}
