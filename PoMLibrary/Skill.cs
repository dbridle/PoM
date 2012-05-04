using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;

namespace PoMLibrary
{
    public class Skill
    {
        private int _id;
        private string _name;
        private string _description;

        private SkillType _type;

        private int _opposingSkill;

        private bool _alwaysOn;
        private Dictionary<string, string> _costs;
        private Dictionary<string, int> _classBonuses;
        private List<MinMaxBonus> _levelBonuses;
        private Dictionary<string, int> _raceBonuses;
        private Dictionary<string, MinMaxBonus> _statBonuses;

        private string _iconFilename;

        [NonSerialized]
        private Texture2D _icon;

#region Properties

        public int ID
        {
            get {return _id;}
            set {if (value > 0) _id = value;}
        }

        public string Name
        {
            get {return _name;}
            set {if (!string.IsNullOrEmpty(value)) _name = value;}
        }

        public string Description
        {
            get {return _description;}
            set {if (!string.IsNullOrEmpty(value)) _description = value;}
        }

        public SkillType Type
        {
            get {return _type;}
            set {_type = value;}
        }

        public int OpposingSkill
        {
            get {return _opposingSkill;}
            set {_opposingSkill = value;}
        }

        public bool AlwaysOn
        {
            get {return _alwaysOn;}
            set {_alwaysOn = value;}
        }

        public string IconFilename
        {
            get {return _iconFilename;}
            set {_iconFilename = value;}
        }

        public Texture2D Icon
        {
            get {return _icon;}
            set {_icon = value;}
        }

#endregion

        public Skill()
        {

        }

        public Skill(int id)
        {
            _id = id;
            _costs = new Dictionary<string, string>();
            _classBonuses = new Dictionary<string, int>();
            _raceBonuses = new Dictionary<string, int>();
            _levelBonuses = new List<MinMaxBonus>();
            _statBonuses = new Dictionary<string, MinMaxBonus>();
            _alwaysOn = false;
        }

#region Cost Functions

        public bool AddCost(string id, string cost)
        {
            if (_costs == null)
                _costs = new Dictionary<string, string>();

            if (!_costs.ContainsKey(id))
                _costs.Add(id, cost);
            else
                return false;

            return true;
        }

        public void RemoveCost(string id)
        {
            if (_costs != null)
                _costs.Remove(id);
        }

        public string GetCost(string id)
        {
            string cost = "";

            if (_costs != null)
                _costs.TryGetValue(id, out cost);

            return cost;
        }

        public Dictionary<string, string> Costs
        {
            get { return _costs; }
        }

#endregion

#region Race Bonus Functions

        public void AddRaceBonus(string id, int bonus)
        {
            if (_raceBonuses == null)
                _raceBonuses = new Dictionary<string, int>();

            if (!_raceBonuses.ContainsKey(id))
                _raceBonuses.Add(id, bonus);

        }

        public void RemoveRaceBonus(string id)
        {
            if (_raceBonuses != null)
                _raceBonuses.Remove(id);
        }

        public int GetRaceBonus(string id)
        {
            int bonus = 0;

            if (_raceBonuses != null)
                _raceBonuses.TryGetValue(id, out bonus);

            return bonus;
        }

        public Dictionary<string, int> RaceBonuses
        {
            get { return _raceBonuses; }
            set { _raceBonuses = value; }
        }

#endregion

#region Class Bonus Functions

        public bool AddClassBonus(string id, int bonus)
        {
            if (_classBonuses == null)
                _classBonuses = new Dictionary<string, int>();

            if (!_classBonuses.ContainsKey(id))
                _classBonuses.Add(id, bonus);
            else
                return false;

            return true;

        }

        public void RemoveClassBonus(string id)
        {
            if (_classBonuses != null)
                _classBonuses.Remove(id);
        }

        public int GetClassBonus(string id)
        {
            int bonus = 0;

            if (_classBonuses != null)
                _classBonuses.TryGetValue(id, out bonus);

            return bonus;
        }

        public Dictionary<string, int> ClassBonuses
        {
            get { return _classBonuses; }
            set { _classBonuses = value; }
        }

        #endregion

#region Stat Bonus Functions

        public void AddStatBonus(string id, MinMaxBonus bonus)
        {
            if (_statBonuses == null)
                _statBonuses = new Dictionary<string, MinMaxBonus>();

            if (!_statBonuses.ContainsKey(id))
                _statBonuses.Add(id, bonus);

        }

