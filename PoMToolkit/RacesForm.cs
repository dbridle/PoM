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
            lstStats.Items.Clear();

            foreach (Stat stat in _stats)
                lstStats.Items.Add(stat.Name);

            lstModifierTypes.Items.Clear();
            lstModifierTypes.Items.AddRange(Enum.GetNames(typeof(ModifierType)));
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
                MessageBox.Show(ex.Message);
            }
        }

        private void SaveControlsData()
        {

            _race.Name = txtRaceName.Text;
            _race.Description = txtRaceDescription.Text;

            // Add stat modifiers and weakness/resistances
            if (lstStatModifiers.Items.Count > 0)
            {
                if (_race.StatModifiersCount > 0)
                    _race.ClearStatModifiers();

                string stat, id;
                int val;

                for (int i = 0; i < lstStatModifiers.Items.Count; i++)
                {
                    stat = lstStatModifiers.Items[i].ToString();
                    val = Convert.ToInt32(stat.Substring(stat.IndexOf(":") + 2));  // + 2 here due to the space between the number and the ":"
                    id = GetStatID(stat.Substring(0, stat.IndexOf(":")));

                    if (id != "")
                        _race.AddStatModifier(id, val);
                    else
                        MessageBox.Show("Error getting stat ID for item " + i.ToString() + " in stat modifier list");
                }
            }

            if (lstWRs.Items.Count > 0)
            {
                if (_race.WRsCount > 0)
                    _race.ClearWRs();

                string item, type, name;
                int val;
                Modifier modifier;

                for (int i = 0; i < lstModifierTypes.Items.Count; i++)
                {
                    item = lstWRs.Items[i].ToString();
                    type = item.Substring(0, item.IndexOf("-")).Trim();
                    name = item.Substring(item.IndexOf("-") + 2, item.IndexOf(":") - item.IndexOf("-") - 2).Trim();

                    val = Convert.ToInt32(item.Substring(item.IndexOf(":") + 2));

                    modifier = new Modifier();
                    modifier.Amount = val;
                    modifier.Type = (ModifierType)Enum.Parse(typeof(ModifierType), name);

                    switch (type)
                    {
                        case "Resistance":
                            {
                                _race.AddResistance(modifier);
                                break;
                            }
                        case "Weakness":
                            {
                                _race.AddWeakness(modifier);
                                break;
                            }
                    }
                }
            }
        }

        private void SetupForNewEntry()
        {
            _race = new Race();

            // Clear controls
            txtRaceName.Text = "";
            txtRaceDescription.Text = "";
            txtModifierAmount.Text = "";
            txtWRAmount.Text = "";

            LoadModifiersAndWRsListBoxes();

            lstStats.Items.Clear();
            lstModifierTypes.Items.Clear();

            btnAddWR.Enabled = false;
            btnRemoveWR.Enabled = false;
            btnAddModifier.Enabled = false;
            btnRemoveModifier.Enabled = false;

            _saved = false;

        }

        private string GetStatID(string statname)
        {
            foreach (Stat stat in _stats)
                if (stat.Name == statname)
                    return stat.Abbreviation;

            return "";
        }

        private void SaveRaces()
        {
            try
            {
                XmlWriterSettings settings = new XmlWriterSettings();
                settings.Indent = true;

                XmlWriter writer;

                foreach (Race race in _races)
                {
                    writer = XmlWriter.Create(Application.StartupPath + @"\Games\" + _gameName + @"\races\" + race.Name + ".xml", settings);
                    IntermediateSerializer.Serialize(writer, race, null);
                    writer.Close();
                }

                _saved = true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        
        public override void save()
        {
            SaveRaces();
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            SaveControlsData();
            _races.Add(_race);
            cbRaces.Items.Add(_race.Name);

            SetupForNewEntry();

            _saved = false;
            mnuSave.Enabled = true;

        }

        private void mnuSave_Click(object sender, EventArgs e)
        {

            if (!_saved)
                SaveRaces();
        }

        private void mnuLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Multiselect = true;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Race race;

                foreach (string file in dlg.FileNames)
                {
                    race = GlobalFunctions.LoadRace(file);

                    if (race != null)
                    {
                        _races.Add(race);
                        cbRaces.Items.Add(race.Name);
                    }
                }

                _saved = false;

            }
        }

        private void RacesForm_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (!_saved)
            {
                DialogResult result = MessageBox.Show("Save changes?", "Save Races", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                    SaveRaces();
                else // if (result == DialogResult.Cancel)
                    e.Cancel = true;
            }
        }

        private void CheckModifierAmount(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtModifierAmount.Text) && lstStats.SelectedIndex > -1)
                btnAddModifier.Enabled = true;
            else
                btnAddModifier.Enabled = false;
        }

        private void CheckWRAmount(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtWRAmount.Text) && lstModifierTypes.SelectedIndex > -1)
                btnAddWR.Enabled = true;
            else
                btnAddWR.Enabled = false;
        }

        private void lstWRs_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (lstWRs.SelectedIndex > -1)
                btnRemoveWR.Enabled = true;
            else
                btnRemoveWR.Enabled = false;
        }

        private void btnAddModifier_Click(object sender, EventArgs e)
        {
            lstStatModifiers.Items.Add(lstStats.Items[lstStats.SelectedIndex] + ": " + txtModifierAmount.Text);
            lstStats.Items.Remove(lstStats.SelectedItem);
            txtModifierAmount.Text = "";
        }

        private void btnRemoveModifier_Click(object sender, EventArgs e)
        {
            string item = lstStatModifiers.Items[lstStatModifiers.SelectedIndex].ToString();
            lstStats.Items.Add(item.Substring(0, item.IndexOf(":")));
            lstStatModifiers.Items.Remove(item);
        }

        private void btnAddWR_Click(object sender, EventArgs e)
        {
            string type = rbResistance.Checked ? "Resistance - " : "Weakness - ";
            lstWRs.Items.Add(type + lstModifierTypes.Items[lstModifierTypes.SelectedIndex] + ": " + txtWRAmount.Text);
            txtWRAmount.Text = "";

            // We don't remove from lstmodifiertypes since it can be used more than once
        }

        private void btnRemoveWR_Click(object sender, EventArgs e)
        {
            lstWRs.Items.RemoveAt(lstWRs.SelectedIndex);
        }

        private void cbRaces_SelectedIndexChanged(object sender, EventArgs e)
        {
            _race = _races[cbRaces.SelectedIndex];

            txtRaceName.Text = _race.Name;
            txtRaceDescription.Text = _race.Description;

            LoadModifiersAndWRsListBoxes();

            int val;

            lstStatModifiers.Items.Clear();

            foreach (Stat stat in _stats)
            {
                val = _race.GetStatModifier(stat.Abbreviation);
                if (val != 0)
                {
                    lstStatModifiers.Items.Add(stat.Name + ": " + val.ToString());

                    // remove from stat box
                    lstStats.Items.RemoveAt(lstStats.Items.IndexOf(stat.Name));
                }
            }

            lstWRs.Items.Clear();

            // iterate through values in the enum
            foreach (ModifierType mod in Enum.GetValues(typeof(ModifierType)))
            {
                val = _race.CheckResistnance(mod);

                if (val > 0)
                    lstWRs.Items.Add("Resistance - " + mod.ToString() + ": " + val);
            }

            foreach (ModifierType mod in Enum.GetValues(typeof(ModifierType)))
            {
                val = _race.CheckWeakness(mod);

                if (val > 0)
                    lstWRs.Items.Add("Weakness - " + mod.ToString() + ": " + val);
            }
            
            btnAdd.Enabled = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnNew.Enabled = true;
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            SetupForNewEntry();

            btnAdd.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnNew.Enabled = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        



    }
}
