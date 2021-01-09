using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Decrypter
{
    // Start is called before the first frame update
    public static string Decrypting(string toDecrypt)
    {
        var decrypted = System.Convert.FromBase64String(toDecrypt);
        return System.Text.Encoding.UTF8.GetString(decrypted);
    }
}
