using System;
using System.Diagnostics;

[Serializable]
public class Skill
{
    public string label;
    public string discription = null;
    public int? level = null;

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

    public int? Level
    {
        get => level;
        set
        {
            level = value;
        }
    }

    public bool BuildLabel(string label)
    {

        if(Label == null)
            Label = label;
        return Label == label;
    }

    public bool BuildDiscription(string discription)
    {

        if(Discription == null)
            Discription = discription;

        return Discription == discription;
    }

    public bool BuildLevel(int? level)
    {
        Level = level;
        return Level == level;
    }

    public bool BuildSkill(string label, string discription, int? level)
    {
        bool confirmFlag = true;
        try
        {   
            confirmFlag &= BuildLabel(label);
            confirmFlag &= BuildDiscription(discription);
            confirmFlag &= BuildLevel(level);
            if(!confirmFlag)
            throw new System.ArgumentException("Parameters are false");
        }
        finally
        {
            confirmFlag = false;
        }
        return confirmFlag;
    }
}