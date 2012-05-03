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
    public partial class CalculatedStatConfigForm : Form
    {

        private List<Stat> _stats;
        private Random _random;

        public CalculatedStatConfigForm(List<Stat> stats)
        {
            InitializeComponent();

            _random = new Random();
            _stats = stats;

            foreach (Stat stat in stats)
                lstStats.Items.Add(stat.Name);
        }

        private void InsertItem(string item)
        {
            if (txtStatCalculation.Text.Length > 0)
            {

                string text = txtStatCalculation.Text;

                // Find out where to put the operator in the string
                int index = txtStatCalculation.SelectionStart;

                // Set default values in order to use .tostring method
                char before = '\u0000';
                char after = '\u0000';

                if (index > 0)
                    before = Convert.ToChar(text.Substring(index - 1, 1));

                if (index < text.Length)
                    after = Convert.ToChar(text.Substring(index, 1));

                if (!(before.ToString() != "" || before.ToString() != "") && !(after.ToString() != "" || after.ToString() != " "))
                {
                    // Can't insert into the middle of a stat
                    MessageBox.Show("Cannot insert here");
                    return;
                }

                StringBuilder sb = new StringBuilder(text);

                // Figure out if pre or post space is needed
                if (!string.IsNullOrEmpty(before.ToString()))
                    item = " " + item;

                if (!string.IsNullOrEmpty(after.ToString()))
                    item += " ";

                sb.Insert(index, item);

                txtStatCalculation.Text = sb.ToString();
            }
            else
                txtStatCalculation.Text = item;

            txtStatCalculation.SelectionStart = txtStatCalculation.Text.Length;

        }
 


        private void OperatorClick(object sender, EventArgs e)
        {
            InsertItem(((Button)sender).Text);
        }

        private void btnAddStat_Click(object sender, EventArgs e)
        {
            InsertItem(_stats[lstStats.SelectedIndex].Abbreviation);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public string GetCalculation()
        {
            return txtStatCalculation.Text;
        }

        private void btnRandomNum_Click(object sender, EventArgs e)
        {
            InsertItem("<" + _random.Next(1, 101).ToString() + ">");
        }

        private void btnAddValue_Click(object sender, EventArgs e)
        {
            InsertItem(txtValue.Text);
        }
        

    
    }

    
}
