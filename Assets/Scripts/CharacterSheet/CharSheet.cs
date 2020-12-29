using System;
using System.Collections.Generic;

[Serializable]
class CharacterSheet
{
    public string name = "";
    public string description = "";
    public List<Statistic> stats = new List<Statistic>();
    public List<Skill> skills = new List<Skill>();
    public List<Ability> abilities = new List<Ability>();

    public List<Statistic> Stats
    {
        get => this.stats;
        set
        {
            this.stats = value;
        }
    }

    public List<Skill> Skills
    {
        get => skills;
        set
        {
            this.skills = value;
        }
    }

    public List<Ability> Abilities
    {
        get => this.abilities;
        set
        {
            this.abilities = value;
        }
    }

    public string Name 
    {
         get => this.name; 
         set
         {
             this.name = value;
         } 
    }

    public string Description 
    {
        get => this.description; 
        set
        {
            this.description = value;
        } 
    }

    public bool isEmpty
    {
        get
        {
            bool isEmpty = true;
            isEmpty &= this.stats.Count == 0;
            isEmpty &= this.skills.Count == 0;
            isEmpty &= this.abilities.Count == 0;
            return isEmpty;
        }
    }

}