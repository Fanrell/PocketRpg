using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StringNameCheck : MonoBehaviour
{
    [SerializeField]
    private InputField nameInput;
    public void OnValueChange()
    {
        if (nameInput.text != "")
        {
            string txt = nameInput.text;
            int pointer = txt.Length - 1;
            if (!char.IsLetter(txt[pointer]))
            {
                txt = txt.Substring(0, pointer);
            }
            nameInput.text = txt;
        }
    }

}
