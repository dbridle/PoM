using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PoMLibrary;

namespace PoMToolkit
{
    public partial class StatsGeneratorForm : Form
    {
        private List<Stat> _stats;
        private List<EntityStat> _entityStats;

        private Dictionary<string, int> _raceMods;
        private Dictionary<string, int> _classMods;

        private Random _random;

        public StatsGeneratorForm()
        {
            InitializeComponent();
        }

        public StatsGeneratorForm(List<Stat> stats, Dictionary<string, int> raceMods, Dictionary<string, int> classMods)
        {
            InitializeComponent();

            _stats = stats;

            // Need these 2 lists to figure stat adjustments
            _raceMods = raceMods;
            _classMods = classMods;

            foreach (Stat stat in _stats)
                lvStats.Items.Add(stat.Name);

            _entityStats = new List<EntityStat>();
            _random = new Random();

            txtMaxAmount.Text = Stat.MaxStatValue.ToString();
        }

        public List<EntityStat> GetStats()
        {
            return _entityStats;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            _entityStats.Clear();

            int count = 0;
            int minAmount = txtMinAmount.Text.Length > 0 ? Convert.ToInt32(txtMinAmount.Text) : 1;
            int maxAmount = txtMaxAmount.Text.Length > 0 ? Convert.ToInt32(txtMaxAmount.Text) : 1;
            int raceMod = 0;
            int classMod = 0;

            lvStats.Items.Clear();

            foreach (Stat stat in _stats)
            {
                if (_raceMods != null)
                    _raceMods.TryGetValue(stat.Abbreviation, out raceMod);

                if (_classMods != null)
                    _classMods.TryGetValue(stat.Abbreviation, out classMod);

                _entityStats.Add(new EntityStat(stat.Abbreviation, (short)_random.Next(minAmount, maxAmount + 1 - raceMod - classMod)));

                lvStats.Items.Add(stat.Name);
                lvStats.Items[count].SubItems.Add(_entityStats[count].CurrentValue.ToString());
                lvStats.Items[count].SubItems.Add(raceMod.ToString());
                lvStats.Items[count].SubItems.Add(classMod.ToString());

                lvStats.Items[count].SubItems.Add((_entityStats[count].CurrentValue + raceMod + classMod).ToString());

                count += 1;
            }

            btnOK.Enabled = true;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtMinAmount_Validating(object sender, CancelEventArgs e)
        {
            btnGenerate.Enabled = GlobalFunctions.IsNumeric(txtMinAmount.Text);
        }
         

    }
}
