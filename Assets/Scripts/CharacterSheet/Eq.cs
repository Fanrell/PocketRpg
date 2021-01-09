using System.Reflection.Emit;
using System;

[Serializable]
public class Eq
{
    public string label;
    public string discription;

    public string Label
    {
        get => label;
        set
        {
            label = value;
        }
    }

    public string Discription
    {
        get => discription;
        set
        {
            discription = value;
        }
    }

    public bool BuildLabel(string label)
    {

        if (Label == null)
            Label = label;

        return Label == label;
    }

    public bool BuildDiscription(string discription)
    {
        if (Discription == null)
            Discription = discription;
        return Discription == discription;
    }

    public bool BuildEq(string label, string discription)
    {
        bool confirmFlag = true;
        try
        {
            confirmFlag &= BuildLabel(label);
            confirmFlag &= BuildDiscription(discription);
            if (!confirmFlag)
                throw new System.ArgumentException("Parameters are false");
        }
        finally
        {
            confirmFlag = false;
        }
        return confirmFlag;
    }
}