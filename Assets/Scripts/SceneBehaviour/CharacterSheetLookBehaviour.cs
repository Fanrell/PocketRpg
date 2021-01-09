using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterSheetLookBehaviour : MonoBehaviour
{
    public Text[] texts;

    // Start is called before the first frame update
    void Start()
    {
        string charText = CharacterStatic.name + "\n";
        charText += CharacterStatic.charDescription;


        string statText = "";
        for(int i = 0; i< CharacterStatic.statsLable.Count; i++)
        {
            statText += CharacterStatic.statsLable[i] + ": ||";
            foreach (var item in CharacterStatic.statsValue[i])
            {
                statText += item.ToString() + "||";
            }
            statText += "\n";
        }

        string ablText = "";
        for (int i = 0; i < CharacterStatic.abilityLable.Count; i++)
        {
            ablText += CharacterStatic.abilityLable[i] + ": ";
            if (CharacterStatic.abilityValue[i] == true)
                ablText += "Knowned\n";
            else
                ablText += "Unknowned\n";

            ablText += "\t"+CharacterStatic.abilityDescription[i]+"\n";
        }
        string skillText = "";
        for (int i = 0; i < CharacterStatic.skillLable.Count; i++)
        {
            skillText += CharacterStatic.skillLable[i] + ": ";
            skillText += CharacterStatic.skillValue[i] + "\n";
            skillText += "\t"+CharacterStatic.skillDescription[i] + "\n";

        }

        string eqText = "";
        for (int i = 0; i < CharacterStatic.eqLable.Count; i++)
        {
            eqText += CharacterStatic.eqLable[i] + ": ";
            eqText += CharacterStatic.eqDescription[i] + "\n";

        }

        texts[0].text = charText.ToString();
        texts[1].text = eqText.ToString();
        texts[2].text = statText.ToString();
        texts[3].text = ablText.ToString();
        texts[4].text = skillText.ToString();
    }
}
