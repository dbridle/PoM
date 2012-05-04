using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PoMLibrary;
using Microsoft.Xna.Framework.Content.Pipeline.Serialization.Intermediate;
using System.Xml;

namespace PoMToolkit
{
    public partial class EntitiesForm : BaseForm
    {

        // Determins what controls are to be filled, used when selecting an entity from the dropdown or when one of the bonus buttons is clicked
        private enum BonusFillType
        {
            Offensive,
            Defensive,
            Miscellaneous,
            Resistance,
            Weakness,
            All
        }

        private string _gameName = "";

        private List<Entity> _entities;
        private List<EntityClass> _classes;
        private List<Race> _races;

        private List<Stat> _stats;
        private List<EntityStat> _entityStats;

        private List<Bonus> _offBonuses;
        private List<Bonus> _defBonuses;
        private List<Bonus> _miscBonuses;

        private List<Damager> _damageResistances;
        private List<Damager> _damageWeaknesses;

        private List<EntityLevel> _levels;

        public EntitiesForm(string GameName)
        {
            InitializeComponent();

            _gameName = GameName;

            // Add a "N/A" to the class and race combos for non-humans, we'll just substract one from the index if neccessary
            cbClass.Items.Clear();
            cbRace.Items.Clear();
            cbClass.Items.Add("N/A");
            cbRace.Items.Add("N/A");

            string[] files = Directory.GetFiles(Application.StartupPath + @"\Games\" + _gameName + @"\classes");

            _classes = new List<EntityClass>();

            foreach (string file in files)
            {
                EntityClass entityClass = GlobalFunctions.LoadClass(file);

                    if (entityClass != null)
                    {
                        _classes.Add(entityClass);
                        cbClass.Items.Add(entityClass.Name);
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
                    cbRace.Items.Add(race.Name);
                }
            }

            files = Directory.GetFiles(Application.StartupPath + @"\Games\" + _gameName + @"\entities");

             _entities = new List<Entity>();

            foreach (string file in files)
            {
                Entity entity = GlobalFunctions.LoadEntity(file);

                if (entity != null)
                {
                    _entities.Add(entity);
                    cbRace.Items.Add(entity.Name);
                }
            }

            _saved = true;

            if (File.Exists(Application.StartupPath + @"\EntityLevelData.xml"))
            {
                FileStream stream = new FileStream(Application.StartupPath + @"\EntityLevelData.xml", FileMode.OpenOrCreate);
                XmlDocument doc = new XmlDocument();

                doc.Load(stream);

                _levels = new List<EntityLevel>();

                foreach (XmlNode node in doc.DocumentElement)
                    _levels.Add(new EntityLevel(Convert.ToInt32(node.Attributes["MinExp"].Value), Convert.ToInt32(node.Attributes["MaxExp"].Value)));

                stream.Close();
            }
        }

        private void FillEntityObject(ref Entity entity)
        {

            // Add validation!
            entity.Type = (EntityType)cbType.SelectedIndex;

            if (txtAge.Text.Length > 0)
                entity.Age = Convert.ToInt16(txtAge.Text);

            entity.Alignment = (EntityAlignment)cbAlignment.SelectedIndex;
            entity.ClassID = _classes[(cbClass.SelectedIndex - 1)].Name;
            entity.IsVendor = chkVendor.Checked;
            entity.Level = Convert.ToByte(txtLevel.Text);
            entity.Experience = Convert.ToInt32(txtExperience.Text);
            entity.Name = txtName.Text;

            if (cbRace.SelectedIndex > 0)
                entity.RaceID = _races[cbRace.SelectedIndex - 1].Name;

            entity.BaseHP = Convert.ToInt16(txtBaseHP.Text);
            entity.CurHP = Convert.ToInt16(txtCurHP.Text);

            if (rbSexFemale.Checked)
                entity.Sex = EntitySex.Female;
            else if (rbSexMale.Checked)
                entity.Sex = EntitySex.Male;

            entity.PortaitFilename = txtPortraitFilename.Text;
            entity.SpriteFilename = txtSpriteFilename.Text;

            entity.Stats = _entityStats;

            entity.SetOffensiveBonuses(_offBonuses);
            entity.SetDefensiveBonuses(_defBonuses);
            entity.SetMiscBonuses(_miscBonuses);
            entity.SetDamageResistnaces(_damageResistances);
            entity.SetDamageWeaknesses(_damageWeaknesses);
        }

        private void SetupFormForEntry()
        {

            // Clear out controls
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                    ctrl.Text = "";
                else if (ctrl is CheckBox)
                    ((CheckBox)ctrl).Checked = false;
                else if (ctrl is ComboBox)
                    ((ComboBox)ctrl).SelectedIndex = -1;
            }

            cbStats.Items.Clear();
            cbDamageWeakness.Items.Clear();
            cbDamageResistance.Items.Clear();
            cbDefensiveBonuses.Items.Clear();

            _entityStats = new List<EntityStat>();
            _offBonuses = new List<Bonus>();
            _defBonuses = new List<Bonus>();
            _miscBonuses = new List<Bonus>();
            _damageResistances = new List<Damager>();
            _damageWeaknesses = new List<Damager>();

        }

        private void SetupFormForEntry(bool resetEntitiesCombo)
        {

            // Clear out controls
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                    ctrl.Text = "";
                else if (ctrl is CheckBox)
                    ((CheckBox)ctrl).Checked = false;
                else if (ctrl is ComboBox)
                {
                    if (ctrl == cbEntities && !resetEntitiesCombo)
                        break;

                    ((ComboBox)ctrl).SelectedIndex = -1;
                }
            }

            cbStats.Items.Clear();
            cbDamageWeakness.Items.Clear();
            cbDamageResistance.Items.Clear();
            cbDefensiveBonuses.Items.Clear();

            _entityStats = new List<EntityStat>();
            _offBonuses = new List<Bonus>();
            _defBonuses = new List<Bonus>();
            _miscBonuses = new List<Bonus>();
            _damageResistances = new List<Damager>();
            _damageWeaknesses = new List<Damager>();

        }

