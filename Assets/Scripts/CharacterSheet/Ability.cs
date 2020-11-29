using System.Reflection.Emit;
using System;

class Ability
{
    private string label;
    private string description;
    private bool possess;

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

       public bool BuildAbility(string label, string discription, bool possess)
    {
        bool confirmFlag = true;
        try
        {   
            confirmFlag &= BuildLabel(label);
            confirmFlag &= BuildDiscription(discription);
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