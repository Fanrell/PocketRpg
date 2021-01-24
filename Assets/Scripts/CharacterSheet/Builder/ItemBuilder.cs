/// <summary>
/// <c>ItemBuilder</c> is builder for Invetory.
/// </summary>
public static class ItemBuilder
{
    /// <summary>
    /// Build item from <c>ItemModel</c>
    /// </summary>
    /// <param name="itemName">Name of item</param>
    /// <param name="itemDescription">Description of item</param>
    /// <returns>Finished Item</returns>
    public static ItemModel Build(string itemName, string itemDescription)
    {
        var buildedItem = new ItemModel();
        buildedItem.ItemName = itemName;
        buildedItem.ItemDescription = itemDescription;
        return buildedItem;
    }
}
