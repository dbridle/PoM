using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace PoMLibrary
{
    class Entity
    {

        #region Members

        private EntityType _type;

        private string _name;
        private string _classID;
        private byte _level;
        private int _experience;

        private string _raceID;

        private short _baseHP;
        private short _curHP;

        private byte _diseaseResistance;
        private byte _poisonResistance;
        private byte _magicResistance;

        // Affects is empty for these
        private List<Damager> _damageResistances;
        private List<Damager> _damageWeaknesses;

        // Any misc, offensive or defensive bonuses
        // (ie, spells cast on character, items, etc
        // May be positive or negative
        private List<Bonus> _defBonuses;
        private List<Bonus> _offBonuses;
        private List<Bonus> _miscBOnuses;

        private EntityAlignment _alignment;

        private EntitySex _sex;
        private short _age;

        private List<EntityStat> _stats;

        private string _portraitFileName;

        private bool _isVendor;

        #endregion


        public Entity()
        {
            _stats = new List<EntityStat>();
        }

        public int MaxWeight()
        {
            int str = 0;

            // Find the strength stat
            foreach (EntityStat stat in _stats)
            {
                if (stat.StatName.ToLower() == "strength")
                {
                    str = stat.CurrentValue;
                    break;
                }
            }

            return str * Stat.poundsPerStatPoint;

        }
            
    }
}
