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
using Microsoft.Xna.Framework.Content.Pipeline.Serialization.Intermediate;
using PoMLibrary;

namespace PoMToolkit
{
    public partial class SkillsForm : BaseForm
    {
        private List<Skill> _skills;
        private string _gameName = "";

        private List<EntityClass> _classes;
        private List<Race> _races;
        private List<Stat> _stats;

        private Dictionary<string, string> _costs;
        private Dictionary<string, int> _classBonuses;
        private List<MinMaxBonus> _levelBonuses;
        private Dictionary<string, int> _raceBonuses;
        private Dictionary<string, MinMaxBonus> _statBonuses;

        private List<KeyValuePair<string, int>> _opposingSkillControlSource;

        private Skill _skill;

        private int _curID;

        public SkillsForm(string gameName)
        {
            InitializeComponent();

            _curID = 1;

            _gameName = gameName;

            string[] files = Directory.GetFiles(Application.StartupPath + @"\Games\" + _gameName + @"\skills");

            _skills = new List<Skill>();

            foreach (string file in files)
            {
                Skill skill = GlobalFunctions.LoadSkill(file);

                if (skill != null)
                {
                    _skills.Add(skill);

                    cboSkills.Items.Add(skill.Name);

                    if (skill.ID > _curID)
                        _curID = skill.ID;
                }
            }

            //increment greatest skill id for next skill
            _curID++;

            files = Directory.GetFiles(Application.StartupPath + @"\Games\" + _gameName + @"\classes");

            _classes = new List<EntityClass>();

            foreach (string file in files)
            {

                EntityClass entityClass = GlobalFunctions.LoadClass(file);

                if (entityClass != null)
                {
                    _classes.Add(entityClass);

                    lstCostClasses.Items.Add(entityClass.Name);
                    lstClassBonus.Items.Add(entityClass.Name);
                }
            }

            _stats = new List<Stat>();

            files = Directory.GetFiles(Application.StartupPath + @"\Games\" + _gameName + @"\stats");

            foreach (string file in files)
            {
                Stat stat = GlobalFunctions.LoadStat(file);

                if (stat != null)
                {
                    _stats.Add(stat);
                    lstStatBonus.Items.Add(stat.Name);
                }
            }

            files = Directory.GetFiles(Application.StartupPath + @"\Games\" + _gameName + @"\races");

            _races = new List<Race>();

            foreach (string file in files)
            {
                Race race = GlobalFunctions.LoadRace(file);

                if (race != null)
                {
                    _races.Add(race);

                    lstRaceBonus.Items.Add(race.Name);
                }
            }

            _skill = new Skill(_curID);

            _costs = new Dictionary<string, string>();
            _classBonuses = new Dictionary<string, int>();
            _levelBonuses = new List<MinMaxBonus>();
            _raceBonuses = new Dictionary<string, int>();
            _statBonuses = new Dictionary<string, MinMaxBonus>();

            _opposingSkillControlSource = new List<KeyValuePair<string, int>>();

            _saved = true;
        }

        private void FillOpposingSkillCombo()
        {
            FillOpposingSkillCombo(0);
        }

        private void FillOpposingSkillCombo(int id)
        {
            _opposingSkillControlSource = new List<KeyValuePair<string, int>>();

            _opposingSkillControlSource.Add(new KeyValuePair<string, int>("", 0));

            foreach (Skill skill in _skills)
            {
                if (skill.ID != id)
                    _opposingSkillControlSource.Add(new KeyValuePair<string, int>(skill.Name, skill.ID));
            }

            cboOpposingSkill.DisplayMember = "Key";
            cboOpposingSkill.ValueMember = "Value";

            cboOpposingSkill.DataSource = _opposingSkillControlSource;
        }


#region Validation

        private void CheckSkillCostSelection(object sender, EventArgs e)
        {
            btnAddCost.Enabled = (lstCostClasses.SelectedIndex > -1 && !string.IsNullOrEmpty(txtCost.Text));
        }

        private void CheckClassBonusData(object sender, EventArgs e)
        {
            btnAddClassBonus.Enabled = (lstClassBonus.SelectedIndex > -1 && !string.IsNullOrEmpty(txtClassBonus.Text));
        }

        private void CheckRaceBonusData(object sender, EventArgs e)
        {
            btnAddRaceBonus.Enabled = (lstRaceBonus.SelectedIndex > -1 && !string.IsNullOrEmpty(txtRaceBonus.Text));
        }

        private void CheckStatBonusData(object sender, EventArgs e)
        {
            btnAddStatBonus.Enabled = (lstStatBonus.SelectedIndex > -1 && !string.IsNullOrEmpty(txtStatMinVal.Text) && !string.IsNullOrEmpty(txtStatMaxVal.Text) && !string.IsNullOrEmpty(txtStatBonus.Text));
        }

        private void CheckLevelBonusData(object sender, EventArgs e)
        {
            btnAddLevelBonus.Enabled = (!string.IsNullOrEmpty(txtMinLevel.Text) && !string.IsNullOrEmpty(txtMaxLevel.Text) && !string.IsNullOrEmpty(txtLevelBonus.Text));
        }

#endregion

        private void mnuLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Multiselect = true;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                foreach (string file in dlg.FileNames)
                {
                    Skill skill = GlobalFunctions.LoadSkill(file);

                    if (skill != null)
                    {
                        _skills.Add(skill);

                        cboSkills.Items.Add(skill.Name);
                    }
                }
                _saved = false;
            }
        }

        private void SkillsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_saved)
            {
                DialogResult result = MessageBox.Show("Do you wish to save?", "Save Skills", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                    SaveSkills();
                else if (result == DialogResult.Cancel)
                    e.Cancel = true;
            }
        }

        private void mnuSave_Click(object sender, EventArgs e)
        {
            if (!_saved)
                SaveSkills();
        }

        public override void save()
        {
            SaveSkills();
        }

        private void SaveSkills()
        {
            try
            {
                XmlWriter writer;

                XmlWriterSettings settings = new XmlWriterSettings();

                settings.Indent = true;
                settings.CloseOutput = true;

                foreach (Skill skill in _skills)
                {
                    writer = XmlWriter.Create(Application.StartupPath + @"\Games\" + _gameName + @"\skills\" + skill.Name + ".xml", settings);

                    IntermediateSerializer.Serialize(writer, skill, null);

                    writer.Close();
                }

                _saved = true;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void FillSkillObject()
        {
            _skill.Name = txtName.Text;
            _skill.Type = (SkillType)cboType.SelectedIndex;
            _skill.Description = txtDescription.Text;
            // _skill.OpposingSkill = (int)cboOpposingSkill.SelectedValue;
            _skill.AlwaysOn = chkAlwaysOn.Checked;
            _skill.IconFilename = txtIcon.Text;

            //add costs
            foreach (string key in _costs.Keys)
                _skill.AddCost(key, _costs[key]);

            //add class bonuses
            foreach (string key in _classBonuses.Keys)
                _skill.AddClassBonus(key, _classBonuses[key]);

            //add level bonuses
            foreach (MinMaxBonus bns in _levelBonuses)
                _skill.AddLevelBonus(bns);

            //add race bonuses
            foreach (string key in _raceBonuses.Keys)
                _skill.AddRaceBonus(key, _raceBonuses[key]);

            //add stat bonuses
            foreach (string key in _statBonuses.Keys)
                _skill.AddStatBonus(key, _statBonuses[key]);

        }
                
        private void btnAddCost_Click(object sender, EventArgs e)
        {
            _costs.Add(lstCostClasses.SelectedItem.ToString(), txtCost.Text);
            lstSkillCosts.Items.Add(lstCostClasses.SelectedItem.ToString() + ":  " + txtCost.Text);
            lstCostClasses.Items.RemoveAt(lstCostClasses.SelectedIndex);
            txtCost.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            FillSkillObject();

            if (_skills == null)
                _skills = new List<Skill>();

            _skills.Add(_skill);

            cboSkills.Items.Add(_skill.Name);

            _curID++;

            _skill = new Skill(_curID);

            SetupFormForEntry();

            _saved = false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            SetupFormForEntry();

            btnNew.Enabled = false;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            btnAdd.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FillSkillObject();

            _skills[cboSkills.SelectedIndex] = _skill;

            SetupFormForEntry();

            _saved = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _skills.RemoveAt(cboSkills.SelectedIndex);
            cboSkills.Items.RemoveAt(cboSkills.SelectedIndex);

            SetupFormForEntry();
        }

        private void SetupListBoxes()
        {
            lstClassBonus.Items.Clear();
            lstCostClasses.Items.Clear();
            lstStatBonus.Items.Clear();
            lstRaceBonus.Items.Clear();
            lstRaceBonuses.Items.Clear();
            lstStatBonuses.Items.Clear();
            lstClassBonuses.Items.Clear();
            lstSkillCosts.Items.Clear();
            lstLevelBonuses.Items.Clear();

            foreach (EntityClass entityClass in _classes)
            {
                lstCostClasses.Items.Add(entityClass.Name);
                lstClassBonus.Items.Add(entityClass.Name);
            }

            foreach (Stat stat in _stats)
            {
                lstStatBonus.Items.Add(stat.Name);
            }

            foreach (Race race in _races)
            {
                lstRaceBonus.Items.Add(race.Name);
            }
        }

        private void SetupFormForEntry(bool resetSkillsCombo)
        {
            //clear out controls
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                    ctrl.Text = "";
                else if (ctrl is CheckBox)
                    ((CheckBox)ctrl).Checked = false;
                else if (ctrl is ComboBox)
                {
                    if (ctrl == cboSkills && resetSkillsCombo)
                        ((ComboBox)ctrl).SelectedIndex = -1;
                }
            }

            SetupListBoxes();

            _costs = new Dictionary<string, string>();
            _classBonuses = new Dictionary<string, int>();
            _levelBonuses = new List<MinMaxBonus>();
            _raceBonuses = new Dictionary<string, int>();
            _statBonuses = new Dictionary<string, MinMaxBonus>();

            _opposingSkillControlSource = new List<KeyValuePair<string, int>>();

            FillOpposingSkillCombo();
        }

        private void SetupFormForEntry()
        {
            //clear out controls
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                    ctrl.Text = "";
                else if (ctrl is CheckBox)
                    ((CheckBox)ctrl).Checked = false;
                else if (ctrl is ComboBox)
                    ((ComboBox)ctrl).SelectedIndex = -1;
            }

            SetupListBoxes();

            _costs = new Dictionary<string, string>();
            _classBonuses = new Dictionary<string, int>();
            _levelBonuses = new List<MinMaxBonus>();
            _raceBonuses = new Dictionary<string, int>();
            _statBonuses = new Dictionary<string, MinMaxBonus>();

            _opposingSkillControlSource = new List<KeyValuePair<string, int>>();

            FillOpposingSkillCombo();
        }

        private void cboSkills_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSkills.SelectedIndex > -1)
            {
                _skill = _skills[cboSkills.SelectedIndex];

                FillOpposingSkillCombo(_skill.ID);

                SetupFormForEntry(false);

                txtName.Text = _skill.Name;
                txtDescription.Text = _skill.Description;
                chkAlwaysOn.Checked = _skill.AlwaysOn;
                txtIcon.Text = _skill.IconFilename;
                cboOpposingSkill.SelectedValue = _skill.OpposingSkill;

                Array types = Enum.GetValues(typeof(SkillType));

                for (int i = 0; i < types.Length; i++)
                {
                    if ((SkillType)types.GetValue(i) == _skill.Type)
                    {
                        cboType.SelectedIndex = i;
                        break;
                    }
                }

                //set tabs controls
                foreach (KeyValuePair<string, string> kvp in _skill.Costs)
                {
                    lstSkillCosts.Items.Add(kvp.Key + ": " + kvp.Value);
                    lstCostClasses.Items.Remove(kvp.Key);
                }

                if (_skill.ClassBonuses != null)
                {
                    foreach (KeyValuePair<string, int> kvp in _skill.ClassBonuses)
                    {
                        lstClassBonuses.Items.Add(kvp.Key + ": " + kvp.Value.ToString());
                        lstClassBonus.Items.Remove(kvp.Key);
                    }
                }

                if (_skill.LevelBonuses != null)
                {
                    foreach (MinMaxBonus bonus in _skill.LevelBonuses)
                    {
                        lstLevelBonuses.Items.Add(bonus.Min.ToString() + "-" + bonus.Max.ToString() + ": " + bonus.Amount.ToString());
                    }
                }

                if (_skill.RaceBonuses != null)
                {
                    foreach (KeyValuePair<string, int> kvp in _skill.RaceBonuses)
                    {
                        lstRaceBonuses.Items.Add(kvp.Key + ": " + kvp.Value.ToString());
                        lstRaceBonus.Items.Remove(kvp.Key);
                    }
                }

                if (_skill.StatBonuses != null)
                {
                    foreach (KeyValuePair<string, MinMaxBonus> kvp in _skill.StatBonuses)
                    {
                        lstStatBonuses.Items.Add(kvp.Key + ": " + kvp.Value.Min.ToString() + "-" + kvp.Value.Max.ToString() + " - " + kvp.Value.Amount.ToString());
                        lstStatBonus.Items.Remove(kvp.Key);
                    }
                }

                btnUpdate.Enabled = true;
            }
        }

