namespace PoMToolkit
{
    partial class RacesForm
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
            this.cbRaces = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRaceName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRaceDescription = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstStatModifiers = new System.Windows.Forms.ListBox();
            this.btnRemoveModifier = new System.Windows.Forms.Button();
            this.btnAddModifier = new System.Windows.Forms.Button();
            this.txtModifierAmount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lstStats = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbWeakness = new System.Windows.Forms.RadioButton();
            this.rbResistance = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.lstWRs = new System.Windows.Forms.ListBox();
            this.btnRemoveWR = new System.Windows.Forms.Button();
            this.btnAddWR = new System.Windows.Forms.Button();
            this.txtWRAmount = new System.Windows.Forms.TextBox();
            this.lstModifierTypes = new System.Windows.Forms.ListBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuLoad,
            this.mnuSave});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(638, 24);
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
            this.mnuSave.Enabled = false;
            this.mnuSave.Name = "mnuSave";
            this.mnuSave.Size = new System.Drawing.Size(43, 20);
            this.mnuSave.Text = "&Save";
            this.mnuSave.Click += new System.EventHandler(this.mnuSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Races";
            // 
            // cbRaces
            // 
            this.cbRaces.FormattingEnabled = true;
            this.cbRaces.Location = new System.Drawing.Point(88, 52);
            this.cbRaces.Name = "cbRaces";
            this.cbRaces.Size = new System.Drawing.Size(165, 21);
            this.cbRaces.TabIndex = 2;
            this.cbRaces.SelectedIndexChanged += new System.EventHandler(this.cbRaces_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Race Nane";
            // 
            // txtRaceName
            // 
            this.txtRaceName.Location = new System.Drawing.Point(95, 103);
            this.txtRaceName.Name = "txtRaceName";
            this.txtRaceName.Size = new System.Drawing.Size(158, 20);
            this.txtRaceName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(259, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Description";
            // 
            // txtRaceDescription
            // 
            this.txtRaceDescription.Location = new System.Drawing.Point(325, 103);
            this.txtRaceDescription.Multiline = true;
            this.txtRaceDescription.Name = "txtRaceDescription";
            this.txtRaceDescription.Size = new System.Drawing.Size(301, 108);
            this.txtRaceDescription.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstStatModifiers);
            this.groupBox1.Controls.Add(this.btnRemoveModifier);
            this.groupBox1.Controls.Add(this.btnAddModifier);
            this.groupBox1.Controls.Add(this.txtModifierAmount);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lstStats);
            this.groupBox1.Location = new System.Drawing.Point(30, 235);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(596, 205);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stat Modifiers";
            // 
            // lstStatModifiers
            // 
            this.lstStatModifiers.FormattingEnabled = true;
            this.lstStatModifiers.Location = new System.Drawing.Point(407, 19);
            this.lstStatModifiers.Name = "lstStatModifiers";
            this.lstStatModifiers.Size = new System.Drawing.Size(171, 173);
            this.lstStatModifiers.TabIndex = 5;
            // 
            // btnRemoveModifier
            // 
            this.btnRemoveModifier.Location = new System.Drawing.Point(316, 89);
            this.btnRemoveModifier.Name = "btnRemoveModifier";
            this.btnRemoveModifier.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveModifier.TabIndex = 4;
            this.btnRemoveModifier.Text = "<<";
            this.btnRemoveModifier.UseVisualStyleBackColor = true;
            this.btnRemoveModifier.Click += new System.EventHandler(this.btnRemoveModifier_Click);
            // 
            // btnAddModifier
            // 
            this.btnAddModifier.Location = new System.Drawing.Point(316, 53);
            this.btnAddModifier.Name = "btnAddModifier";
            this.btnAddModifier.Size = new System.Drawing.Size(75, 23);
            this.btnAddModifier.TabIndex = 3;
            this.btnAddModifier.Text = ">>";
            this.btnAddModifier.UseVisualStyleBackColor = true;
            this.btnAddModifier.Click += new System.EventHandler(this.btnAddModifier_Click);
            // 
            // txtModifierAmount
            // 
            this.txtModifierAmount.Location = new System.Drawing.Point(203, 74);
            this.txtModifierAmount.Name = "txtModifierAmount";
            this.txtModifierAmount.Size = new System.Drawing.Size(100, 20);
            this.txtModifierAmount.TabIndex = 2;
            this.txtModifierAmount.TextChanged += new System.EventHandler(this.CheckModifierAmount);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(200, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Amount";
            // 
            // lstStats
            // 
            this.lstStats.FormattingEnabled = true;
            this.lstStats.Location = new System.Drawing.Point(6, 19);
            this.lstStats.Name = "lstStats";
            this.lstStats.Size = new System.Drawing.Size(177, 173);
            this.lstStats.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbWeakness);
            this.groupBox2.Controls.Add(this.rbResistance);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lstWRs);
            this.groupBox2.Controls.Add(this.btnRemoveWR);
            this.groupBox2.Controls.Add(this.btnAddWR);
            this.groupBox2.Controls.Add(this.txtWRAmount);
            this.groupBox2.Controls.Add(this.lstModifierTypes);
            this.groupBox2.Location = new System.Drawing.Point(30, 446);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(596, 205);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resistances/Weaknesses";
            // 
            // rbWeakness
            // 
            this.rbWeakness.AutoSize = true;
            this.rbWeakness.Location = new System.Drawing.Point(203, 134);
            this.rbWeakness.Name = "rbWeakness";
            this.rbWeakness.Size = new System.Drawing.Size(76, 17);
            this.rbWeakness.TabIndex = 13;
            this.rbWeakness.TabStop = true;
            this.rbWeakness.Text = "Weakness";
            this.rbWeakness.UseVisualStyleBackColor = true;
            // 
            // rbResistance
            // 
            this.rbResistance.AutoSize = true;
            this.rbResistance.Location = new System.Drawing.Point(203, 111);
            this.rbResistance.Name = "rbResistance";
            this.rbResistance.Size = new System.Drawing.Size(78, 17);
            this.rbResistance.TabIndex = 12;
            this.rbResistance.TabStop = true;
            this.rbResistance.Text = "Resistance";
            this.rbResistance.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(200, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Amount";
            // 
            // lstWRs
            // 
            this.lstWRs.FormattingEnabled = true;
            this.lstWRs.Location = new System.Drawing.Point(407, 19);
            this.lstWRs.Name = "lstWRs";
            this.lstWRs.Size = new System.Drawing.Size(171, 173);
            this.lstWRs.TabIndex = 10;
            // 
            // btnRemoveWR
            // 
            this.btnRemoveWR.Location = new System.Drawing.Point(316, 89);
            this.btnRemoveWR.Name = "btnRemoveWR";
            this.btnRemoveWR.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveWR.TabIndex = 9;
            this.btnRemoveWR.Text = "<<";
            this.btnRemoveWR.UseVisualStyleBackColor = true;
            this.btnRemoveWR.Click += new System.EventHandler(this.btnRemoveWR_Click);
            // 
            // btnAddWR
            // 
            this.btnAddWR.Location = new System.Drawing.Point(316, 53);
            this.btnAddWR.Name = "btnAddWR";
            this.btnAddWR.Size = new System.Drawing.Size(75, 23);
            this.btnAddWR.TabIndex = 8;
            this.btnAddWR.Text = ">>";
            this.btnAddWR.UseVisualStyleBackColor = true;
            this.btnAddWR.Click += new System.EventHandler(this.btnAddWR_Click);
            // 
            // txtWRAmount
            // 
            this.txtWRAmount.Location = new System.Drawing.Point(203, 74);
            this.txtWRAmount.Name = "txtWRAmount";
            this.txtWRAmount.Size = new System.Drawing.Size(100, 20);
            this.txtWRAmount.TabIndex = 7;
            this.txtWRAmount.TextChanged += new System.EventHandler(this.CheckWRAmount);
            // 
            // lstModifierTypes
            // 
            this.lstModifierTypes.FormattingEnabled = true;
            this.lstModifierTypes.Location = new System.Drawing.Point(6, 19);
            this.lstModifierTypes.Name = "lstModifierTypes";
            this.lstModifierTypes.Size = new System.Drawing.Size(177, 173);
            this.lstModifierTypes.TabIndex = 6;
            this.lstModifierTypes.SelectedIndexChanged += new System.EventHandler(this.lstWRs_SelectedIndexChanged);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(464, 663);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 23;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(382, 663);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(300, 663);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 21;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(218, 663);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 20;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(136, 663);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // RacesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 698);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtRaceDescription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRaceName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbRaces);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "RacesForm";
            this.Text = "RacesForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RacesForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuLoad;
        private System.Windows.Forms.ToolStripMenuItem mnuSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbRaces;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRaceName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRaceDescription;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstStatModifiers;
        private System.Windows.Forms.Button btnRemoveModifier;
        private System.Windows.Forms.Button btnAddModifier;
        private System.Windows.Forms.TextBox txtModifierAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstStats;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbWeakness;
        private System.Windows.Forms.RadioButton rbResistance;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lstWRs;
        private System.Windows.Forms.Button btnRemoveWR;
        private System.Windows.Forms.Button btnAddWR;
        private System.Windows.Forms.TextBox txtWRAmount;
        private System.Windows.Forms.ListBox lstModifierTypes;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnAdd;
    }
}