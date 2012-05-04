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
    public partial class DamageSelectionForm : Form
    {

        private List<Damager> _damagers;

        public DamageSelectionForm()
        {
            InitializeComponent();
        }

        public DamageSelectionForm(List<Damager> damagers)
        {
            InitializeComponent();

            if (_damagers != null)
            {
                foreach (Damager damager in _damagers)
                    lstDamagers.Items.Add(damager.Type.ToString() + " - " + damager.DamageAmount);
            }
        }

        public List<Damager> GetDamagers()
        {
            return _damagers;
        }

        private void CheckEntry(object sender, EventArgs e)
        {
            if (cbDamager.SelectedIndex > -1 && txtAmount.Text.Length > 0)
                btnAdd.Enabled = true;
            else
                btnAdd.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _damagers.RemoveAt(lstDamagers.SelectedIndex);
            lstDamagers.Items.RemoveAt(lstDamagers.SelectedIndex);
        }

        private void lstDamagers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstDamagers.SelectedIndex > -1)
                btnDelete.Enabled = true;
            else
                btnDelete.Enabled = false;
        }


    }
}
