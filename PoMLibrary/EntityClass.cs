using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PoMLibrary
{
    class EntityClass
    {
        private string _name = "";
        private string _description = "";
        private DieType _hpDice;

        private Dictionary<string, int> _statModifiers;

        public string Name
        {
            get { return _name; }
            set { if(!string.IsNullOrEmpty(value))_name = value; }
        }

        public string Description
        {
            get { return _description; }
            set { if (!string.IsNullOrEmpty(value)) _description = value; }
        }

        public DieType HPDice
        {
            get { return _hpDice; }
            set { _hpDice = value; }
        }

        public Dictionary<string, int> StatModifiers
        {
            get { return _statModifiers; }
            set { _statModifiers = value; }
        }

        public int StatModifiersCount
        {
            get { return (_statModifiers != null) ? _statModifiers.Count : 0; }
        }

        public EntityClass()
        {
        }

        public EntityClass(string name)
        {
            _name = name;
        }

        public int GetStatModifier(string name)
        {
            int value = 0;

            if (_statModifiers != null)
                _statModifiers.TryGetValue(name, out value);

            return value;
        }

        public void AddStatModifier(string name, int value)
        {
            if (_statModifiers == null)
                _statModifiers = new Dictionary<string,int>();
            
            _statModifiers.Add(Name, value);
        }

        public void RemoveStatModifier(string name)
        {
            if (_statModifiers == null)
                return;

            _statModifiers.Remove(name);
        }

        public void ClearStatModifiers()
        {
            if (_statModifiers != null)
                _statModifiers.Clear();
        }

        public Dictionary<string, int> GetStatMods()
        {
            return _statModifiers;
        }

    }
}
