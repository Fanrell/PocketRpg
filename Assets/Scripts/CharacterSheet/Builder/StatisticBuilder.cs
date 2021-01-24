using System.Collections.Generic;

/// <summary>
/// <c>StatisticBuilder</c> is builder for Statistics. Use <c>StatisticModel</c>
/// </summary>
public static class StatisticBuilder
{
    /// <summary>
    /// Build Statistic from <c>StatisticModel</c>
    /// </summary>
    /// <param name="label">Name of Statistic</param>
    /// <param name="statisticFields">Value for statistic</param>
    /// <returns>Finished Statistic</returns>
    public static StatisticModel Build(string label, List<int> statisticFields)
    {
        var buildedStatistic = new StatisticModel();
        buildedStatistic.Label = label;
        buildedStatistic.StatisticFields = statisticFields;
        return buildedStatistic;
    }
}
