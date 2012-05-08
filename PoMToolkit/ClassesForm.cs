using System;
using System.IO;
using System.Xml;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Xna.Framework.Content.Pipeline.Serialization.Intermediate;
using PoMLibrary;

namespace PoMToolkit
{
    public partial class ClassesForm : BaseForm
    {

        private List<EntityClass> _classes;

        private EntityClass _class;
        private string _gameName = "";

        private List<Stat> _stats;

        public ClassesForm(string gameName)
        {
            InitializeComponent();

            _classes = new List<EntityClass>();
            _gameName = gameName;
            _saved = true;

            string[] files = Directory.GetFiles(Application.StartupPath + @"\Games\" + _gameName + @"\stats");

            _stats = new List<Stat>();

            Stat stat;

            foreach (string file in files)
            {
                stat = GlobalFunctions.LoadStat(file);

                if (stat != null)
                {
                    cbStats.Items.Add(stat.Name);
                    _stats.Add(stat);
                }
            }

            files = Directory.GetFiles(Application.StartupPath + @"\Games\" + _gameName + @"\classes");

            EntityClass entityClass;

            foreach (string file in files)
            {

                entityClass = GlobalFunctions.LoadClass(file);

                if (entityClass != null)
                {
                    cbClasses.Items.Add(entityClass.Name);
                    _classes.Add(entityClass);
                }
            }

            cbDiceType.Items.AddRange(Enum.GetNames(typeof(DieType)));

            // Since we need a valid entityclass object to add stat modifiers, we'll create a temp class at the start
            // instead of when we add one to the list, as we do with the lists classes like stats

            _class = new EntityClass();
            _saved = true;
        }

        private int GetIndexForType(DieType type)
        {
            int count = 0;
            foreach (string name in Enum.GetNames(typeof(DieType)))
            {
                if (name == type.ToString())
                    return count;

                count += 1;
            }

            return -1;
        }


        private void cbClasses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbClasses.SelectedIndex > -1)
            {
                
                _class = _classes[cbClasses.SelectedIndex];

                txtClassName.Text = _class.Name;
                txtClassDescription.Text = _class.Description;
                cbDiceType.SelectedIndex = GetIndexForType(_class.HPDice);
                cbModifiers.Items.Clear();

                int val;

                foreach (Stat stat in _stats)
                {
                    val = _class.GetStatModifier(stat.Abbreviation);
                    if (val != 0)
                    {
                        cbModifiers.Items.Add(stat.Name + ": " + val.ToString());
                    }
                }

                btnAdd.Enabled = false;
                btnUpdate.Enabled = true;

            }
        }

        private void mnuSave_Click(object sender, EventArgs e)
        {

            if (!_saved)
                SaveClasses();
        }

        public override void save()
        {
            SaveClasses();

        }

        private void SaveClasses()
        {
            try
            {
                XmlWriterSettings settings = new XmlWriterSettings();
                settings.Indent = true;

                XmlWriter writer;

                foreach (EntityClass entityClass in _classes)
                {
                    writer = XmlWriter.Create(Application.StartupPath + @"\Games\" + _gameName + @"\classes\" + entityClass.Name + ".xml", settings);
                    IntermediateSerializer.Serialize(writer, entityClass, null);
                    writer.Close();
                }

                _saved = true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void SaveControlsData()
        {

            _class.Name = txtClassName.Text;
            _class.Description = txtClassDescription.Text;
            _class.HPDice = (DieType)Enum.GetValues(typeof(DieType)).GetValue(cbDiceType.SelectedIndex);

            if (cbModifiers.Items.Count > 0)
            {
                if (_class.StatModifiersCount > 0)
                    _class.ClearStatModifiers();

                string temp = "";
                string val;

                for (int i=0; i<cbModifiers.Items.Count; i++)
                {
                    temp = cbModifiers.Items[i].ToString();
                    val = GetStatIDForListItem(temp);

                    if (val != "")
                    {
                        Debug.WriteLine("Adding to class structure: " + val + Convert.ToInt32(temp.Substring(temp.IndexOf(":") + 1).Trim()));
                        _class.AddStatModifier(val, Convert.ToInt32(temp.Substring(temp.IndexOf(":") + 1).Trim()));
                    }
                    else
                        MessageBox.Show("Stat ID not found for item: " + temp);
                }
            }

        }

        private void SetupForNewEntry()
        {

            txtClassName.Text = "";
            txtClassDescription.Text = "";

            cbModifiers.Items.Clear();

            txtAmount.Text = "";
            cbStats.SelectedIndex = -1;
        }

        private string GetStatIDForListItem(string item)
        {
            for (int i=0; i<_stats.Count; i++)
                if (item.Contains(_stats[i].Name))
                    return _stats[i].Abbreviation;
        
            return "";
        }

        private void mnuLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Multiselect = true;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                EntityClass entityClass;

                foreach (string file in dlg.FileNames)
                {
                    entityClass = GlobalFunctions.LoadClass(file);

                    if (entityClass != null)
                    {
                        cbClasses.Items.Add(entityClass.Name);
                        _classes.Add(entityClass);
                    }
                }

                _saved = false;
            }
        }

        private void btnAddModifier_Click(object sender, EventArgs e)
        {
            bool ret = false;

            // See if the modifier has already been added
            for (int i=0; i<cbModifiers.Items.Count; i++)
            {
                if (cbModifiers.Items[i].ToString().Contains(cbStats.SelectedItem.ToString()))
                {
                    ret = true;
                    MessageBox.Show("Modifier already exists for this stat");
                }
            }

            if (!ret)
            {
                cbModifiers.Items.Add(cbStats.SelectedItem.ToString() + ": " + txtAmount.Text);
                Debug.WriteLine("Adding item: " + cbStats.SelectedItem.ToString() + ": " + txtAmount.Text);
                txtAmount.Text = "";
                cbStats.SelectedIndex = -1;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SaveControlsData();

            _classes.Add(_class);
            cbClasses.Items.Add(txtClassName.Text);
            SetupForNewEntry();

            _saved = false;
            _class = new EntityClass();

        }

        private void ClassesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_saved)
            {
                DialogResult result = MessageBox.Show("Save changes?", "Save Races", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                    SaveClasses();
                else // if (result == DialogResult.Cancel)
                    e.Cancel = true;
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnUpdate.Enabled = false;
            btnAdd.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            SaveControlsData();

            _classes[cbClasses.SelectedIndex] = _class;
            _saved = false;
            mnuSave.Enabled = true;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteModifier_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdateModifier_Click(object sender, EventArgs e)
        {

        }

        private void btnNewModifier_Click(object sender, EventArgs e)
        {

        }

    }
}
