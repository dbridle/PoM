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
}

