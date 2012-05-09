using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PoMLibrary
{
    public class Race
    {
        private string _name = "";
        private string _description = "";

        //private Dictionary<string, int> _statModifiers;

        //private List<Modifier> _weaknesses;
        //private List<Modifier> _resistances;

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

        //public Dictionary<string, int> StatModifiers
        //{
        //    get {return _statModifiers; }
        //    set {_statModifiers = value; }
        //}

        //public List<Modifier> Weaknesses
        //{
        //    get {return _weaknesses; }
        //    set {_weaknesses = value; }
        //}

        //public List<Modifier> Resistances
        //{
        //    get {return _resistances; }
        //    set {_resistances = value; }
        //}

        //public int StatModifiersCount
        //{
        //    get {return (_statModifiers != null) ? _statModifiers.Count : 0; }
        //}

        //public int WRsCount
        //{
        //    get { return ((_resistances != null) ? _resistances.Count : 0) + ((_weaknesses != null) ? _weaknesses.Count : 0); }
        //}

        public Race()
        {
        }

        public Race(string name)
        {
            _name = name;
        }

        //#region Stat Modifier Functions

        //public int GetStatModifier(string abbr)
        //{
        //    int value = 0;

        //    if (_statModifiers != null)
        //        _statModifiers.TryGetValue(abbr, out value);

        //    return value;
        //}

        //public void AddStatModifier(string abbr, int value)
        //{
        //    if (_statModifiers == null)
        //        _statModifiers = new Dictionary<string, int>();

        //    _statModifiers.Add(abbr, value);
        //}

        //public void RemoveStatModifier(string abbr)
        //{
        //    if (_statModifiers == null)
        //        return;

        //    _statModifiers.Remove(abbr);
        //}

        //public Dictionary<string, int> GetStatMods()
        //{
        //    return _statModifiers;
        //}

        //#endregion

        //#region Weakness/Resistances functions

        //public void AddWeakness(Modifier weakness)
        //{
        //    if (_weaknesses == null)
        //        _weaknesses = new List<Modifier>();

        //    _weaknesses.Add(weakness);
        //}

        //public void AddResistance(Modifier resistance)
        //{
        //    if (_resistances == null)
        //        _resistances = new List<Modifier>();

        //    _resistances.Add(resistance);
        //}

        //public void RemoveWeakness(int index)
        //{
        //    if (_weaknesses == null)
        //        return;

        //    _weaknesses.RemoveAt(index);
        //}

        //public void RemoveResistance(int index)
        //{
        //    if (_resistances == null)
        //        return;

        //    _resistances.RemoveAt(index);
        //}

        //public int CheckResistnance(ModifierType type)
        //{
        //    int amount = 0;

        //    if (_resistances != null)
        //        foreach (Modifier resistance in _resistances)
        //            if (resistance.Type == type)
        //                amount = resistance.Amount;

        //    return amount;
        //}

        //public int CheckWeakness(ModifierType type)
        //{
        //    int amount = 0;

        //    if (_weaknesses != null)
        //        foreach (Modifier weakness in _weaknesses)
        //            if (weakness.Type == type)
        //                amount = weakness.Amount;

        //    return amount;
        //}

        //public void ClearStatModifiers()
        //{
        //    _statModifiers.Clear();
        //}

        //public void ClearWRs()
        //{
        //    if (_resistances != null)
        //        _resistances.Clear();
        //    if (_weaknesses != null)
        //        _weaknesses.Clear();
        //}

        //#endregion

    }
}
