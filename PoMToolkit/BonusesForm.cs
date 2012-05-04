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
    public partial class BonusesForm : Form
    {

        private List<Bonus> _bonuses;

        public BonusesForm()
        {
            InitializeComponent();
        }

        public BonusesForm(List<Bonus> bonuses, int type)
        {
            InitializeComponent();

            _bonuses = bonuses;

            // Load listbox
            if (_bonuses != null)
            {
                foreach (Bonus bonus in _bonuses)
                    lstCurBonuses.Items.Add(bonus.Type + ": " + bonus.Amount + " - " + bonus.Duration);
            }

            switch (type)
            {
                case 0:
                    {
                        rbDefensive.Checked = true;
                        break;
                    }
                case 1:
                    {
                        rbOffensive.Checked = true;
                        break;
                    }
                case 2:
                    {
                        rbMisc.Checked = true;
                        break;
                    }
            }
        }

        public List<Bonus> GetBonuses()
        {
            return _bonuses;
        }

        private void CheckEntry(object sender, EventArgs e)
        {
            if (cbCategory.SelectedIndex > -1 && txtAmount.Text.Length > 0 && txtDuration.Text.Length > 0)
                btnAdd.Enabled = true;
            else
                btnAdd.Enabled = false;

        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstCurBonuses.SelectedIndex > -1)
                btnDelete.Enabled = true;
            else
                btnDelete.Enabled = false;
        }
    }
}
