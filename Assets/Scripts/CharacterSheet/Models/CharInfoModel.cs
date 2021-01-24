using System;
[Serializable]
public class CharInfoModel
{
    public string _characterName = string.Empty;
    public string _characterDescription = string.Empty;

    public string CharacterName 
    {
        get => _characterName;    
        set
        {
            _characterName = value;
        }
    }

    public string CharacterDescription
    {
        get => _characterDescription;
        set
        {
            _characterDescription = value;
        }
    }
}
