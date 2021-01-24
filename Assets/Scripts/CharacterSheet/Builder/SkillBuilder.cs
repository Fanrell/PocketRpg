/// <summary>
/// <c>SkillBuilder</c> is builder for Skills
/// </summary>
public static class SkillBuilder
{
    /// <summary>
    /// Build statistic from <c>SkillModel</c>
    /// </summary>
    /// <param name="label">name of skill</param>
    /// <param name="description">description of skill</param>
    /// <param name="level">level of skill</param>
    /// <returns>Finished Skill</returns>
    public static SkillModel Build(string label, string description, int level)
    {
        var buildedSkill = new SkillModel();

        buildedSkill.SkillLabel = label;
        buildedSkill.SkillDescription = description;
        buildedSkill.SkillLevel = level;

        return buildedSkill;
    }
}
