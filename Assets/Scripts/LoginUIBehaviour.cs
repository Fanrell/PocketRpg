using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class LoginUIBehaviour : MonoBehaviour
{
    [SerializeField]
    Button loginButton;

    public void OnValueChange(string text)
    {
        loginButton.interactable = !string.IsNullOrEmpty(text); 
    }
}
