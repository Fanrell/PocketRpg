using System.Runtime.InteropServices.ComTypes;
using System;
using System.Collections.Generic;

class Statistic
{
    private string label;
    private List<int> stats = new List<int>();

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

    public Statistic(string label, int[] stats, ref bool flag)
    {
        flag &= BuildLabel;
        flag;
    }

    public bool BuildLabel(string label, char flag)
    {
        switch(flag)
        {
            case 'n':
                if(Label == null)
                    Label = label;
                break;
            case 'e':
                Label = label;
                break;
        }
        return Label == label;
    }

    public bool BuildStat(int[] stats)
    {
        foreach(int item in stats)
        {
            this.stats.Add(x);
        }
        return Length == stats.Length;
    }
}