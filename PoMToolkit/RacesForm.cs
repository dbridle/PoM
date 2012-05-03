using System;
using System.IO;
using System.Xml;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PoMLibrary;
using Microsoft.Xna.Framework.Content.Pipeline.Serialization.Intermediate;

namespace PoMToolkit
{
    public partial class RacesForm : BaseForm
    {

        private List<Race> _races;
        private Race _race;
        private List<Stat> _stats;

        private string _gameName = "";

        public RacesForm(string gameName)
        {
            InitializeComponent();

            _gameName = gameName;
            _races = new List<Race>();

            _saved = true;

            // Load stats and modifier type list boxes
            string[] files;

            try
            {
                files = Directory.GetFiles(Application.StartupPath + @"\Games\" + _gameName + @"\stats");

                _stats = new List<Stat>();

                foreach (string file in files)
                    LoadStat(file);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error loading stats");
            }

            _saved = true;

            LoadModifiersAndWRsListBoxes();

            files = Directory.GetFiles(Application.StartupPath + @"\Games\" + _gameName + @"\races");

            foreach (string file in files)
            {
                Race race = GlobalFunctions.LoadRace(file);
                if (race != null)
                {
                    _races.Add(race);
                    cbRaces.Items.Add(race.Name);
                }
            }

            _race = new Race();
        
        }

        private void LoadModifiersAndWRsListBoxes()
        {
            lstStatModifiers.Items.Clear();

            foreach (Stat stat in _stats)
                lstStatModifiers.Items.Add(stat.Name);

            lstStatModifiers.Items.Clear();
            lstStatModifiers.Items.AddRange(Enum.GetNames(typeof(ModifierType)));
        }
        
        private void LoadStat(string filename)
        {
            try
            {
                XmlReader reader = XmlReader.Create(new FileStream(filename, FileMode.Open));

                Stat stat = IntermediateSerializer.Deserialize<Stat>(reader, null);
                _stats.Add(stat);
            }
            catch (Exception ex)
            {

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           
        }
               


    }
}
