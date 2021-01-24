using System;
[Serializable]
public class ItemModel
{
    public string _itemName = string.Empty;
    public string _itemDescription = string.Empty;

    public string ItemName
    {
        get => _itemName;
        set
        {
            _itemName = value;
        }
    }

    public string ItemDescription 
    {
        get => _itemDescription;
        set
        {
            _itemDescription = value;
        }
    }
}
