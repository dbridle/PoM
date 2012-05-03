namespace PoMToolkit
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNewGame = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStats = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRaces = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuClasses = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEntities = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tbStats = new System.Windows.Forms.ToolStripButton();
            this.tbRaces = new System.Windows.Forms.ToolStripButton();
            this.tbClasses = new System.Windows.Forms.ToolStripButton();
            this.tbEntity = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.mnuStats,
            this.mnuRaces,
            this.mnuClasses,
            this.mnuEntities});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(804, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNewGame,
            this.openToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameToolStripMenuItem.Text = "&Game";
            // 
            // mnuNewGame
            // 
            this.mnuNewGame.Name = "mnuNewGame";
            this.mnuNewGame.Size = new System.Drawing.Size(103, 22);
            this.mnuNewGame.Text = "New";
            this.mnuNewGame.Click += new System.EventHandler(this.NewGame);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenGame);
            // 
            // mnuStats
            // 
            this.mnuStats.Enabled = false;
            this.mnuStats.Name = "mnuStats";
            this.mnuStats.Size = new System.Drawing.Size(44, 20);
            this.mnuStats.Text = "&Stats";
            this.mnuStats.Click += new System.EventHandler(this.ShowStatsForm);
            // 
            // mnuRaces
            // 
            this.mnuRaces.Enabled = false;
            this.mnuRaces.Name = "mnuRaces";
            this.mnuRaces.Size = new System.Drawing.Size(49, 20);
            this.mnuRaces.Text = "&Races";
            this.mnuRaces.Click += new System.EventHandler(this.ShowRacesForm);
            // 
            // mnuClasses
            // 
            this.mnuClasses.Enabled = false;
            this.mnuClasses.Name = "mnuClasses";
            this.mnuClasses.Size = new System.Drawing.Size(57, 20);
            this.mnuClasses.Text = "&Classes";
            this.mnuClasses.Click += new System.EventHandler(this.ShowClassesForm);
            // 
            // mnuEntities
            // 
            this.mnuEntities.Enabled = false;
            this.mnuEntities.Name = "mnuEntities";
            this.mnuEntities.Size = new System.Drawing.Size(57, 20);
            this.mnuEntities.Text = "Entities";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripSeparator1,
            this.tbStats,
            this.tbRaces,
            this.tbClasses,
            this.tbEntity});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(804, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "New Game";
            this.toolStripButton1.Click += new System.EventHandler(this.NewGame);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Open Game";
            this.toolStripButton2.Click += new System.EventHandler(this.OpenGame);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tbStats
            // 
            this.tbStats.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbStats.Enabled = false;
            this.tbStats.Image = ((System.Drawing.Image)(resources.GetObject("tbStats.Image")));
            this.tbStats.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbStats.Name = "tbStats";
            this.tbStats.Size = new System.Drawing.Size(23, 22);
            this.tbStats.Text = "Stats";
            this.tbStats.Click += new System.EventHandler(this.ShowStatsForm);
            // 
            // tbRaces
            // 
            this.tbRaces.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbRaces.Enabled = false;
            this.tbRaces.Image = ((System.Drawing.Image)(resources.GetObject("tbRaces.Image")));
            this.tbRaces.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbRaces.Name = "tbRaces";
            this.tbRaces.Size = new System.Drawing.Size(23, 22);
            this.tbRaces.Text = "toolStripButton4";
            this.tbRaces.Click += new System.EventHandler(this.ShowRacesForm);
            // 
            // tbClasses
            // 
            this.tbClasses.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbClasses.Enabled = false;
            this.tbClasses.Image = ((System.Drawing.Image)(resources.GetObject("tbClasses.Image")));
            this.tbClasses.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbClasses.Name = "tbClasses";
            this.tbClasses.Size = new System.Drawing.Size(23, 22);
            this.tbClasses.Text = "toolStripButton3";
            this.tbClasses.Click += new System.EventHandler(this.ShowClassesForm);
            // 
            // tbEntity
            // 
            this.tbEntity.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbEntity.Enabled = false;
            this.tbEntity.Image = ((System.Drawing.Image)(resources.GetObject("tbEntity.Image")));
            this.tbEntity.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbEntity.Name = "tbEntity";
            this.tbEntity.Size = new System.Drawing.Size(23, 22);
            this.tbEntity.Text = "toolStripButton3";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 489);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "PoM Toolkit";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuNewGame;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripMenuItem mnuStats;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tbStats;
        private System.Windows.Forms.ToolStripButton tbRaces;
        private System.Windows.Forms.ToolStripButton tbClasses;
        private System.Windows.Forms.ToolStripButton tbEntity;
        private System.Windows.Forms.ToolStripMenuItem mnuRaces;
        private System.Windows.Forms.ToolStripMenuItem mnuClasses;
        private System.Windows.Forms.ToolStripMenuItem mnuEntities;
    }
}