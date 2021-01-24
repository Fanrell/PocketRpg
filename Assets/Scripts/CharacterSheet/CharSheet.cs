using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
class CharacterSheet
{
    public CharInfoModel characterInfo = new CharInfoModel();
    public List<StatisticModel> stats = new List<StatisticModel>();
    public List<SkillModel> skills = new List<SkillModel>();
    public List<AbilityModel> abilities = new List<AbilityModel>();
    public List<ItemModel> inventory= new List<ItemModel>();

    public List<StatisticModel> Stats
    {
        get => this.stats;
        set
        {
            this.stats = value;
        }
    }

    public List<SkillModel> Skills
    {
        get => skills;
        set
        {
            this.skills = value;
        }
    }

    public List<AbilityModel> Abilities
    {
        get => this.abilities;
        set
        {
            this.abilities = value;
        }
    }
    public List<ItemModel> Inventory
    {
        get => this.inventory;
        set
        {
            this.inventory = value;
        }
    }

    public CharInfoModel CharacterInfo
    {
        get => characterInfo;
        set
        {
            characterInfo = value;
        }
    }

    public void CharToStatic()
    {
        FillList.FillSkill(Skills);
        FillList.FillAblity(Abilities);
        FillList.FillStats(stats);
        FillList.FillEq(inventory);
        CharacterStatic.name = characterInfo.CharacterName;
        CharacterStatic.charDescription = characterInfo.CharacterDescription;
    }

}