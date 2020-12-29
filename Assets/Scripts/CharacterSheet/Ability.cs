using System.Reflection.Emit;
using System;

[Serializable]
public class Ability
{
    public string label;
    public string discription;
    public bool possess;

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