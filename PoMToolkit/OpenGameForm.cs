using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;

using PoMLibrary;

namespace PoMToolkit
{
    public partial class OpenGameForm : Form
    {

        private string _gameName = "";

        public string GameName
        {
            get { return _gameName; }
            set { }
        }

        public string GameDescription
        {
            get { return txtDescription.Text; }
            set { }
        }


        public OpenGameForm()
        {
            InitializeComponent();

            // Retrieve the games folder
            string[] games = Directory.GetDirectories(Application.StartupPath + @"\Games\");

            if (games != null)
                foreach (string game in games)
                    cbGames.Items.Add(game.Substring(game.LastIndexOf(@"\") + 1));
        
        }

        private void cbGames_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbGames.SelectedIndex > -1)
            {
                btnOK.Enabled = true;

                // Get the description by serializing xml
                XmlSerializer serializer = new XmlSerializer(typeof(RPGGame));

                FileStream stream = new FileStream(Application.StartupPath +
                                                    @"\games\" + cbGames.SelectedItem.ToString() +
                                                    @"\" + cbGames.SelectedItem.ToString() + ".gdf", FileMode.Open);

                RPGGame game;
                game = (RPGGame)serializer.Deserialize(stream);
                txtDescription.Text = game.Description;
                _gameName = game.GameName;

                stream.Close();

            }
            else
                btnOK.Enabled = false;

                
        }


    }
}
