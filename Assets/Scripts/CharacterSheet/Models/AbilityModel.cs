using System;

[Serializable]
public class AbilityModel
{
    public string _abilityLabel = string.Empty;
    public string _abilityDescription = string.Empty;
    public bool _abilityKnown = false;

    public string AbilityLabel 
    { 
        get => _abilityLabel; 
        set
        {
            _abilityLabel = value;
        }
    }

    public string AbilityDescription
    {
        get => _abilityDescription;
        set
        {
            _abilityDescription = value;
        }
    }

    public bool AbilityKnown
    {
        get => _abilityKnown;
        set
        {
            _abilityKnown = value;
        }
    }

}
