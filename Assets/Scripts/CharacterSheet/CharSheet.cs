using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

class CharacterSheet
{
    private LinkedList<Link<Statistic>> stats = new LinkedList<Link<Statistic>>();
    private List<Skill> skills = new List<Skill>();
    private List<Ability> abilities = new List<Ability>();

    public LinkedList<List<Statistic>> Stats
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

    public bool isEmpty
    {
        get
        {
            bool isEmpty = true;
            isEmpty &= this.stats.Count == 0;
            isEmpty &= this.skills.Count == 0;
            isEmpty &= this.abilities.Count == 0;
            return ieEmpty;
        }
    }
}