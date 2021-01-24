using System;
[Serializable]
public class SkillModel
{
    public string _skillLabel = string.Empty;
    public string _skillDescription = string.Empty;
    public int _skillLevel = new int();

    public string SkillLabel
    {
        get => _skillLabel;
        set
        {
            _skillLabel = value;
        }
    }

    public string SkillDescription 
    { 
        get => _skillDescription; 
        set
        {
            _skillDescription = value;
        }
    }

    public int SkillLevel 
    { 
        get => _skillLevel; 
        set
        {
            _skillLevel = value;
        }
    }
}
