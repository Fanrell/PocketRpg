public static class AbilityBuilder
{
    public static AbilityModel Build(string abilityLabel, string abilityDescription, bool abilityKnown)
    {
        var buildedAbility = new AbilityModel();
        buildedAbility.AbilityLabel = abilityLabel;
        buildedAbility.AbilityDescription = abilityDescription;
        buildedAbility.AbilityKnown = abilityKnown;
        return buildedAbility;
    }
}
