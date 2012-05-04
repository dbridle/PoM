using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace PoMLibrary
{

    public delegate void EntityLevelUpDelgate(Entity entity);

    public class Entity
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
        private List<Bonus> _miscBonuses;

        private EntityAlignment _alignment;

        private EntitySex _sex;
        private short _age;

        private List<EntityStat> _stats;

        private string _portraitFileName;

        private bool _isVendor;

        private string _spriteFilename;

        private Dictionary<int, int> _skills;

        private int _curSP;
        private int _baseSP;

        //used for things like hiding and spells
        private bool _isVisible;

        private Object _target;

        #endregion

        #region Property Functions

        public EntityType Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public string Name
        {
            get { return _name; }
            set
            {
                if (_type == EntityType.Character)
                {
                    if (!string.IsNullOrEmpty(value))
                    {
                        _name = value;
                    }
                }
                else
                    _name = value;
            }
        }

        public string ClassID
        {
            get { return _classID; }
            set { _classID = value; }
        }

        public byte Level
        {
            get { return _level; }
            set
            {
                if (_type > EntityType.Character)
                    _level = value;
            }
        }

        public int Experience
        {
            get { return _experience; }
            set
            {
                if (_type > EntityType.Character)
                    _experience = value;
            }
        }

        public short BaseHP
        {
            get { return _baseHP; }
            set
            {
                if (_type > EntityType.Character)
                    _baseHP = value;
            }
        }

        public short CurHP
        {
            get { return _curHP; }
            set
            {
                if (_type > EntityType.Character)
                    _curHP = value;
            }
        }

        public byte DiseaseResistance
        {
            get { return _diseaseResistance; }
            set { _diseaseResistance = value; }
        }

        public byte PoisonResistance
        {
            get { return _poisonResistance; }
            set { _poisonResistance = value; }
        }

        public byte MagicResistance
        {
            get { return _magicResistance; }
            set { _magicResistance = value; }
        }

        public List<Damager> DamageResistances
        {
            get { return _damageResistances; }
            set { _damageResistances = value; }
        }

        public List<Damager> DamageWeaknesses
        {
            get { return _damageWeaknesses; }
            set { _damageWeaknesses = value; }
        }

        public List<Bonus> DefensiveBonuses
        {
            get { return _defBonuses; }
            set { _defBonuses = value; }
        }

        public List<Bonus> OffensiveBonuses
        {
            get { return _offBonuses; }
            set { _offBonuses = value; }
        }
        public List<Bonus> MiscBonuses
        {
            get { return _miscBonuses; }
            set { _miscBonuses = value; }
        }

        public EntityAlignment Alignment
        {
            get { return _alignment; }
            set { _alignment = value; }
        }

        public EntitySex Sex
        {
            get { return _sex; }
            set { _sex = value; }
        }

        public short Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public string RaceID
        {
            get { return _raceID; }
            set { _raceID = value; }
        }

        public List<EntityStat> Stats
        {
            get { return _stats; }
            set { _stats = value; }
        }

        public string PortaitFilename
        {
            get { return _portraitFileName; }
            set { _portraitFileName = value; }
        }

        public bool IsVendor
        {
            get { return _isVendor; }
            set { _isVendor = value; }
        }

        public string SpriteFilename
        {
            get { return _spriteFilename; }
            set { _spriteFilename = value; }
        }

        public Dictionary<int, int> Skills
        {
            get { return _skills; }
            set { _skills = value; }
        }

        public int CurSP
        {
            get { return _curSP; }
            set { if (value >= 0) _curSP = value; }
        }

        public int BaseSP
        {
            get { return _baseSP; }
            set { if (value >= 0) _baseSP = value; }
        }

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

        public void AddSkill(int id, int ranks)
        {
            if (_skills == null)
                _skills = new Dictionary<int, int>();
            _skills.Add(id, ranks);
        }

        public void SetSkills(Dictionary<int, int> skills)
        {
            _skills = skills;
        }

        public bool HasSkill(int key)
        {
            if (_skills != null)
                return _skills.ContainsKey(key);
            else
                return false;
        }

        public void Damage(int amount, DamageType type)
        {
            //reduce amount based on damagetype protection
            foreach (Damager damager in _damageResistances)
            {
                if (damager.Type == type)
                    amount -= GlobalFunctions.GetRangeAmount(damager.DamageAmount);
            }

            _curHP -= (short)amount;

            if (_curHP <= 0)
            {
                //entity is dead
            }
        }

        public void Buff(int amount, BonusType type)
        {
            switch (type)
            {

            }

        }

        public void UseSkill(int key, Difficulty difficulty)
        {
            int result;
            Entity entity = this;

            if (GlobalData.Skills[key].Use(ref _target, ref entity, difficulty, out result))
            {
                // SkillManager.UseSkill(key, ref _target, ref entity, result);
            }
        }


        public int GetSkillValueByID(int id)
        {
            if (HasSkillByID(id))
                return GlobalFunctions.CalculateSkillBonus(_skills[id]);
            else
                return 0;
        }

        public bool HasSkillByID(int id)
        {
            foreach (int key in _skills.Keys)
                if (key == id)
                    return true;

            return false;
        }

        #region Bonus Functions

        public short GetTotalOffBonus()
        {
            short total = 0;
            Bonus bns;

            if (!(_offBonuses == null))
            {
                for (short i = 0; i < _offBonuses.Capacity; i++)
                {
                    bns = (Bonus)_offBonuses[i];
                    total += bns.Amount;
                }
            }

            return total;
        }

        public short GetTotalMiscBonus()
        {

            short total = 0;
            Bonus bns;

            if (!(_miscBonuses == null))
            {
                for (short i = 0; i < _miscBonuses.Capacity; i++)
                {
                    bns = (Bonus)_miscBonuses[i];
                    total += bns.Amount;
                }
            }

            return total;
        }

        public short GetTotalDefBonus()
        {

            short total = 0;
            Bonus bns;

            if (!(_defBonuses == null))
            {
                for (short i = 0; i < _defBonuses.Capacity; i++)
                {
                    bns = (Bonus)_defBonuses[i];
                    total += bns.Amount;
                }
            }

            return total;
        }

        public void AddDefensiveBonus(Bonus bonus)
        {

            if (_defBonuses == null)
                _defBonuses = new List<Bonus>();

            _defBonuses.Add(bonus);
        }

        public void SetDefensiveBonuses(List<Bonus> bonuses)
        {
            if (bonuses != null)
            {
                _defBonuses = new List<Bonus>();

                foreach (Bonus bonus in bonuses)
                    _defBonuses.Add(bonus);
            }
        }

        public void AddOffensiveBonus(Bonus bonus)
        {

            if (_offBonuses == null)
                _offBonuses = new List<Bonus>();

            _offBonuses.Add(bonus);
        }

        public void SetOffensiveBonuses(List<Bonus> bonuses)
        {
            if (bonuses != null)
            {
                _offBonuses = new List<Bonus>();

                foreach (Bonus bonus in bonuses)
                    _offBonuses.Add(bonus);
            }
        }

        public void AddMiscBonus(Bonus bonus)
        {

            if (_miscBonuses == null)
                _miscBonuses = new List<Bonus>();

            _miscBonuses.Add(bonus);
        }

        public void SetMiscBonuses(List<Bonus> bonuses)
        {
            if (bonuses != null)
            {
                _miscBonuses = new List<Bonus>();

                foreach (Bonus bonus in bonuses)
                    _miscBonuses.Add(bonus);
            }
        }


        public void AddDamageResistance(Damager resistance)
        {

            if (_damageResistances == null)
                _damageResistances = new List<Damager>();

            _damageResistances.Add(resistance);
        }

        public void SetDamageResistances(List<Damager> resistances)
        {
            if (resistances != null)
            {
                _damageResistances = new List<Damager>();

                foreach (Damager resistance in resistances)
                    _damageResistances.Add(resistance);
            }
        }

        public void AddDamageResistances(Damager resistance)
        {

            if (_damageResistances == null)
                _damageResistances = new List<Damager>();

            _damageResistances.Add(resistance);
        }

        public void SetDamageWeaknesses(List<Damager> weaknesses)
        {
            if (weaknesses != null)
            {
                _damageWeaknesses = new List<Damager>();

                foreach (Damager weakness in weaknesses)
                    _damageWeaknesses.Add(weakness);
            }
        }

        #endregion
        
       
            
    }
}
