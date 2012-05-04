namespace PoMToolkit
{
    partial class SkillsForm
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
            this.label20 = new System.Windows.Forms.Label();
            this.cboOpposingSkill = new System.Windows.Forms.ComboBox();
            this.btnSelectIcon = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.txtIcon = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.chkAlwaysOn = new System.Windows.Forms.CheckBox();
            this.Label14 = new System.Windows.Forms.Label();
            this.cboSkills = new System.Windows.Forms.ComboBox();
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.TabPage3 = new System.Windows.Forms.TabPage();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.btnDelCost = new System.Windows.Forms.Button();
            this.Label19 = new System.Windows.Forms.Label();
            this.lstCostClasses = new System.Windows.Forms.ListBox();
            this.btnAddCost = new System.Windows.Forms.Button();
            this.lstSkillCosts = new System.Windows.Forms.ListBox();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.lstClassBonus = new System.Windows.Forms.ListBox();
            this.btnDelClassBonus = new System.Windows.Forms.Button();
            this.Label18 = new System.Windows.Forms.Label();
            this.Label13 = new System.Windows.Forms.Label();
            this.btnAddClassBonus = new System.Windows.Forms.Button();
            this.txtClassBonus = new System.Windows.Forms.TextBox();
            this.lstClassBonuses = new System.Windows.Forms.ListBox();
            this.TabPage2 = new System.Windows.Forms.TabPage();
            this.txtMaxLevel = new System.Windows.Forms.TextBox();
            this.txtMinLevel = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnDelLevelBonus = new System.Windows.Forms.Button();
            this.Label9 = new System.Windows.Forms.Label();
            this.btnAddLevelBonus = new System.Windows.Forms.Button();
            this.txtLevelBonus = new System.Windows.Forms.TextBox();
            this.lstLevelBonuses = new System.Windows.Forms.ListBox();
            this.TabPage4 = new System.Windows.Forms.TabPage();
            this.lstRaceBonus = new System.Windows.Forms.ListBox();
            this.btnDelRaceBonus = new System.Windows.Forms.Button();
            this.Label16 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.btnAddRaceBonus = new System.Windows.Forms.Button();
            this.txtRaceBonus = new System.Windows.Forms.TextBox();
            this.lstRaceBonuses = new System.Windows.Forms.ListBox();
            this.TabPage5 = new System.Windows.Forms.TabPage();
            this.lstStatBonus = new System.Windows.Forms.ListBox();
            this.btnDelStatBonus = new System.Windows.Forms.Button();
            this.Label17 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.btnAddStatBonus = new System.Windows.Forms.Button();
            this.txtStatBonus = new System.Windows.Forms.TextBox();
            this.txtStatMaxVal = new System.Windows.Forms.TextBox();
            this.txtStatMinVal = new System.Windows.Forms.TextBox();
            this.lstStatBonuses = new System.Windows.Forms.ListBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.TabControl1.SuspendLayout();
            this.TabPage3.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.TabPage2.SuspendLayout();
            this.TabPage4.SuspendLayout();
            this.TabPage5.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label20
            // 
            this.label20.Location = new System.Drawing.Point(12, 149);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(80, 16);
            this.label20.TabIndex = 142;
            this.label20.Text = "Opposing Skill:";
            // 
            // cboOpposingSkill
            // 
            this.cboOpposingSkill.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOpposingSkill.Location = new System.Drawing.Point(95, 149);
            this.cboOpposingSkill.Name = "cboOpposingSkill";
            this.cboOpposingSkill.Size = new System.Drawing.Size(152, 21);
            this.cboOpposingSkill.TabIndex = 141;
            // 
            // btnSelectIcon
            // 
            this.btnSelectIcon.Location = new System.Drawing.Point(220, 199);
            this.btnSelectIcon.Name = "btnSelectIcon";
            this.btnSelectIcon.Size = new System.Drawing.Size(27, 23);
            this.btnSelectIcon.TabIndex = 140;
            this.btnSelectIcon.Text = "...";
            this.btnSelectIcon.Click += new System.EventHandler(this.btnSelectIcon_Click_1);
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(12, 199);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 16);
            this.label15.TabIndex = 139;
            this.label15.Text = "Icon:";
            // 
            // txtIcon
            // 
            this.txtIcon.Location = new System.Drawing.Point(95, 199);
            this.txtIcon.Name = "txtIcon";
            this.txtIcon.Size = new System.Drawing.Size(119, 20);
            this.txtIcon.TabIndex = 138;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 176);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 13);
            this.label12.TabIndex = 137;
            this.label12.Text = "Always On?:";
            // 
            // chkAlwaysOn
            // 
            this.chkAlwaysOn.Location = new System.Drawing.Point(95, 171);
            this.chkAlwaysOn.Name = "chkAlwaysOn";
            this.chkAlwaysOn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkAlwaysOn.Size = new System.Drawing.Size(16, 24);
            this.chkAlwaysOn.TabIndex = 136;
            this.chkAlwaysOn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label14
            // 
            this.Label14.Location = new System.Drawing.Point(12, 35);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(40, 16);
            this.Label14.TabIndex = 135;
            this.Label14.Text = "Skills:";
            // 
            // cboSkills
            // 
            this.cboSkills.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSkills.Location = new System.Drawing.Point(95, 35);
            this.cboSkills.Name = "cboSkills";
            this.cboSkills.Size = new System.Drawing.Size(152, 21);
            this.cboSkills.TabIndex = 134;
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.TabPage3);
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Controls.Add(this.TabPage2);
            this.TabControl1.Controls.Add(this.TabPage4);
            this.TabControl1.Controls.Add(this.TabPage5);
            this.TabControl1.Location = new System.Drawing.Point(24, 234);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(400, 256);
            this.TabControl1.TabIndex = 133;
            // 
            // TabPage3
            // 
            this.TabPage3.Controls.Add(this.Label1);
            this.TabPage3.Controls.Add(this.txtCost);
            this.TabPage3.Controls.Add(this.btnDelCost);
            this.TabPage3.Controls.Add(this.Label19);
            this.TabPage3.Controls.Add(this.lstCostClasses);
            this.TabPage3.Controls.Add(this.btnAddCost);
            this.TabPage3.Controls.Add(this.lstSkillCosts);
            this.TabPage3.Location = new System.Drawing.Point(4, 22);
            this.TabPage3.Name = "TabPage3";
            this.TabPage3.Size = new System.Drawing.Size(392, 230);
            this.TabPage3.TabIndex = 5;
            this.TabPage3.Text = "Skill Costs";
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(3, 157);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(40, 16);
            this.Label1.TabIndex = 69;
            this.Label1.Text = "Value:";
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(67, 157);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(112, 20);
            this.txtCost.TabIndex = 68;
            this.txtCost.TextChanged += new System.EventHandler(this.CheckSkillCostSelection);
            // 
            // btnDelCost
            // 
            this.btnDelCost.Enabled = false;
            this.btnDelCost.Location = new System.Drawing.Point(263, 192);
            this.btnDelCost.Name = "btnDelCost";
            this.btnDelCost.Size = new System.Drawing.Size(75, 23);
            this.btnDelCost.TabIndex = 80;
            this.btnDelCost.Text = "Delete";
            this.btnDelCost.Click += new System.EventHandler(this.btnDelCost_Click_1);
            // 
            // Label19
            // 
            this.Label19.Location = new System.Drawing.Point(3, 16);
            this.Label19.Name = "Label19";
            this.Label19.Size = new System.Drawing.Size(40, 16);
            this.Label19.TabIndex = 78;
            this.Label19.Text = "Class:";
            // 
            // lstCostClasses
            // 
            this.lstCostClasses.Location = new System.Drawing.Point(67, 8);
            this.lstCostClasses.Name = "lstCostClasses";
            this.lstCostClasses.Size = new System.Drawing.Size(112, 134);
            this.lstCostClasses.TabIndex = 81;
            // 
            // btnAddCost
            // 
            this.btnAddCost.Location = new System.Drawing.Point(81, 192);
            this.btnAddCost.Name = "btnAddCost";
            this.btnAddCost.Size = new System.Drawing.Size(75, 23);
            this.btnAddCost.TabIndex = 79;
            this.btnAddCost.Text = "Add";
            this.btnAddCost.Click += new System.EventHandler(this.btnAddCost_Click_1);
            // 
            // lstSkillCosts
            // 
            this.lstSkillCosts.Location = new System.Drawing.Point(231, 8);
            this.lstSkillCosts.Name = "lstSkillCosts";
            this.lstSkillCosts.Size = new System.Drawing.Size(144, 173);
            this.lstSkillCosts.TabIndex = 82;
            // 
            // TabPage1
            // 
            this.TabPage1.Controls.Add(this.lstClassBonus);
            this.TabPage1.Controls.Add(this.btnDelClassBonus);
            this.TabPage1.Controls.Add(this.Label18);
            this.TabPage1.Controls.Add(this.Label13);
            this.TabPage1.Controls.Add(this.btnAddClassBonus);
            this.TabPage1.Controls.Add(this.txtClassBonus);
            this.TabPage1.Controls.Add(this.lstClassBonuses);
            this.TabPage1.Location = new System.Drawing.Point(4, 22);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Size = new System.Drawing.Size(392, 230);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "Class Bonuses";
            this.TabPage1.Visible = false;
            // 
            // lstClassBonus
            // 
            this.lstClassBonus.Location = new System.Drawing.Point(67, 10);
            this.lstClassBonus.Name = "lstClassBonus";
            this.lstClassBonus.Size = new System.Drawing.Size(112, 147);
            this.lstClassBonus.TabIndex = 82;
            // 
            // btnDelClassBonus
            // 
            this.btnDelClassBonus.Enabled = false;
            this.btnDelClassBonus.Location = new System.Drawing.Point(263, 194);
            this.btnDelClassBonus.Name = "btnDelClassBonus";
            this.btnDelClassBonus.Size = new System.Drawing.Size(75, 23);
            this.btnDelClassBonus.TabIndex = 77;
            this.btnDelClassBonus.Text = "Delete";
            this.btnDelClassBonus.Click += new System.EventHandler(this.btnDelClassBonus_Click);
            // 
            // Label18
            // 
            this.Label18.Location = new System.Drawing.Point(3, 18);
            this.Label18.Name = "Label18";
            this.Label18.Size = new System.Drawing.Size(48, 16);
            this.Label18.TabIndex = 76;
            this.Label18.Text = "Class:";
            // 
            // Label13
            // 
            this.Label13.Location = new System.Drawing.Point(3, 163);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(64, 16);
            this.Label13.TabIndex = 74;
            this.Label13.Text = "Bonus:";
            // 
            // btnAddClassBonus
            // 
            this.btnAddClassBonus.Enabled = false;
            this.btnAddClassBonus.Location = new System.Drawing.Point(83, 194);
            this.btnAddClassBonus.Name = "btnAddClassBonus";
            this.btnAddClassBonus.Size = new System.Drawing.Size(75, 23);
            this.btnAddClassBonus.TabIndex = 73;
            this.btnAddClassBonus.Text = "Add";
            this.btnAddClassBonus.Click += new System.EventHandler(this.btnAddClassBonus_Click_1);
            // 
            // txtClassBonus
            // 
            this.txtClassBonus.Location = new System.Drawing.Point(67, 163);
            this.txtClassBonus.Name = "txtClassBonus";
            this.txtClassBonus.Size = new System.Drawing.Size(112, 20);
            this.txtClassBonus.TabIndex = 72;
            this.txtClassBonus.TextChanged += new System.EventHandler(this.CheckClassBonusData);
            // 
            // lstClassBonuses
            // 
            this.lstClassBonuses.Location = new System.Drawing.Point(231, 10);
            this.lstClassBonuses.Name = "lstClassBonuses";
            this.lstClassBonuses.Size = new System.Drawing.Size(144, 173);
            this.lstClassBonuses.TabIndex = 0;
            // 
            // TabPage2
            // 
            this.TabPage2.Controls.Add(this.txtMaxLevel);
            this.TabPage2.Controls.Add(this.txtMinLevel);
            this.TabPage2.Controls.Add(this.label11);
            this.TabPage2.Controls.Add(this.label10);
            this.TabPage2.Controls.Add(this.btnDelLevelBonus);
            this.TabPage2.Controls.Add(this.Label9);
            this.TabPage2.Controls.Add(this.btnAddLevelBonus);
            this.TabPage2.Controls.Add(this.txtLevelBonus);
            this.TabPage2.Controls.Add(this.lstLevelBonuses);
            this.TabPage2.Location = new System.Drawing.Point(4, 22);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Size = new System.Drawing.Size(392, 230);
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "Level Bonuses";
            this.TabPage2.Visible = false;
            // 
            // txtMaxLevel
            // 
            this.txtMaxLevel.Location = new System.Drawing.Point(65, 61);
            this.txtMaxLevel.Name = "txtMaxLevel";
            this.txtMaxLevel.Size = new System.Drawing.Size(112, 20);
            this.txtMaxLevel.TabIndex = 81;
            this.txtMaxLevel.TextChanged += new System.EventHandler(this.CheckLevelBonusData);
            // 
            // txtMinLevel
            // 
            this.txtMinLevel.Location = new System.Drawing.Point(65, 30);
            this.txtMinLevel.Name = "txtMinLevel";
            this.txtMinLevel.Size = new System.Drawing.Size(112, 20);
            this.txtMinLevel.TabIndex = 80;
            this.txtMinLevel.TextChanged += new System.EventHandler(this.CheckLevelBonusData);
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(3, 64);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 16);
            this.label11.TabIndex = 79;
            this.label11.Text = "Max Level:";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(3, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 16);
            this.label10.TabIndex = 78;
            this.label10.Text = "Min Level:";
            // 
            // btnDelLevelBonus
            // 
            this.btnDelLevelBonus.Enabled = false;
            this.btnDelLevelBonus.Location = new System.Drawing.Point(263, 199);
            this.btnDelLevelBonus.Name = "btnDelLevelBonus";
            this.btnDelLevelBonus.Size = new System.Drawing.Size(75, 23);
            this.btnDelLevelBonus.TabIndex = 76;
            this.btnDelLevelBonus.Text = "Delete";
            this.btnDelLevelBonus.Click += new System.EventHandler(this.btnDelLevelBonus_Click_1);
            // 
            // Label9
            // 
            this.Label9.Location = new System.Drawing.Point(1, 97);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(64, 16);
            this.Label9.TabIndex = 75;
            this.Label9.Text = "Bonus:";
            // 
            // btnAddLevelBonus
            // 
            this.btnAddLevelBonus.Enabled = false;
            this.btnAddLevelBonus.Location = new System.Drawing.Point(89, 199);
            this.btnAddLevelBonus.Name = "btnAddLevelBonus";
            this.btnAddLevelBonus.Size = new System.Drawing.Size(75, 23);
            this.btnAddLevelBonus.TabIndex = 72;
            this.btnAddLevelBonus.Text = "Add";
            this.btnAddLevelBonus.Click += new System.EventHandler(this.btnAddLevelBonus_Click_1);
            // 
            // txtLevelBonus
            // 
            this.txtLevelBonus.Location = new System.Drawing.Point(65, 97);
            this.txtLevelBonus.Name = "txtLevelBonus";
            this.txtLevelBonus.Size = new System.Drawing.Size(112, 20);
            this.txtLevelBonus.TabIndex = 71;
            this.txtLevelBonus.TextChanged += new System.EventHandler(this.CheckLevelBonusData);
            // 
            // lstLevelBonuses
            // 
            this.lstLevelBonuses.Location = new System.Drawing.Point(231, 15);
            this.lstLevelBonuses.Name = "lstLevelBonuses";
            this.lstLevelBonuses.Size = new System.Drawing.Size(144, 147);
            this.lstLevelBonuses.TabIndex = 1;
            // 
            // TabPage4
            // 
            this.TabPage4.Controls.Add(this.lstRaceBonus);
            this.TabPage4.Controls.Add(this.btnDelRaceBonus);
            this.TabPage4.Controls.Add(this.Label16);
            this.TabPage4.Controls.Add(this.Label8);
            this.TabPage4.Controls.Add(this.btnAddRaceBonus);
            this.TabPage4.Controls.Add(this.txtRaceBonus);
            this.TabPage4.Controls.Add(this.lstRaceBonuses);
            this.TabPage4.Location = new System.Drawing.Point(4, 22);
            this.TabPage4.Name = "TabPage4";
            this.TabPage4.Size = new System.Drawing.Size(392, 230);
            this.TabPage4.TabIndex = 3;
            this.TabPage4.Text = "Race Bonuses";
            this.TabPage4.Visible = false;
            // 
            // lstRaceBonus
            // 
            this.lstRaceBonus.Location = new System.Drawing.Point(67, 10);
            this.lstRaceBonus.Name = "lstRaceBonus";
            this.lstRaceBonus.Size = new System.Drawing.Size(112, 134);
            this.lstRaceBonus.TabIndex = 75;
            // 
            // btnDelRaceBonus
            // 
            this.btnDelRaceBonus.Enabled = false;
            this.btnDelRaceBonus.Location = new System.Drawing.Point(263, 194);
            this.btnDelRaceBonus.Name = "btnDelRaceBonus";
            this.btnDelRaceBonus.Size = new System.Drawing.Size(75, 23);
            this.btnDelRaceBonus.TabIndex = 74;
            this.btnDelRaceBonus.Text = "Delete";
            this.btnDelRaceBonus.Click += new System.EventHandler(this.btnDelRaceBonus_Click_1);
            // 
            // Label16
            // 
            this.Label16.Location = new System.Drawing.Point(3, 18);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(48, 16);
            this.Label16.TabIndex = 73;
            this.Label16.Text = "Race:";
            // 
            // Label8
            // 
            this.Label8.Location = new System.Drawing.Point(3, 161);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(64, 16);
            this.Label8.TabIndex = 71;
            this.Label8.Text = "Bonus:";
            // 
            // btnAddRaceBonus
            // 
            this.btnAddRaceBonus.Enabled = false;
            this.btnAddRaceBonus.Location = new System.Drawing.Point(77, 192);
            this.btnAddRaceBonus.Name = "btnAddRaceBonus";
            this.btnAddRaceBonus.Size = new System.Drawing.Size(75, 23);
            this.btnAddRaceBonus.TabIndex = 70;
            this.btnAddRaceBonus.Text = "Add";
            this.btnAddRaceBonus.Click += new System.EventHandler(this.btnAddRaceBonus_Click_1);
            // 
            // txtRaceBonus
            // 
            this.txtRaceBonus.Location = new System.Drawing.Point(67, 161);
            this.txtRaceBonus.Name = "txtRaceBonus";
            this.txtRaceBonus.Size = new System.Drawing.Size(112, 20);
            this.txtRaceBonus.TabIndex = 69;
            this.txtRaceBonus.TextChanged += new System.EventHandler(this.CheckRaceBonusData);
            // 
            // lstRaceBonuses
            // 
            this.lstRaceBonuses.Location = new System.Drawing.Point(231, 10);
            this.lstRaceBonuses.Name = "lstRaceBonuses";
            this.lstRaceBonuses.Size = new System.Drawing.Size(144, 173);
            this.lstRaceBonuses.TabIndex = 1;
            // 
            // TabPage5
            // 
            this.TabPage5.Controls.Add(this.lstStatBonus);
            this.TabPage5.Controls.Add(this.btnDelStatBonus);
            this.TabPage5.Controls.Add(this.Label17);
            this.TabPage5.Controls.Add(this.Label4);
            this.TabPage5.Controls.Add(this.Label6);
            this.TabPage5.Controls.Add(this.Label7);
            this.TabPage5.Controls.Add(this.btnAddStatBonus);
            this.TabPage5.Controls.Add(this.txtStatBonus);
            this.TabPage5.Controls.Add(this.txtStatMaxVal);
            this.TabPage5.Controls.Add(this.txtStatMinVal);
            this.TabPage5.Controls.Add(this.lstStatBonuses);
            this.TabPage5.Location = new System.Drawing.Point(4, 22);
            this.TabPage5.Name = "TabPage5";
            this.TabPage5.Size = new System.Drawing.Size(392, 230);
            this.TabPage5.TabIndex = 4;
            this.TabPage5.Text = "Stat Bonuses";
            this.TabPage5.Visible = false;
            // 
            // lstStatBonus
            // 
            this.lstStatBonus.Location = new System.Drawing.Point(67, 8);
            this.lstStatBonus.Name = "lstStatBonus";
            this.lstStatBonus.Size = new System.Drawing.Size(112, 82);
            this.lstStatBonus.TabIndex = 72;
            // 
            // btnDelStatBonus
            // 
            this.btnDelStatBonus.Enabled = false;
            this.btnDelStatBonus.Location = new System.Drawing.Point(260, 200);
            this.btnDelStatBonus.Name = "btnDelStatBonus";
            this.btnDelStatBonus.Size = new System.Drawing.Size(75, 23);
            this.btnDelStatBonus.TabIndex = 71;
            this.btnDelStatBonus.Text = "Delete";
            this.btnDelStatBonus.Click += new System.EventHandler(this.btnDelStatBonus_Click_1);
            // 
            // Label17
            // 
            this.Label17.Location = new System.Drawing.Point(3, 16);
            this.Label17.Name = "Label17";
            this.Label17.Size = new System.Drawing.Size(48, 16);
            this.Label17.TabIndex = 70;
            this.Label17.Text = "Stat:";
            // 
            // Label4
            // 
            this.Label4.Location = new System.Drawing.Point(3, 168);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(64, 16);
            this.Label4.TabIndex = 68;
            this.Label4.Text = "Bonus:";
            // 
            // Label6
            // 
            this.Label6.Location = new System.Drawing.Point(3, 136);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(64, 16);
            this.Label6.TabIndex = 67;
            this.Label6.Text = "Max Value:";
            // 
            // Label7
            // 
            this.Label7.Location = new System.Drawing.Point(3, 104);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(64, 16);
            this.Label7.TabIndex = 66;
            this.Label7.Text = "Min Value:";
            // 
            // btnAddStatBonus
            // 
            this.btnAddStatBonus.Enabled = false;
            this.btnAddStatBonus.Location = new System.Drawing.Point(91, 200);
            this.btnAddStatBonus.Name = "btnAddStatBonus";
            this.btnAddStatBonus.Size = new System.Drawing.Size(75, 23);
            this.btnAddStatBonus.TabIndex = 60;
            this.btnAddStatBonus.Text = "Add";
            this.btnAddStatBonus.Click += new System.EventHandler(this.btnAddStatBonus_Click_1);
            // 
            // txtStatBonus
            // 
            this.txtStatBonus.Location = new System.Drawing.Point(67, 168);
            this.txtStatBonus.Name = "txtStatBonus";
            this.txtStatBonus.Size = new System.Drawing.Size(112, 20);
            this.txtStatBonus.TabIndex = 4;
            this.txtStatBonus.TextChanged += new System.EventHandler(this.CheckStatBonusData);
            // 
            // txtStatMaxVal
            // 
            this.txtStatMaxVal.Location = new System.Drawing.Point(67, 136);
            this.txtStatMaxVal.Name = "txtStatMaxVal";
            this.txtStatMaxVal.Size = new System.Drawing.Size(112, 20);
            this.txtStatMaxVal.TabIndex = 3;
            this.txtStatMaxVal.TextChanged += new System.EventHandler(this.CheckStatBonusData);
            // 
            // txtStatMinVal
            // 
            this.txtStatMinVal.Location = new System.Drawing.Point(67, 104);
            this.txtStatMinVal.Name = "txtStatMinVal";
            this.txtStatMinVal.Size = new System.Drawing.Size(112, 20);
            this.txtStatMinVal.TabIndex = 2;
            this.txtStatMinVal.TextChanged += new System.EventHandler(this.CheckStatBonusData);
            // 
            // lstStatBonuses
            // 
            this.lstStatBonuses.Location = new System.Drawing.Point(228, 8);
            this.lstStatBonuses.Name = "lstStatBonuses";
            this.lstStatBonuses.Size = new System.Drawing.Size(144, 173);
            this.lstStatBonuses.TabIndex = 1;
            // 
            // Label5
            // 
            this.Label5.Location = new System.Drawing.Point(260, 67);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(64, 16);
            this.Label5.TabIndex = 132;
            this.Label5.Text = "Description:";
            // 
            // Label3
            // 
            this.Label3.Location = new System.Drawing.Point(12, 123);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(40, 16);
            this.Label3.TabIndex = 131;
            this.Label3.Text = "Name:";
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(12, 91);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(40, 16);
            this.Label2.TabIndex = 130;
            this.Label2.Text = "Type:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(260, 91);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(168, 112);
            this.txtDescription.TabIndex = 129;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(95, 123);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(152, 20);
            this.txtName.TabIndex = 128;
            // 
            // cboType
            // 
            this.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboType.Items.AddRange(new object[] {
            "Defensive",
            "NonCombat",
            "Offensive"});
            this.cboType.Location = new System.Drawing.Point(95, 91);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(152, 21);
            this.cboType.TabIndex = 127;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowMerge = false;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuLoad,
            this.mnuSave});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(444, 24);
            this.menuStrip1.TabIndex = 143;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuLoad
            // 
            this.mnuLoad.Name = "mnuLoad";
            this.mnuLoad.Size = new System.Drawing.Size(45, 20);
            this.mnuLoad.Text = "&Load";
            // 
            // mnuSave
            // 
            this.mnuSave.Name = "mnuSave";
            this.mnuSave.Size = new System.Drawing.Size(43, 20);
            this.mnuSave.Text = "&Save";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(188, 499);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 148;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_1);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(107, 499);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 147;
            this.btnNew.Text = "New";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click_1);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(269, 499);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 146;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(354, 499);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 145;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(22, 499);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 144;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // SkillsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 529);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.cboOpposingSkill);
            this.Controls.Add(this.btnSelectIcon);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtIcon);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.chkAlwaysOn);
            this.Controls.Add(this.Label14);
            this.Controls.Add(this.cboSkills);
            this.Controls.Add(this.TabControl1);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.cboType);
            this.Name = "SkillsForm";
            this.Text = "Skills";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SkillsForm_FormClosing);
            this.TabControl1.ResumeLayout(false);
            this.TabPage3.ResumeLayout(false);
            this.TabPage3.PerformLayout();
            this.TabPage1.ResumeLayout(false);
            this.TabPage1.PerformLayout();
            this.TabPage2.ResumeLayout(false);
            this.TabPage2.PerformLayout();
            this.TabPage4.ResumeLayout(false);
            this.TabPage4.PerformLayout();
            this.TabPage5.ResumeLayout(false);
            this.TabPage5.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label label20;
        internal System.Windows.Forms.ComboBox cboOpposingSkill;
        internal System.Windows.Forms.Button btnSelectIcon;
        internal System.Windows.Forms.Label label15;
        internal System.Windows.Forms.TextBox txtIcon;
        private System.Windows.Forms.Label label12;
        internal System.Windows.Forms.CheckBox chkAlwaysOn;
        internal System.Windows.Forms.Label Label14;
        internal System.Windows.Forms.ComboBox cboSkills;
        internal System.Windows.Forms.TabControl TabControl1;
        internal System.Windows.Forms.TabPage TabPage3;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtCost;
        internal System.Windows.Forms.Button btnDelCost;
        internal System.Windows.Forms.Label Label19;
        internal System.Windows.Forms.ListBox lstCostClasses;
        internal System.Windows.Forms.Button btnAddCost;
        internal System.Windows.Forms.ListBox lstSkillCosts;
        internal System.Windows.Forms.TabPage TabPage1;
        internal System.Windows.Forms.ListBox lstClassBonus;
        internal System.Windows.Forms.Button btnDelClassBonus;
        internal System.Windows.Forms.Label Label18;
        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.Button btnAddClassBonus;
        internal System.Windows.Forms.TextBox txtClassBonus;
        internal System.Windows.Forms.ListBox lstClassBonuses;
        internal System.Windows.Forms.TabPage TabPage2;
        internal System.Windows.Forms.TextBox txtMaxLevel;
        internal System.Windows.Forms.TextBox txtMinLevel;
        internal System.Windows.Forms.Label label11;
        internal System.Windows.Forms.Label label10;
        internal System.Windows.Forms.Button btnDelLevelBonus;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Button btnAddLevelBonus;
        internal System.Windows.Forms.TextBox txtLevelBonus;
        internal System.Windows.Forms.ListBox lstLevelBonuses;
        internal System.Windows.Forms.TabPage TabPage4;
        internal System.Windows.Forms.ListBox lstRaceBonus;
        internal System.Windows.Forms.Button btnDelRaceBonus;
        internal System.Windows.Forms.Label Label16;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Button btnAddRaceBonus;
        internal System.Windows.Forms.TextBox txtRaceBonus;
        internal System.Windows.Forms.ListBox lstRaceBonuses;
        internal System.Windows.Forms.TabPage TabPage5;
        internal System.Windows.Forms.ListBox lstStatBonus;
        internal System.Windows.Forms.Button btnDelStatBonus;
        internal System.Windows.Forms.Label Label17;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Button btnAddStatBonus;
        internal System.Windows.Forms.TextBox txtStatBonus;
        internal System.Windows.Forms.TextBox txtStatMaxVal;
        internal System.Windows.Forms.TextBox txtStatMinVal;
        internal System.Windows.Forms.ListBox lstStatBonuses;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtDescription;
        internal System.Windows.Forms.TextBox txtName;
        internal System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuLoad;
        private System.Windows.Forms.ToolStripMenuItem mnuSave;
        internal System.Windows.Forms.Button btnUpdate;
        internal System.Windows.Forms.Button btnNew;
        internal System.Windows.Forms.Button btnClose;
        internal System.Windows.Forms.Button btnDelete;
        internal System.Windows.Forms.Button btnAdd;
    }
}