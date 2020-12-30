using System.Collections;
using System.Collections.Generic;
using System;
using System.Data;
using UnityEngine;

public static class Crypter
{
    public static string Crypting(string toCrypt)
    {
        var crypted = System.Text.Encoding.UTF8.GetBytes(toCrypt);

        return System.Convert.ToBase64String(crypted);
    }
}
