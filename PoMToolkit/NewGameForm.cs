using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PoMToolkit
{
    public partial class NewGameForm : Form
    {

        public NewGameForm()
        {
            InitializeComponent();
        }

        public string GameName
        {
            get { return txtGameName.Text; }
            set { }
        }

        public string GameDescription
        {
            get { return txtGameDescription.Text; }
            set { }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(Application.StartupPath + @"\Games\" + txtGameName.Text))
                MessageBox.Show("Game already exists. Choose another name.", "Existing Game Error", MessageBoxButtons.OK);
            else
                this.Hide();
        }
    }
}
