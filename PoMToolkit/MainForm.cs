using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

using PoMLibrary;



namespace PoMToolkit
{
    public partial class MainForm : Form
    {

        private RPGGame _game;

        private delegate void showForm(object obj, EventArgs ev);

        public MainForm()
        {
            InitializeComponent();

            //create RPG Games folder if it doesn't exist
            if (!Directory.Exists(Application.StartupPath + @"\Games"))
                Directory.CreateDirectory(Application.StartupPath + @"\Games");
        }

        private void OpenFile(object sender, EventArgs e)
        {
            string ext = "";
            showForm showform;

            switch (((Control)sender).Tag.ToString())
            {
                case "Stats":
                    {
                        ext = "*.sdf";
                        showform = new showForm(ShowStatsForm);

                        break;
                    }
                case "Races":
                    {
                        ext = "*.rdf";
                        showform = new showForm(ShowRacesForm);

                        break;
                    }
                case "Classes":
                    {
                        ext = "*.cdf";
                        showform = new showForm(ShowClassesForm);

                        break;
                    }
                case "Entities":
                    {
                        ext = "*.edf";
                        showform = new showForm(ShowEntitiesForm);

                        break;
                    }
                default:
                    {
                        showform = new showForm(ShowNoForm);

                        break;
                    }
            }

            OpenFileDialog dlg = new OpenFileDialog();

            dlg.DefaultExt = ext;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                //need to worry about trying to copy a file over itself
                try
                {
                    File.Copy(dlg.FileName, Application.StartupPath + @"\Games\" + dlg.SafeFileName);
                    showform(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ShowNoForm(object sender, EventArgs e)
        {
            //does nothing and should never be called, just needed for code to compile
        }


        private void NewGame(object sender, EventArgs e)
        {

            using(NewGameForm frm = new NewGameForm())
            {

                if (frm.ShowDialog() == DialogResult.OK)
                {

                    // Check if there is a games folder, if not create it
                    if (!Directory.Exists(Application.StartupPath + @"\Games\" + frm.GameName))
                        Directory.CreateDirectory(Application.StartupPath + @"\Games\" + frm.GameName);

                    // Check if there is a stats folder, if not create it
                    if (!Directory.Exists(Application.StartupPath + @"\Games\" + frm.GameName + @"\stats"))
                        Directory.CreateDirectory(Application.StartupPath + @"\Games\" + frm.GameName + @"\stats");
                    
                    // Check if there is a races folder, if not create it
                    if (!Directory.Exists(Application.StartupPath + @"\Games\" + frm.GameName + @"\races"))
                        Directory.CreateDirectory(Application.StartupPath + @"\Games\" + frm.GameName + @"\races");

                    // Check if there is a classes folder, if not create it
                    if (!Directory.Exists(Application.StartupPath + @"\Games\" + frm.GameName + @"\classes"))
                        Directory.CreateDirectory(Application.StartupPath + @"\Games\" + frm.GameName + @"\classes");
                
                    // Check if there is a entities folder, if not create it
                    if (!Directory.Exists(Application.StartupPath + @"\Games\" + frm.GameName + @"\entities"))
                         Directory.CreateDirectory(Application.StartupPath + @"\Games\" + frm.GameName + @"\entities");

                    // Check if there is a skills folder, if not create it
                    if (!Directory.Exists(Application.StartupPath + @"\Games\" + frm.GameName + @"\skills"))
                        Directory.CreateDirectory(Application.StartupPath + @"\Games\" + frm.GameName + @"\skills");

                    _game = new RPGGame(frm.GameName, frm.GameDescription);
                                   
                    XmlSerializer serializer = new XmlSerializer(typeof(RPGGame));
                    FileStream stream = new FileStream(Application.StartupPath + @"\Games\" + _game.GameName + @"\" + _game.GameName + ".gdf", FileMode.Create);

                    serializer.Serialize(stream, _game);

                    stream.Close();

                    //enable stats menu and button for now since 
                    //it's the only one that doesn't have a pre-requisite
                    tbStats.Enabled = true;
                    mnuStats.Enabled = true;

                    mnuClasses.Enabled = false;
                    tbClasses.Enabled = false;

                    mnuRaces.Enabled = false;
                    tbRaces.Enabled = false;

                    mnuEntities.Enabled = false;
                    tbEntities.Enabled = false;

                    mnuSkills.Enabled = false;
                    tbSkills.Enabled = false;
                }
            }
        }

        private void OpenGame(object sender, EventArgs e)
        {
            using (OpenGameForm frm = new OpenGameForm())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {

                    if (_game == null)
                        _game = new RPGGame();

                    _game.GameName = frm.GameName;
                    _game.Description = frm.GameDescription;

                    this.Text = this.Tag + (" - " + frm.GameName);
                    
                    mnuStats.Enabled = true;
                    tbStats.Enabled = true;

                    bool classesLoaded = false;
                    bool racesLoaded = false;
                    bool statsLoaded = false;

                    // Check the game folder to see what exists and enable buttons

                    if (Directory.GetFiles(Application.StartupPath + @"\Games\" + _game.GameName + @"\stats").Length > 0)
                    {

                        // If stats are there, enable races and classes
                        mnuClasses.Enabled = true;
                        tbClasses.Enabled = true;

                        mnuRaces.Enabled = true;
                        tbRaces.Enabled = true;

                        statsLoaded = true;
                    }
                    else
                    {
                        mnuClasses.Enabled = false;
                        tbClasses.Enabled = false;

                        mnuRaces.Enabled = false;
                        tbRaces.Enabled = false;

                        statsLoaded = false;
                    }

                    if (Directory.GetFiles(Application.StartupPath + @"\Games\" + _game.GameName + @"\races").Length > 0)
                    {
                        mnuRaces.Enabled = true;
                        tbRaces.Enabled = true;

                        racesLoaded = true;
                    }
                    else
                    {


                        racesLoaded = false;
                    }

                    if (Directory.GetFiles(Application.StartupPath + @"\Games\" + _game.GameName + @"\classes").Length > 0)
                    {
                        mnuClasses.Enabled = true;
                        tbClasses.Enabled = true;

                        classesLoaded = true;
                    }
                    else
                    {

                        classesLoaded = false;
                    }

                    if (Directory.GetFiles(Application.StartupPath + @"\Games\" + _game.GameName + @"\entities").Length > 0 ||
                        (classesLoaded && racesLoaded && statsLoaded))
                    {
                        mnuEntities.Enabled = true;
                        tbEntities.Enabled = true;
                    }
                    else
                    {
                    }

                    if (Directory.GetFiles(Application.StartupPath + @"\Games\" + _game.GameName + @"\skills").Length > 0 ||
                        (classesLoaded && racesLoaded && statsLoaded))
                    {
                        mnuSkills.Enabled = true;
                        tbSkills.Enabled = true;
                    }
                    else
                    {
                    }

                }
            }
        }

        private BaseForm GetChildForm(string name)
        {
            foreach (Form child in this.MdiChildren)
                if (child.Name == name)
                    return (BaseForm)child;

            return null;
        }


        private void ShowStatsForm(object sender, EventArgs e)
        {

            BaseForm frm = GetChildForm("StatsForm");

            if (frm == null)
            {
                frm = new StatsForm(_game.GameName);
                frm.MdiParent = this;
                frm.Show();
            }
            else
                frm.Activate();
        }

        private void ShowRacesForm(object sender, EventArgs e)
        {

            BaseForm frm = GetChildForm("RacesForm");

            if (frm == null)
            {
                frm = new RacesForm(_game.GameName);
                frm.MdiParent = this;
                frm.Show();
            }
            else
                frm.Activate();
        }

        private void ShowClassesForm(object sender, EventArgs e)
        {

            BaseForm frm = GetChildForm("ClassesForm");

            if (frm == null)
            {
                frm = new ClassesForm(_game.GameName);
                frm.MdiParent = this;
                frm.Show();
            }
            else
                frm.Activate();
        }

        private void ShowEntitiesForm(object sender, EventArgs e)
        {

            BaseForm frm = GetChildForm("EntitiesForm");

            if (frm == null)
            {
                frm = new EntitiesForm(_game.GameName);
                frm.MdiParent = this;
                frm.Show();
            }
            else
                frm.Activate();
        }

        private void ShowSkillsForm(object sender, EventArgs e)
        {

            BaseForm frm = GetChildForm("SkillsForm");

            if (frm == null)
            {
                frm = new SkillsForm(_game.GameName);
                frm.MdiParent = this;
                frm.Show();
            }
            else
                frm.Activate();
        }
    }
}
