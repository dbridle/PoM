using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PoMLibrary
{
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



       
}
