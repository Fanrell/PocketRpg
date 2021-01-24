using System;
using System.Collections.Generic;
/// <summary>
/// <c>Statistic</c> is model for futere statistics
/// </summary>
[Serializable]
public class StatisticModel
{
    public string _label = string.Empty;
    public List<int> _statisticFields = new List<int>();

    public string Label
    {
        get => _label;
        set
        {
            _label = value;
        }
    }

    public List<int> StatisticFields
    {
        get => _statisticFields;
        set
        {
            _statisticFields = value;
        }
    }
}
