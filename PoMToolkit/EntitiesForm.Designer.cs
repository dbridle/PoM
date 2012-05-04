namespace PoMToolkit
{
    partial class EntitiesForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.cbEntities = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.cbClass = new System.Windows.Forms.ComboBox();
            this.cbAlignment = new System.Windows.Forms.ComboBox();
            this.cbRace = new System.Windows.Forms.ComboBox();
            this.cbStats = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtLevel = new System.Windows.Forms.TextBox();
            this.txtExperience = new System.Windows.Forms.TextBox();
            this.txtBaseHP = new System.Windows.Forms.TextBox();
            this.txtCurHP = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.btnRandAmt = new System.Windows.Forms.Button();
            this.rbSexMale = new System.Windows.Forms.RadioButton();
            this.rbSexFemale = new System.Windows.Forms.RadioButton();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.cbDefensiveBonuses = new System.Windows.Forms.ComboBox();
            this.cbOffensiveBonuses = new System.Windows.Forms.ComboBox();
            this.cbMiscBonuses = new System.Windows.Forms.ComboBox();
            this.cbDamageResistance = new System.Windows.Forms.ComboBox();
            this.cbDamageWeakness = new System.Windows.Forms.ComboBox();
            this.btnDefensiveBonuses = new System.Windows.Forms.Button();
            this.btnOffensiveBonuses = new System.Windows.Forms.Button();
            this.btnMiscBonuses = new System.Windows.Forms.Button();
            this.btnDamageResistance = new System.Windows.Forms.Button();
            this.btnDamageWeakness = new System.Windows.Forms.Button();
            this.txtPortraitFilename = new System.Windows.Forms.TextBox();
            this.chkVendor = new System.Windows.Forms.CheckBox();
            this.txtSpriteFilename = new System.Windows.Forms.TextBox();
            this.btnSpriteFilename = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnPortraitFilename = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.cbSkills = new System.Windows.Forms.ComboBox();
            this.btnSkills = new System.Windows.Forms.Button();
            this.btnStats = new System.Windows.Forms.Button();
            this.txtCurSP = new System.Windows.Forms.TextBox();
            this.txtBaseSP = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuLoad,
            this.mnuSave});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(850, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuLoad
            // 
            this.mnuLoad.Name = "mnuLoad";
            this.mnuLoad.Size = new System.Drawing.Size(45, 20);
            this.mnuLoad.Text = "&Load";
            this.mnuLoad.Click += new System.EventHandler(this.mnuLoad_Click);
            // 
            // mnuSave
            // 
            this.mnuSave.Name = "mnuSave";
            this.mnuSave.Size = new System.Drawing.Size(43, 20);
            this.mnuSave.Text = "&Save";
            this.mnuSave.Click += new System.EventHandler(this.mnuSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(315, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Entities";
            // 
            // cbEntities
            // 
            this.cbEntities.FormattingEnabled = true;
            this.cbEntities.Location = new System.Drawing.Point(390, 52);
            this.cbEntities.Name = "cbEntities";
            this.cbEntities.Size = new System.Drawing.Size(173, 21);
            this.cbEntities.TabIndex = 2;
            this.cbEntities.SelectedIndexChanged += new System.EventHandler(this.cbEntities_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Class";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Level";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Experience";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(63, 266);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Alignment";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(63, 296);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Race";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(63, 326);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Stats";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(63, 356);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Base/Cur HP";
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(171, 113);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(140, 21);
            this.cbType.TabIndex = 12;
            // 
            // cbClass
            // 
            this.cbClass.FormattingEnabled = true;
            this.cbClass.Location = new System.Drawing.Point(171, 173);
            this.cbClass.Name = "cbClass";
            this.cbClass.Size = new System.Drawing.Size(140, 21);
            this.cbClass.TabIndex = 13;
            // 
            // cbAlignment
            // 
            this.cbAlignment.FormattingEnabled = true;
            this.cbAlignment.Location = new System.Drawing.Point(171, 263);
            this.cbAlignment.Name = "cbAlignment";
            this.cbAlignment.Size = new System.Drawing.Size(140, 21);
            this.cbAlignment.TabIndex = 14;
            // 
            // cbRace
            // 
            this.cbRace.FormattingEnabled = true;
            this.cbRace.Location = new System.Drawing.Point(171, 293);
            this.cbRace.Name = "cbRace";
            this.cbRace.Size = new System.Drawing.Size(140, 21);
            this.cbRace.TabIndex = 15;
            // 
            // cbStats
            // 
            this.cbStats.FormattingEnabled = true;
            this.cbStats.Location = new System.Drawing.Point(171, 323);
            this.cbStats.Name = "cbStats";
            this.cbStats.Size = new System.Drawing.Size(140, 21);
            this.cbStats.TabIndex = 16;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(171, 143);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(140, 20);
            this.txtName.TabIndex = 17;
            // 
            // txtLevel
            // 
            this.txtLevel.Location = new System.Drawing.Point(171, 203);
            this.txtLevel.Name = "txtLevel";
            this.txtLevel.Size = new System.Drawing.Size(140, 20);
            this.txtLevel.TabIndex = 18;
            // 
            // txtExperience
            // 
            this.txtExperience.Location = new System.Drawing.Point(171, 233);
            this.txtExperience.Name = "txtExperience";
            this.txtExperience.Size = new System.Drawing.Size(140, 20);
            this.txtExperience.TabIndex = 19;
            // 
            // txtBaseHP
            // 
            this.txtBaseHP.Location = new System.Drawing.Point(171, 353);
            this.txtBaseHP.Name = "txtBaseHP";
            this.txtBaseHP.Size = new System.Drawing.Size(64, 20);
            this.txtBaseHP.TabIndex = 20;
            // 
            // txtCurHP
            // 
            this.txtCurHP.Location = new System.Drawing.Point(247, 353);
            this.txtCurHP.Name = "txtCurHP";
            this.txtCurHP.Size = new System.Drawing.Size(64, 20);
            this.txtCurHP.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(422, 356);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "Vendor";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(422, 326);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 13);
            this.label12.TabIndex = 29;
            this.label12.Text = "Portrait Filename";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(422, 296);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "Damage Weakness";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(422, 266);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(103, 13);
            this.label14.TabIndex = 27;
            this.label14.Text = "Damage Resistance";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(422, 236);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(70, 13);
            this.label15.TabIndex = 26;
            this.label15.Text = "MiscBonuses";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(422, 206);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(96, 13);
            this.label16.TabIndex = 25;
            this.label16.Text = "Offensive Bonuses";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(422, 176);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(99, 13);
            this.label17.TabIndex = 24;
            this.label17.Text = "Defensive Bonuses";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(422, 146);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(26, 13);
            this.label18.TabIndex = 23;
            this.label18.Text = "Age";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(422, 116);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(25, 13);
            this.label19.TabIndex = 22;
            this.label19.Text = "Sex";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(422, 386);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(79, 13);
            this.label20.TabIndex = 31;
            this.label20.Text = "Sprite Filename";
            // 
            // btnRandAmt
            // 
            this.btnRandAmt.Location = new System.Drawing.Point(318, 231);
            this.btnRandAmt.Name = "btnRandAmt";
            this.btnRandAmt.Size = new System.Drawing.Size(75, 23);
            this.btnRandAmt.TabIndex = 32;
            this.btnRandAmt.Text = "Rand Amt";
            this.btnRandAmt.UseVisualStyleBackColor = true;
            this.btnRandAmt.Click += new System.EventHandler(this.btnRandAmt_Click);
            // 
            // rbSexMale
            // 
            this.rbSexMale.AutoSize = true;
            this.rbSexMale.Location = new System.Drawing.Point(559, 114);
            this.rbSexMale.Name = "rbSexMale";
            this.rbSexMale.Size = new System.Drawing.Size(48, 17);
            this.rbSexMale.TabIndex = 33;
            this.rbSexMale.TabStop = true;
            this.rbSexMale.Text = "Male";
            this.rbSexMale.UseVisualStyleBackColor = true;
            // 
            // rbSexFemale
            // 
            this.rbSexFemale.AutoSize = true;
            this.rbSexFemale.Location = new System.Drawing.Point(630, 114);
            this.rbSexFemale.Name = "rbSexFemale";
            this.rbSexFemale.Size = new System.Drawing.Size(59, 17);
            this.rbSexFemale.TabIndex = 34;
            this.rbSexFemale.TabStop = true;
            this.rbSexFemale.Text = "Female";
            this.rbSexFemale.UseVisualStyleBackColor = true;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(559, 143);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 20);
            this.txtAge.TabIndex = 35;
            // 
            // cbDefensiveBonuses
            // 
            this.cbDefensiveBonuses.FormattingEnabled = true;
            this.cbDefensiveBonuses.Location = new System.Drawing.Point(559, 173);
            this.cbDefensiveBonuses.Name = "cbDefensiveBonuses";
            this.cbDefensiveBonuses.Size = new System.Drawing.Size(190, 21);
            this.cbDefensiveBonuses.TabIndex = 36;
            // 
            // cbOffensiveBonuses
            // 
            this.cbOffensiveBonuses.FormattingEnabled = true;
            this.cbOffensiveBonuses.Location = new System.Drawing.Point(559, 203);
            this.cbOffensiveBonuses.Name = "cbOffensiveBonuses";
            this.cbOffensiveBonuses.Size = new System.Drawing.Size(190, 21);
            this.cbOffensiveBonuses.TabIndex = 37;
            // 
            // cbMiscBonuses
            // 
            this.cbMiscBonuses.FormattingEnabled = true;
            this.cbMiscBonuses.Location = new System.Drawing.Point(559, 232);
            this.cbMiscBonuses.Name = "cbMiscBonuses";
            this.cbMiscBonuses.Size = new System.Drawing.Size(190, 21);
            this.cbMiscBonuses.TabIndex = 38;
            // 
            // cbDamageResistance
            // 
            this.cbDamageResistance.FormattingEnabled = true;
            this.cbDamageResistance.Location = new System.Drawing.Point(559, 263);
            this.cbDamageResistance.Name = "cbDamageResistance";
            this.cbDamageResistance.Size = new System.Drawing.Size(190, 21);
            this.cbDamageResistance.TabIndex = 39;
            // 
            // cbDamageWeakness
            // 
            this.cbDamageWeakness.FormattingEnabled = true;
            this.cbDamageWeakness.Location = new System.Drawing.Point(559, 293);
            this.cbDamageWeakness.Name = "cbDamageWeakness";
            this.cbDamageWeakness.Size = new System.Drawing.Size(190, 21);
            this.cbDamageWeakness.TabIndex = 40;
            // 
            // btnDefensiveBonuses
            // 
            this.btnDefensiveBonuses.Location = new System.Drawing.Point(767, 171);
            this.btnDefensiveBonuses.Name = "btnDefensiveBonuses";
            this.btnDefensiveBonuses.Size = new System.Drawing.Size(35, 23);
            this.btnDefensiveBonuses.TabIndex = 41;
            this.btnDefensiveBonuses.Text = "...";
            this.btnDefensiveBonuses.UseVisualStyleBackColor = true;
            this.btnDefensiveBonuses.Click += new System.EventHandler(this.btnDefensiveBonuses_Click);
            // 
            // btnOffensiveBonuses
            // 
            this.btnOffensiveBonuses.Location = new System.Drawing.Point(767, 201);
            this.btnOffensiveBonuses.Name = "btnOffensiveBonuses";
            this.btnOffensiveBonuses.Size = new System.Drawing.Size(35, 23);
            this.btnOffensiveBonuses.TabIndex = 42;
            this.btnOffensiveBonuses.Text = "...";
            this.btnOffensiveBonuses.UseVisualStyleBackColor = true;
            this.btnOffensiveBonuses.Click += new System.EventHandler(this.btnOffensiveBonuses_Click);
            // 
            // btnMiscBonuses
            // 
            this.btnMiscBonuses.Location = new System.Drawing.Point(767, 231);
            this.btnMiscBonuses.Name = "btnMiscBonuses";
            this.btnMiscBonuses.Size = new System.Drawing.Size(35, 23);
            this.btnMiscBonuses.TabIndex = 43;
            this.btnMiscBonuses.Text = "...";
            this.btnMiscBonuses.UseVisualStyleBackColor = true;
            this.btnMiscBonuses.Click += new System.EventHandler(this.btnMiscBonuses_Click);
            // 
            // btnDamageResistance
            // 
            this.btnDamageResistance.Location = new System.Drawing.Point(767, 261);
            this.btnDamageResistance.Name = "btnDamageResistance";
            this.btnDamageResistance.Size = new System.Drawing.Size(35, 23);
            this.btnDamageResistance.TabIndex = 44;
            this.btnDamageResistance.Text = "...";
            this.btnDamageResistance.UseVisualStyleBackColor = true;
            this.btnDamageResistance.Click += new System.EventHandler(this.btnDamageResistance_Click);
            // 
            // btnDamageWeakness
            // 
            this.btnDamageWeakness.Location = new System.Drawing.Point(767, 291);
            this.btnDamageWeakness.Name = "btnDamageWeakness";
            this.btnDamageWeakness.Size = new System.Drawing.Size(35, 23);
            this.btnDamageWeakness.TabIndex = 45;
            this.btnDamageWeakness.Text = "...";
            this.btnDamageWeakness.UseVisualStyleBackColor = true;
            this.btnDamageWeakness.Click += new System.EventHandler(this.btnDamageWeakness_Click);
            // 
            // txtPortraitFilename
            // 
            this.txtPortraitFilename.Location = new System.Drawing.Point(559, 323);
            this.txtPortraitFilename.Name = "txtPortraitFilename";
            this.txtPortraitFilename.Size = new System.Drawing.Size(190, 20);
            this.txtPortraitFilename.TabIndex = 46;
            // 
            // chkVendor
            // 
            this.chkVendor.AutoSize = true;
            this.chkVendor.Location = new System.Drawing.Point(559, 355);
            this.chkVendor.Name = "chkVendor";
            this.chkVendor.Size = new System.Drawing.Size(60, 17);
            this.chkVendor.TabIndex = 47;
            this.chkVendor.Text = "Vendor";
            this.chkVendor.UseVisualStyleBackColor = true;
            // 
            // txtSpriteFilename
            // 
            this.txtSpriteFilename.Location = new System.Drawing.Point(559, 383);
            this.txtSpriteFilename.Name = "txtSpriteFilename";
            this.txtSpriteFilename.Size = new System.Drawing.Size(190, 20);
            this.txtSpriteFilename.TabIndex = 48;
            // 
            // btnSpriteFilename
            // 
            this.btnSpriteFilename.Location = new System.Drawing.Point(767, 381);
            this.btnSpriteFilename.Name = "btnSpriteFilename";
            this.btnSpriteFilename.Size = new System.Drawing.Size(35, 23);
            this.btnSpriteFilename.TabIndex = 49;
            this.btnSpriteFilename.Text = "...";
            this.btnSpriteFilename.UseVisualStyleBackColor = true;
            this.btnSpriteFilename.Click += new System.EventHandler(this.btnSpriteFilename_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(554, 453);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 54;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(472, 453);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 53;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(390, 453);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 52;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(308, 453);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 51;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(226, 453);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 50;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnPortraitFilename
            // 
            this.btnPortraitFilename.Location = new System.Drawing.Point(767, 321);
            this.btnPortraitFilename.Name = "btnPortraitFilename";
            this.btnPortraitFilename.Size = new System.Drawing.Size(35, 23);
            this.btnPortraitFilename.TabIndex = 55;
            this.btnPortraitFilename.Text = "...";
            this.btnPortraitFilename.UseVisualStyleBackColor = true;
            this.btnPortraitFilename.Click += new System.EventHandler(this.btnPortraitFilename_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(63, 415);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(31, 13);
            this.label21.TabIndex = 56;
            this.label21.Text = "Skills";
            // 
            // cbSkills
            // 
            this.cbSkills.FormattingEnabled = true;
            this.cbSkills.Location = new System.Drawing.Point(171, 412);
            this.cbSkills.Name = "cbSkills";
            this.cbSkills.Size = new System.Drawing.Size(140, 21);
            this.cbSkills.TabIndex = 57;
            // 
            // btnSkills
            // 
            this.btnSkills.Location = new System.Drawing.Point(317, 410);
            this.btnSkills.Name = "btnSkills";
            this.btnSkills.Size = new System.Drawing.Size(35, 23);
            this.btnSkills.TabIndex = 58;
            this.btnSkills.Text = "...";
            this.btnSkills.UseVisualStyleBackColor = true;
            this.btnSkills.Click += new System.EventHandler(this.btnSkills_Click);
            // 
            // btnStats
            // 
            this.btnStats.Location = new System.Drawing.Point(321, 321);
            this.btnStats.Name = "btnStats";
            this.btnStats.Size = new System.Drawing.Size(35, 23);
            this.btnStats.TabIndex = 59;
            this.btnStats.Text = "...";
            this.btnStats.UseVisualStyleBackColor = true;
            this.btnStats.Click += new System.EventHandler(this.btnStats_Click);
            // 
            // txtCurSP
            // 
            this.txtCurSP.Location = new System.Drawing.Point(247, 383);
            this.txtCurSP.Name = "txtCurSP";
            this.txtCurSP.Size = new System.Drawing.Size(64, 20);
            this.txtCurSP.TabIndex = 62;
            // 
            // txtBaseSP
            // 
            this.txtBaseSP.Location = new System.Drawing.Point(171, 383);
            this.txtBaseSP.Name = "txtBaseSP";
            this.txtBaseSP.Size = new System.Drawing.Size(64, 20);
            this.txtBaseSP.TabIndex = 61;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(63, 386);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(69, 13);
            this.label22.TabIndex = 60;
            this.label22.Text = "Base/Cur SP";
            // 
            // EntitiesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 483);
            this.Controls.Add(this.txtCurSP);
            this.Controls.Add(this.txtBaseSP);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.btnStats);
            this.Controls.Add(this.btnSkills);
            this.Controls.Add(this.cbSkills);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.btnPortraitFilename);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSpriteFilename);
            this.Controls.Add(this.txtSpriteFilename);
            this.Controls.Add(this.chkVendor);
            this.Controls.Add(this.txtPortraitFilename);
            this.Controls.Add(this.btnDamageWeakness);
            this.Controls.Add(this.btnDamageResistance);
            this.Controls.Add(this.btnMiscBonuses);
            this.Controls.Add(this.btnOffensiveBonuses);
            this.Controls.Add(this.btnDefensiveBonuses);
            this.Controls.Add(this.cbDamageWeakness);
            this.Controls.Add(this.cbDamageResistance);
            this.Controls.Add(this.cbMiscBonuses);
            this.Controls.Add(this.cbOffensiveBonuses);
            this.Controls.Add(this.cbDefensiveBonuses);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.rbSexFemale);
            this.Controls.Add(this.rbSexMale);
            this.Controls.Add(this.btnRandAmt);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtCurHP);
            this.Controls.Add(this.txtBaseHP);
            this.Controls.Add(this.txtExperience);
            this.Controls.Add(this.txtLevel);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.cbStats);
            this.Controls.Add(this.cbRace);
            this.Controls.Add(this.cbAlignment);
            this.Controls.Add(this.cbClass);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbEntities);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "EntitiesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Entities";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EntitiesForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuLoad;
        private System.Windows.Forms.ToolStripMenuItem mnuSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbEntities;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.ComboBox cbClass;
        private System.Windows.Forms.ComboBox cbAlignment;
        private System.Windows.Forms.ComboBox cbRace;
        private System.Windows.Forms.ComboBox cbStats;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtLevel;
        private System.Windows.Forms.TextBox txtExperience;
        private System.Windows.Forms.TextBox txtBaseHP;
        private System.Windows.Forms.TextBox txtCurHP;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnRandAmt;
        private System.Windows.Forms.RadioButton rbSexMale;
        private System.Windows.Forms.RadioButton rbSexFemale;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.ComboBox cbDefensiveBonuses;
        private System.Windows.Forms.ComboBox cbOffensiveBonuses;
        private System.Windows.Forms.ComboBox cbMiscBonuses;
        private System.Windows.Forms.ComboBox cbDamageResistance;
        private System.Windows.Forms.ComboBox cbDamageWeakness;
        private System.Windows.Forms.Button btnDefensiveBonuses;
        private System.Windows.Forms.Button btnOffensiveBonuses;
        private System.Windows.Forms.Button btnMiscBonuses;
        private System.Windows.Forms.Button btnDamageResistance;
        private System.Windows.Forms.Button btnDamageWeakness;
        private System.Windows.Forms.TextBox txtPortraitFilename;
        private System.Windows.Forms.CheckBox chkVendor;
        private System.Windows.Forms.TextBox txtSpriteFilename;
        private System.Windows.Forms.Button btnSpriteFilename;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnPortraitFilename;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox cbSkills;
        private System.Windows.Forms.Button btnSkills;
        private System.Windows.Forms.Button btnStats;
        private System.Windows.Forms.TextBox txtCurSP;
        private System.Windows.Forms.TextBox txtBaseSP;
        private System.Windows.Forms.Label label22;
    }
}