        private void lstSkillCosts_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDelCost.Enabled = lstSkillCosts.SelectedIndex > -1;
        }

        private void btnAddClassBonus_Click(object sender, EventArgs e)
        {
            _classBonuses.Add(lstClassBonus.SelectedItem.ToString(), Convert.ToInt32(txtClassBonus.Text));
            lstClassBonuses.Items.Add(lstClassBonus.SelectedItem.ToString() + ": " + txtClassBonus.Text);
            lstClassBonus.Items.RemoveAt(lstClassBonus.SelectedIndex);
            txtClassBonus.Text = "";
        }

        private void btnDelCost_Click(object sender, EventArgs e)
        {
            string cls = lstSkillCosts.SelectedItem.ToString().Substring(0, lstSkillCosts.SelectedItem.ToString().IndexOf(":"));
            lstCostClasses.Items.Add(cls);
            lstSkillCosts.Items.RemoveAt(lstSkillCosts.SelectedIndex);
            _costs.Remove(cls);
        }

        private void lstClassBonuses_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDelClassBonus.Enabled = lstClassBonuses.SelectedIndex > -1;
        }

        private void lstLevelBonuses_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDelLevelBonus.Enabled = lstLevelBonuses.SelectedIndex > -1;
        }

        private void lstRaceBonuses_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDelRaceBonus.Enabled = lstRaceBonuses.SelectedIndex > -1;
        }

        private void lstStatBonuses_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDelStatBonus.Enabled = lstStatBonuses.SelectedIndex > -1;
        }

        private void btnAddLevelBonus_Click(object sender, EventArgs e)
        {
            _levelBonuses.Add(new MinMaxBonus(Convert.ToInt32(txtMinLevel.Text), Convert.ToInt32(txtMaxLevel.Text), Convert.ToInt16(txtLevelBonus.Text)));
            lstLevelBonuses.Items.Add(txtMinLevel.Text + "-" + txtMaxLevel.Text + ": " + txtLevelBonus.Text);
            txtMinLevel.Text = "";
            txtMaxLevel.Text = "";
            txtLevelBonus.Text = "";
        }

        private void btnDelLevelBonus_Click(object sender, EventArgs e)
        {
            _levelBonuses.RemoveAt(lstLevelBonuses.SelectedIndex);
            lstLevelBonuses.Items.RemoveAt(lstLevelBonuses.SelectedIndex);
        }

        private void btnAddRaceBonus_Click(object sender, EventArgs e)
        {
            _raceBonuses.Add(lstRaceBonus.SelectedItem.ToString(), Convert.ToInt32(txtRaceBonus.Text));
            lstRaceBonuses.Items.Add(lstRaceBonus.SelectedItem.ToString() + ": " + txtRaceBonus.Text);
            txtRaceBonus.Text = "";
            lstRaceBonus.Items.RemoveAt(lstRaceBonus.SelectedIndex);
        }

        private void btnDelRaceBonus_Click(object sender, EventArgs e)
        {
            string item = lstRaceBonuses.SelectedItem.ToString();

            item = item.Substring(0, item.IndexOf(":"));
            _raceBonuses.Remove(item);

            lstRaceBonuses.Items.RemoveAt(lstRaceBonuses.SelectedIndex);
        }



        private void btnAddStatBonus_Click(object sender, EventArgs e)
        {
            _statBonuses.Add(lstStatBonus.SelectedItem.ToString(), new MinMaxBonus(Convert.ToInt32(txtStatMinVal.Text), Convert.ToInt32(txtStatMaxVal.Text), Convert.ToInt32(txtStatBonus.Text)));

            lstStatBonuses.Items.Add(lstStatBonus.SelectedItem.ToString() + ": " + txtStatMinVal.Text + "-" + txtStatMaxVal.Text + " - " + txtStatBonus.Text);
            txtStatMinVal.Text = "";
            txtStatMaxVal.Text = "";
            txtStatBonus.Text = "";
        }

        private void btnDelStatBonus_Click(object sender, EventArgs e)
        {
            string item = lstLevelBonuses.SelectedItem.ToString();

            item = item.Substring(0, item.IndexOf(":"));

            _levelBonuses.RemoveAt(lstLevelBonuses.SelectedIndex);
            lstLevelBonuses.Items.RemoveAt(lstLevelBonuses.SelectedIndex);
        }

        private void btnSelectIcon_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();

            if (dlg.ShowDialog() == DialogResult.OK)
                txtIcon.Text = dlg.SafeFileName.Substring(0, dlg.SafeFileName.Length - 4);
        }

        private void btnSelectIcon_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();

            if (dlg.ShowDialog() == DialogResult.OK)
                txtIcon.Text = dlg.SafeFileName.Substring(0, dlg.SafeFileName.Length - 4);

        }

        private void btnAddCost_Click_1(object sender, EventArgs e)
        {
            _costs.Add(lstCostClasses.SelectedItem.ToString(), txtCost.Text);
            lstSkillCosts.Items.Add(lstCostClasses.SelectedItem.ToString() + ": " + txtCost.Text);
            lstCostClasses.Items.RemoveAt(lstCostClasses.SelectedIndex);
            txtCost.Text = "";
        }

        private void btnDelCost_Click_1(object sender, EventArgs e)
        {
            string cls = lstSkillCosts.SelectedItem.ToString().Substring(0, lstSkillCosts.SelectedItem.ToString().IndexOf(":"));
            lstCostClasses.Items.Add(cls);
            lstSkillCosts.Items.RemoveAt(lstSkillCosts.SelectedIndex);
            _costs.Remove(cls);
        }

        private void btnAddClassBonus_Click_1(object sender, EventArgs e)
        {
            _classBonuses.Add(lstClassBonus.SelectedItem.ToString(), Convert.ToInt32(txtClassBonus.Text));
            lstClassBonus.Items.Add(lstClassBonus.SelectedItem.ToString() + ": " + txtClassBonus.Text);
            lstClassBonus.Items.RemoveAt(lstClassBonus.SelectedIndex);
            txtClassBonus.Text = "";
        }

        private void btnDelClassBonus_Click(object sender, EventArgs e)
        {
            string cls = lstClassBonus.SelectedItem.ToString().Substring(0, lstClassBonus.SelectedItem.ToString().IndexOf(":"));
            lstClassBonuses.Items.Add(cls);
            lstClassBonuses.Items.RemoveAt(lstClassBonuses.SelectedIndex);
            _costs.Remove(cls);
        }

        private void btnAddLevelBonus_Click_1(object sender, EventArgs e)
        {
            _levelBonuses.Add(new MinMaxBonus(Convert.ToInt32(txtMinLevel.Text), Convert.ToInt32(txtMaxLevel.Text), Convert.ToInt16(txtLevelBonus.Text)));
            lstLevelBonuses.Items.Add(txtMinLevel.Text + "-" + txtMaxLevel.Text + ": " + txtLevelBonus.Text);
            txtMinLevel.Text = "";
            txtMaxLevel.Text = "";
            txtLevelBonus.Text = "";
        }

        private void btnDelLevelBonus_Click_1(object sender, EventArgs e)
        {
            _levelBonuses.RemoveAt(lstLevelBonuses.SelectedIndex);
            lstLevelBonuses.Items.RemoveAt(lstLevelBonuses.SelectedIndex);
        }

        private void btnAddRaceBonus_Click_1(object sender, EventArgs e)
        {
            _raceBonuses.Add(lstRaceBonus.SelectedItem.ToString(), Convert.ToInt32(txtRaceBonus.Text));
            lstRaceBonuses.Items.Add(lstRaceBonus.SelectedItem.ToString() + ": " + txtRaceBonus.Text);
            txtRaceBonus.Text = "";
            lstRaceBonus.Items.RemoveAt(lstRaceBonus.SelectedIndex);
        }

        private void btnDelRaceBonus_Click_1(object sender, EventArgs e)
        {
            string item = lstRaceBonuses.SelectedItem.ToString();

            item = item.Substring(0, item.IndexOf(":"));
            _raceBonuses.Remove(item);

            lstRaceBonuses.Items.RemoveAt(lstRaceBonuses.SelectedIndex);
        }

        private void btnAddStatBonus_Click_1(object sender, EventArgs e)
        {
            _statBonuses.Add(lstStatBonus.SelectedItem.ToString(), new MinMaxBonus(Convert.ToInt32(txtStatMinVal.Text), Convert.ToInt32(txtStatMaxVal.Text), Convert.ToInt32(txtStatBonus.Text)));

            lstStatBonuses.Items.Add(lstStatBonus.SelectedItem.ToString() + ": " + txtStatMinVal.Text + "-" + txtStatMaxVal.Text + " - " + txtStatBonus.Text);
            txtStatMinVal.Text = "";
            txtStatMaxVal.Text = "";
            txtStatBonus.Text = "";
        }

        private void btnDelStatBonus_Click_1(object sender, EventArgs e)
        {
            string item = lstLevelBonuses.SelectedItem.ToString();

            item = item.Substring(0, item.IndexOf(":"));

            _levelBonuses.RemoveAt(lstLevelBonuses.SelectedIndex);
            lstLevelBonuses.Items.RemoveAt(lstLevelBonuses.SelectedIndex);
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {

            FillSkillObject();

            if (_skills == null)
                _skills = new List<Skill>();

            _skills.Add(_skill);
            cboSkills.Items.Add(_skill.Name);
            _curID++;
            _skill = new Skill(_curID);

            SetupFormForEntry();

            _saved = false;

        }

        private void btnNew_Click_1(object sender, EventArgs e)
        {
            SetupFormForEntry();

            btnNew.Enabled = false;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            btnAdd.Enabled = true;
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            FillSkillObject();

            _skills[cboSkills.SelectedIndex] = _skill;

            SetupFormForEntry();
            _saved = false;

        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            _skills.RemoveAt(cboSkills.SelectedIndex);
            cboSkills.Items.RemoveAt(cboSkills.SelectedIndex);

            SetupFormForEntry();
        }
    }
}
