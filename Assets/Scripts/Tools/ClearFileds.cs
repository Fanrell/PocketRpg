using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public static class ClearFields
{
    public static void Clear(InputField input)
    {
        input.text = "";
    }

    public static void Clear(Toggle input)
    {
        input.isOn = false;
    }
}
