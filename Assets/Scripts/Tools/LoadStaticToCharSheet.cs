/// <summary>
/// Tool to transport from fields of <c>CharacterStatic</c> to strings
/// </summary>
public static class LoadStaticToCharSheet
{
    /// <summary>
    /// Take fields of Name and Description of character and formats this to show
    /// </summary>
    /// <returns>formated string with name and description of character</returns>
    public static string LoadName()
    {
        var nameText = string.Empty;

        nameText += "Name: " + CharacterStatic.name + "\n\n";
        nameText += "Description: " + CharacterStatic.charDescription;
        return nameText;
    }
    /// <summary>
    /// Take fields about Stats and format this to show
    /// </summary>
    /// <returns>formated string with all info about skills</returns>
    public static string LoadStats()
    {
        var statsText = string.Empty;

        for (int i = 0; i < CharacterStatic.statsLable.Count; i++)
        {
            statsText += CharacterStatic.statsLable[i] + ": ||";
            foreach (var item in CharacterStatic.statsValue[i])
            {
                statsText += item.ToString() + "||";
            }
            statsText += "\n\n";
        }
        return statsText;
    }
    /// <summary>
    /// Take fields about Abilities and format this to show
    /// </summary>
    /// <returns>formated string with info about abilites</returns>
    public static string LoadAbility()
    {
        var ablilityText = string.Empty;
        for (int i = 0; i < CharacterStatic.abilityLable.Count; i++)
        {
            ablilityText += CharacterStatic.abilityLable[i] + ": ";
            if (CharacterStatic.abilityValue[i] == true)
                ablilityText += "Knowned\n";
            else
                ablilityText += "Unknowned\n";

            ablilityText += "\t" + CharacterStatic.abilityDescription[i] + "\n\n";
        }

        return ablilityText;
    }
    /// <summary>
    /// Take fields about Skills and format this to show
    /// </summary>
    /// <returns>formated string with info about skills</returns>
    public static string LoadSkills()
    {
        var skillsText = string.Empty;
        for (int i = 0; i < CharacterStatic.skillLable.Count; i++)
        {
            skillsText += CharacterStatic.skillLable[i] + ": ";
            skillsText += CharacterStatic.skillValue[i] + "\n";
            skillsText += "\t" + CharacterStatic.skillDescription[i] + "\n\n";
        }
        return skillsText;
    }
    /// <summary>
    /// Take fields about inventory and format this to show
    /// </summary>
    /// <returns>formated string with info about inventory</returns>
    public static string LoadEq()
    {
        var eqText = string.Empty;
        for (int i = 0; i < CharacterStatic.eqLable.Count; i++)
        {
            eqText += CharacterStatic.eqLable[i] + ": ";
            eqText += CharacterStatic.eqDescription[i] + "\n\n";

        }
        return eqText;
    }
}
