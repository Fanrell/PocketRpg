/// <summary>
/// <c>CharInfoBuilder</c> is builder for information about Character
/// </summary>
public static class CharInfoBuilder
{
    /// <summary>
    /// Build character info from <c>CharInfoModel</c>
    /// </summary>
    /// <param name="characterName">Name of character</param>
    /// <param name="characterDescription">Description of character</param>
    /// <returns>Finished CharInfo</returns>
    public static CharInfoModel Build(string characterName, string characterDescription)
    {
        var buildedCharInfo = new CharInfoModel();
        buildedCharInfo.CharacterName = characterName;
        buildedCharInfo.CharacterDescription = characterDescription;
        return buildedCharInfo;
    }
}