        private void FillBonusControls(BonusFillType fillType)
        {
            if (fillType == BonusFillType.Defensive || fillType == BonusFillType.All)
            {
                if (_defBonuses != null)
                {
                    foreach (Bonus bonus in _defBonuses)
                        cbDefensiveBonuses.Items.Add(bonus.Type.ToString() + ": " + bonus.Amount.ToString());
                }
            }

            if (fillType == BonusFillType.Offensive || fillType == BonusFillType.All)
            {
                if (_offBonuses != null)
                {
                    foreach (Bonus bonus in _offBonuses)
                        cbOffensiveBonuses.Items.Add(bonus.Type.ToString() + ": " + bonus.Amount.ToString());
                }
            }

            if (fillType == BonusFillType.Miscellaneous || fillType == BonusFillType.All)
            {
                if (_miscBonuses != null)
                {
                    foreach (Bonus bonus in _miscBonuses)
                        cbMiscBonuses.Items.Add(bonus.Type.ToString() + ": " + bonus.Amount.ToString());
                }
            }

            if (fillType == BonusFillType.Resistance || fillType == BonusFillType.All)
            {
                cbDamageResistance.Items.Clear();

                if (_damageResistances != null)
                {
                    foreach (Damager damager in _damageResistances)
                        cbDamageResistance.Items.Add(damager.Type.ToString() + ": " + damager.DamageAmount);
                }
            }

            if (fillType == BonusFillType.Resistance || fillType == BonusFillType.All)
            {
                cbDamageWeakness.Items.Clear();

                if (_damageWeaknesses != null)
                {
                    foreach (Damager damager in _damageWeaknesses)
                        cbDamageWeakness.Items.Add(damager.Type.ToString() + ": " + damager.DamageAmount);
                }
            }

        }

        private int GetIndexForRaceID(string name)
        {
            for (int i = 0; i < _races.Count; i++)
            {
                // Return 1 greater due to having "N/A" in the combo box list
                if (_races[i].Name == name)
                    return i + 1;
            }

            return 0;
        }

        private int GetIndexForClassID(string name)
        {
            for (int i = 0; i < _classes.Count; i++)
            {
                // Return 1 greater due to having "N/A" in the combo box list
                if (_classes[i].Name == name)
                    return i + 1;
            }

            return 0;
        }

        public override void save()
        {
            SaveEntities();  
        }

