using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PoMLibrary
{
    public class Stat
    {

        private StatType _type;
        private string _name;
        private string _abbreviation;
        private string _description;
        private string _statCalculation;

        private static readonly char[] _operators = { '+', '-', '*', '/' };

        public const short MaxStatValue = (short)DieType.d100;
        public const int poundsPerStatPoint = 3;


        // Constructor
        public Stat()
        {
        }

        public Stat(string name)
        {
            _name = name;
        }

        public StatType Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Abbreviation
        {
            get { return _abbreviation; }
            set { _abbreviation = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public string StatCalculation
        {
            get { return _statCalculation; }

            set
            {
                if (_type == StatType.Calculated)
                    if (!string.IsNullOrEmpty(value))
                        _statCalculation = value;
                    else
                        _statCalculation = value;

            }
        }



    }

    public class EntityStat
    {
       
        private string _stat;
        private short _value;
        private List<Bonus> _bonuses;

        public EntityStat()
        {
        }

        public EntityStat(string stat, short value)
        {
            _stat = stat;
            _value = value;
        }

        public string StatName
        {
            get {return _stat;}
            set {if(!string.IsNullOrEmpty(value))_stat = value;}
        }

        public short CurrentValue
        {
            get 
            {
                short val = _value;

                if (_bonuses != null)
                    foreach(Bonus bonus in _bonuses)
                        val += bonus.Amount;

                return val;
            }

            set {}
        }

        public short BaseValue
        {
            get {return _value;}
            set {_value = value;}
        }

        public List<Bonus> Bonuses
        {
            get {return _bonuses;}
            set {_bonuses = value;}
        }

        public void IncreaseValue(short val)
        {
            _value += val;
            if(_value > Stat.MaxStatValue)
                _value = Stat.MaxStatValue;
        }

        public void ReduceValue(short val)
        {
            _value -= val;
            if(_value < 1)
                _value = 1;
        }

        public void AddBonus(Bonus bonus)
        {
            if(_bonuses == null)
                _bonuses = new List<Bonus>();

            _bonuses.Add(bonus);
        }

        public void update(float time)
        {
            if(_bonuses == null)
                return;

            Bonus bonus;

            for(int i = _bonuses.Count - 1; i >= 0; i--)
            {
                bonus = _bonuses[i];
                bonus.ElapsedTime += time;

                if((int)bonus.ElapsedTime >= bonus.Duration)
                    _bonuses.Remove(bonus);
                else
                    _bonuses[i] = bonus;
            }
        }
    }
}



