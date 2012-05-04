using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PoMLibrary
{


    // To enable flexibility of stats, there are 2 types:
    // - Regular, this could be things like strength, dex etc
    // - Calculated, these are stats based off of other thats that are calculated
    //   for example, a learnspell stat might be made up of mana and intel which becomes calculated
    public enum StatType
    {
        Regular,
        Calculated
    }

    // Instead of using random numbers we will use dice to keep it more traditional
    public enum DieType
    {
        d4 = 4,
        d6 = 6,
        d8 = 8,
        d10 = 10,
        d12 = 12,
        d20 = 20,
        d100 = 100,
        MaxDie = 100
    }

    public enum BonusType
    {
        Disease,
        Magic,
        Posion,
        Potion,
        Other
    }

    public enum EntityType
    {
        Character,
        NPC,
        Creature,
        Monster
    }

    public enum DamageType
    {
        Crushing,
        Piercing,
        Slashing,
        Fire,
        Water,
        Magical,
        Disease,
        Poison
    }

    public enum EntitySex
    {
        Male,
        Female,
        None
    }

    public enum EntityAlignment
    {
        Good,
        Neutral,
        Evil
    }

    public enum ModifierType
    {
        Fire,
        Water,
        Magic,
        Disease,
        Poison
    }

    public enum SkillType
    {
        Defensive,
        NonCombat,
        Offensive
    }

    public enum Difficulty
    {
        Impossible = -50,
        VEryHard = -25,
        Hard = -10,
        Normal = 0,
        Easy = 10,
        VeryEasy = 25
    }


}
