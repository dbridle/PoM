using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PoMLibrary
{
    public class RPGGame
    {

        private string _gameName;
        private string _description;

        public string GameName
        {
            get { return _gameName; }
            set { if (!string.IsNullOrEmpty(value)) _gameName = value; }
        }

        public string Description
        {
            get { return _description; }
            set { if (!string.IsNullOrEmpty(value)) _description = value; }
        }

        public RPGGame()
        {
        }

        public RPGGame(string name, string description)
        {
            _gameName = name;
            _description = description;
        }
        
    }
}
