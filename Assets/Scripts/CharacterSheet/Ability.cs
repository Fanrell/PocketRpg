using System.Reflection.Emit;
using System;

class Ability
{
    private string label;
    private string discription;
    private bool possess;

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

    public bool Possess
    {
        get => possess;
        set
        {
            possess = value;
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

    public bool BuildPossess(bool possess)
    {
        if(Possess != possess)
            Possess = possess;
        return Possess == possess;
    }

       public bool BuildAbility(string label, string discription, bool possess, char flag)
    {
        bool confirmFlag = true;
        try
        {   
            confirmFlag &= BuildLabel(label, flag);
            confirmFlag &= BuildDiscription(discription, flag);
            confirmFlag &= BuildPossess(possess);
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