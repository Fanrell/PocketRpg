using System;
using System.Diagnostics;

class Skill
{
    private string label;
    private string discription = null;
    private int? level = null;

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

    public int? level
    {
        get => level;
        set
        {
            level = value;
        }
    }

    public bool BuildLabel(string label, char flag)
    {
        switch(flag)
        {
            case 'n':
                if(Label == null)
                    Label = label;
                break;
            case 'e':
                Label = label;
                break;
        }
        return Label == label;
    }

    public bool BuildDiscription(string discription, char flag)
    {
        switch(flag)
        {
            case 'n':
                if(Discription == null)
                    Discription = discription;
                break;
            case 'e':
                Discription = discription;
                break;
        }
        return Discription == discription;
    }

    public bool BuildLevel(int? level)
    {
        Level = level;
        return Level = level;
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