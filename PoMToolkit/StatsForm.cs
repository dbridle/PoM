using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Xml;
using System.Windows.Forms;
using Microsoft.Xna.Framework.Content.Pipeline.Serialization.Intermediate;

using PoMLibrary;

namespace PoMToolkit
{
    public partial class StatsForm : BaseForm
    {

        private List<Stat> _stats;
        private string _gameName = "";

        public StatsForm(string GameName)
        {

            InitializeComponent();

            _gameName = GameName;

            string[] files = Directory.GetFiles(Application.StartupPath + @"\games\" + _gameName + @"\stats");

            _stats = new List<Stat>();

            foreach (string file in files)
            {
                Stat stat = GlobalFunctions.LoadStat(file);

                if (stat != null)
                {
                    _stats.Add(stat);
                    cbStats.Items.Add(stat.Name);
                }
            }

            _saved = true;
        }

        private void SaveStats()
        {
            try
            {
                XmlWriterSettings settings = new XmlWriterSettings();
                settings.Indent = true;

                XmlWriter writer;

                foreach (Stat stat in _stats)
                {
                    writer = XmlWriter.Create(Application.StartupPath + @"\Games\" + _gameName + @"\stats\" + stat.Name + ".xml", settings);
                    IntermediateSerializer.Serialize(writer, stat, null);
                    writer.Close();
                    writer = null;

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

            Stat stat = new Stat(txtStatName.Text);
            stat.Abbreviation = txtAbbreviation.Text;
            stat.Description = txtDescription.Text;
            stat.Type = rbRegular.Checked ? StatType.Regular : StatType.Calculated;

            _stats.Add(stat);

            cbStats.Items.Add(stat.Name);

            txtStatName.Text = "";
            txtAbbreviation.Text = "";
            txtDescription.Text = "";
            txtCalculation.Text = "";

            rbRegular.Checked = true;

            _saved = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            Stat stat = _stats[cbStats.SelectedIndex];
            
            stat.Abbreviation = txtAbbreviation.Text;
            stat.Description = txtDescription.Text;
            stat.Type = rbRegular.Checked ? StatType.Regular : StatType.Calculated;

            _stats[cbStats.SelectedIndex] = stat;

            _saved = false;

        }

        private void cbStats_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbStats.SelectedIndex > -1)
            {
                Stat stat = _stats[cbStats.SelectedIndex];

                txtStatName.Text = stat.Name;
                txtDescription.Text = stat.Description;
                txtAbbreviation.Text = stat.Abbreviation;
                txtCalculation.Text = stat.StatCalculation;

                if (stat.Type == StatType.Regular)
                    rbRegular.Checked = true;
                else
                    rbCalculated.Checked = true;
            }
            else
            {
                txtStatName.Text = "";
                txtDescription.Text = "";
                txtAbbreviation.Text = "";
                txtCalculation.Text = "";

                rbRegular.Checked = true;

                btnNew.Enabled = false;
                btnDelete.Enabled = false;
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            _stats.RemoveAt(cbStats.SelectedIndex);
            cbStats.Items.RemoveAt(cbStats.SelectedIndex);

            cbStats.SelectedIndex = -1;

            _saved = false;

            txtStatName.Text = "";
            txtDescription.Text = "";
            txtAbbreviation.Text = "";
            txtCalculation.Text = "";

            rbRegular.Checked = true;
            

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            cbStats.SelectedIndex = -1;
        }

        private void mnuLoad_Click(object sender, EventArgs e)
        {

            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Multiselect = true;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Stat stat;

                foreach (string file in dlg.FileNames)
                {
                    stat = GlobalFunctions.LoadStat(file);

                    if (stat != null)
                    {
                        _stats.Add(stat);

                        cbStats.Items.Add(stat.Name);
                    }
                }
            }


        }

        private void StatsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_saved)
            {
                DialogResult result = MessageBox.Show("Save changes?", "Save Stats", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                    SaveStats();
                else // if (result == DialogResult.Cancel)
                    e.Cancel = true;
            }
        }

        private void mnuSave_Click(object sender, EventArgs e)
        {
            if (!_saved)
                SaveStats();
        }

        public override void save()
        {
            SaveStats();
        }

        private void rbRegular_CheckedChanged(object sender, EventArgs e)
        {
            this.btnConfigCalculatedStat.Enabled = rbCalculated.Checked;
        }

        private void btnConfigCalculatedStat_Click(object sender, EventArgs e)
        {
            CalculatedStatConfigForm frm = new CalculatedStatConfigForm(_stats);

            if (frm.ShowDialog() == DialogResult.OK)
                txtCalculation.Text = frm.GetCalculation();
        }
    }
}