        public void RemoveStatBonus(string id)
        {
            if (_statBonuses != null)
                _statBonuses.Remove(id);
        }

        public MinMaxBonus GetStatBonus(string id)
        {
            MinMaxBonus bonus = new MinMaxBonus();

            if (_statBonuses != null)
                _statBonuses.TryGetValue(id, out bonus);

            return bonus;
        }

        public Dictionary<string, MinMaxBonus> StatBonuses
        {
            get { return _statBonuses; }
            set { _statBonuses = value; }
        }

#endregion
        
#region Level Bonus Functions

        public void AddLevelBonus(MinMaxBonus bonus)
        {
            if (_levelBonuses == null)
                _levelBonuses = new List<MinMaxBonus>();

            _levelBonuses.Add(bonus);

        }

        public void RemoveLevelBonus(int index)
        {
            if (_levelBonuses != null)
                _levelBonuses.RemoveAt(index);
        }

        public int GetLevelBonus(int level)
        {
            if (_levelBonuses != null)
            {
                foreach (MinMaxBonus bonus in _levelBonuses)
                {
                    if (bonus.IsValueInRange(level))
                        return bonus.Amount;
                }
            }

            return 0;
        }

        public List<MinMaxBonus> LevelBonuses
        {
            get { return _levelBonuses; }
            set { _levelBonuses = value; }
        }

#endregion

        
        public bool Use(ref Object target, ref Entity entity, Difficulty difficulty, out int result)
        {
            int roll;
            int bns = 0;

            roll = GlobalFunctions.GetRandomNumber(DieType.d100);

            roll += (short)difficulty;

            if (_opposingSkill > 0)
            {
                if (((Entity)target).HasSkillByID(_opposingSkill))
                    roll -= ((Entity)target).GetSkillValueByID(_opposingSkill);
            }
            else
            {
                switch (_type)
                {
                    case SkillType.Defensive:
                        {
                            if (target is Entity)
                                roll -= ((Entity)target).GetTotalOffBonus();

                            break;
                        }
                    case SkillType.NonCombat:
                        {
                            if (target is Entity)
                                roll -= ((Entity)target).GetTotalMiscBonus();

                            break;
                        }
                    case SkillType.Offensive:
                        {
                            if (target is Entity)
                                roll -= ((Entity)target).GetTotalDefBonus();

                            break;
                        }
                }
            }

            foreach (KeyValuePair<string,int> kvp in _raceBonuses)
            {
                if (entity.RaceID == kvp.Key)
                {
                    bns += entity.Level * kvp.Value;
                    break;
                }
            }

            foreach (KeyValuePair<string, int> kvp in _classBonuses)
            {
                if (entity.ClassID == kvp.Key)
                {
                    bns += entity.Level * kvp.Value;
                    break;
                }
            }

            //Calculate level bonus
            if (_levelBonuses != null)
            {
                foreach (MinMaxBonus bonus in _levelBonuses)
                {
                    if (bonus.IsValueInRange(entity.Level))
                    {
                        bns += bonus.Amount;
                        break;
                    }
                }
            }
            //else
            //{
                //    short level = entity.Level;
                //    //use default
                //    switch (level)
                //    {
                //        case 1:
                //        case 2:
                //        case 3:
                //        case 4:
                //        case 5:
                //        {
                //            bns = (short)(10 * level);
                //            break;
                //        }
                //        case 6:
                //        case 7:
                //        case 8:
                //        case 9:
                //        case 10:
                //        {
                //            bns = (short)(50 + (5 * (level - 5)));
                //            break;
                //        }
                //        case 11:
                //        case 12:
                //        case 13:
                //        case 14:
                //        case 15:
                //        {
                //            bns = (short)(75 + (3 * (level - 10)));
                //            break;
                //        }
                //        case 16:
                //        case 17:
                //        case 18:
                //        case 19:
                //        case 20:
                //        {
                //            bns = (short)(90 + (2 * (level - 15)));
                //            break;
                //        }
                //        default:
                //        {
                //            bns = (short)(100 + (1 * (level - 20)));
                //            break;
                //        }
                //    }

            //}

            roll += bns;

            result = roll;

            return (roll >= 100);

        }

    }
}
