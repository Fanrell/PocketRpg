using System.Runtime.InteropServices.ComTypes;
using System;
using System.Collections.Generic;

[Serializable]
public class Statistic
{
    public string label;
    public List<int> stats = new List<int>();

    public string Label 
    { 
        get => label;
        set
        {
            label = value;
        } 
    }

    public List<int> Stats
    {
        get => stats;
    }

    public int Length
    {
        get => stats.Count;
    }

    public Statistic(string label, int[] stats)
    {
        bool flag = true;
        flag &= BuildLabel(label);
        flag &= BuildStat(stats);
    }

    public bool BuildLabel(string label)
    {
        if(Label == null)
            Label = label;
        return Label == label;
    }

    public bool BuildStat(int[] stats)
    {
        foreach(int item in stats)
        {
            this.stats.Add(item);
        }
        return Length == stats.Length;
    }
}