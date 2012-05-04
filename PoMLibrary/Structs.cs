using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PoMLibrary
{

    public struct BaseBonus
    {
        public short Amount;
    }

    // This struct is for calculating bonuses, for example, when drinking a potion that gives
    // a timed stat bonus
    public struct Bonus
    {
        public BonusType Type;
        public short Amount;
        public int TimeStarted;
        public int Duration;
        public float ElapsedTime;
    }

    public struct MinMaxBonus
    {
        public int Min;
        public int Max;
        public int Amount;

        public MinMaxBonus(int min, int max, int amount)
        {
            Min = min;
            Max = max;
            Amount = amount;
        }

        public bool IsValueInRange(int value)
        {
            return (value >= Min && value <= Max);
        }
    }

    public struct Damager
    {
        public DamageType Type;

        // Format = *n,n*
        public string DamageAmount;

        // The type of entity of the damage affects, empty for all types
        public string Affects;
    }

    public struct Modifier
    {
        public ModifierType Type;
        public int Amount;
    }

    public struct EntityLevel
    {
        public int MinExperience;
        public int MaxExperience;

        public EntityLevel(int min, int max)
        {
            MinExperience = min;
            MaxExperience = max;
        }
    }


       
}