        private void SaveEntities()
        {
            try
            {
                XmlWriter writer;
                XmlWriterSettings settings = new XmlWriterSettings();

                settings.Indent = true;

                foreach (Entity entity in _entities)
                {
                    writer = XmlWriter.Create(Application.StartupPath + @"\Games\" + _gameName + @"\entities\" + entity.Name + ".xml", settings);

                    IntermediateSerializer.Serialize(writer, entity, null);

                    writer.Close();
                }

                _saved = true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (_entities == null)
                _entities = new List<Entity>();

            Entity entity = new Entity();

            FillEntityObject(ref entity);
            _entities.Add(entity);
            cbEntities.Items.Add(entity.Name + " - " + entity.ClassID);
            SetupFormForEntry();

            _saved = false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {

            SetupFormForEntry();

            btnUpdate.Enabled = false;
            btnAdd.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            Entity entity = _entities[cbEntities.SelectedIndex];

            FillEntityObject(ref entity);
            _entities[cbEntities.SelectedIndex] = entity;

            _saved = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Delete file
            try
            {
                File.Delete(Application.StartupPath + @"\Games\" + _gameName + @"\entities\" + _entities[cbEntities.SelectedIndex].Name + ".xml");
            }
            catch (Exception ex)
            {
            }

            _entities.RemoveAt(cbEntities.SelectedIndex);
            cbEntities.Items.RemoveAt(cbEntities.SelectedIndex);

            SetupFormForEntry();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRandAmt_Click(object sender, EventArgs e)
        {
            if (txtLevel.Text.Length > 0)
            {
                int min = _levels[Convert.ToInt32(txtLevel.Text) - 1].MinExperience;
                int max = _levels[Convert.ToInt32(txtLevel.Text) - 1].MaxExperience;
                txtExperience.Text = GlobalFunctions.GetRandomNumber(min, max).ToString();
            }
        }

        private void btnDefensiveBonuses_Click(object sender, EventArgs e)
        {
            BonusesForm frm = new BonusesForm(_defBonuses, 0);

            if (frm.ShowDialog() == DialogResult.OK)
                _defBonuses = frm.GetBonuses();

            FillBonusControls(BonusFillType.Defensive);
        }

        private void btnOffensiveBonuses_Click(object sender, EventArgs e)
        {
            BonusesForm frm = new BonusesForm(_offBonuses, 0);

            if (frm.ShowDialog() == DialogResult.OK)
                _offBonuses = frm.GetBonuses();

            FillBonusControls(BonusFillType.Offensive);
        }

        private void btnMiscBonuses_Click(object sender, EventArgs e)
        {
            BonusesForm frm = new BonusesForm(_miscBonuses, 0);

            if (frm.ShowDialog() == DialogResult.OK)
                _miscBonuses = frm.GetBonuses();

            FillBonusControls(BonusFillType.Miscellaneous);
        }

        private void btnDamageResistance_Click(object sender, EventArgs e)
        {
            DamageSelectionForm frm = new DamageSelectionForm(_damageResistances);

            if (frm.ShowDialog() == DialogResult.OK)
            {
                _damageResistances = frm.GetDamagers();
                FillBonusControls(BonusFillType.Resistance);
            }
        }

        private void btnDamageWeakness_Click(object sender, EventArgs e)
        {
            DamageSelectionForm frm = new DamageSelectionForm(_damageWeaknesses);

            if (frm.ShowDialog() == DialogResult.OK)
            {
                _damageWeaknesses = frm.GetDamagers();
                FillBonusControls(BonusFillType.Resistance);
            }
        }

        private void btnPortraitFilename_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();

            if (dlg.ShowDialog() == DialogResult.OK)
                txtPortraitFilename.Text = dlg.SafeFileName.Substring(0, dlg.SafeFileName.Length - 4);
        }

        private void btnSpriteFilename_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();

            if (dlg.ShowDialog() == DialogResult.OK)
                txtSpriteFilename.Text = dlg.SafeFileName.Substring(0, dlg.SafeFileName.Length - 4);
        }

        private void cbEntities_SelectedIndexChanged(object sender, EventArgs e)
        {

            Entity entity = _entities[cbEntities.SelectedIndex];

            SetupFormForEntry(false);

            txtName.Text = entity.Name;
            cbType.SelectedIndex = (int)entity.Type;
            cbClass.SelectedIndex = GetIndexForClassID(entity.ClassID);
            txtLevel.Text = entity.Level.ToString();
            txtExperience.Text = entity.Experience.ToString();
            cbAlignment.SelectedIndex = (int)entity.Alignment;

            if (entity.Sex == EntitySex.Male)
                rbSexMale.Checked = true;
            else
                rbSexFemale.Checked = true;

            _entityStats = entity.Stats;

            cbStats.Items.Clear();

            for (int i = 0; i < _entityStats.Count; i++)
                cbStats.Items.Add(((Stat)_stats[i]).Name + ": " + _entityStats[i].CurrentValue.ToString());

            txtBaseHP.Text = entity.BaseHP.ToString();
            txtCurHP.Text = entity.CurHP.ToString();
            cbRace.SelectedIndex = GetIndexForRaceID(entity.RaceID);
            txtAge.Text = entity.Age.ToString();

            _defBonuses = entity.DefensiveBonuses;
            _offBonuses = entity.OffensiveBonuses;
            _miscBonuses = entity.MiscBonuses;
            _damageResistances = entity.DamageResistances;
            _damageWeaknesses = entity.DamageWeaknesses;

            FillBonusControls(BonusFillType.All);

            txtPortraitFilename.Text = entity.PortaitFilename;
            txtSpriteFilename.Text = entity.SpriteFilename;

            chkVendor.Checked = entity.IsVendor;

            btnUpdate.Enabled = true;
            btnNew.Enabled = true;

        }

        private void mnuSave_Click(object sender, EventArgs e)
        {
            SaveEntities();
        }

        private void mnuLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Multiselect = true;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Entity entity;

                foreach (string file in dlg.FileNames)
                {
                    entity = GlobalFunctions.LoadEntity(file);

                    if (entity != null)
                    {
                        _entities.Add(entity);
                        cbEntities.Items.Add(entity.Name);
                    }

                }
                _saved = false;
            }
        }
               

    }
}
