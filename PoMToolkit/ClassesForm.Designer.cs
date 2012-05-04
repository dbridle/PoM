namespace PoMToolkit
{
    partial class ClassesForm
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
            this.cbClasses = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.txtClassDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbDiceType = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbModifiers = new System.Windows.Forms.ComboBox();
            this.btnDeleteModifier = new System.Windows.Forms.Button();
            this.btnUpdateModifier = new System.Windows.Forms.Button();
            this.btnNewModifier = new System.Windows.Forms.Button();
            this.btnAddModifier = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbStats = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuLoad,
            this.mnuSave});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(473, 24);
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
            this.label1.Location = new System.Drawing.Point(25, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Classes";
            // 
            // cbClasses
            // 
            this.cbClasses.FormattingEnabled = true;
            this.cbClasses.Location = new System.Drawing.Point(112, 36);
            this.cbClasses.Name = "cbClasses";
            this.cbClasses.Size = new System.Drawing.Size(223, 21);
            this.cbClasses.TabIndex = 2;
            this.cbClasses.SelectedIndexChanged += new System.EventHandler(this.cbClasses_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Class Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Description";
            // 
            // txtClassName
            // 
            this.txtClassName.Location = new System.Drawing.Point(112, 68);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(185, 20);
            this.txtClassName.TabIndex = 5;
            // 
            // txtClassDescription
            // 
            this.txtClassDescription.Location = new System.Drawing.Point(112, 98);
            this.txtClassDescription.Multiline = true;
            this.txtClassDescription.Name = "txtClassDescription";
            this.txtClassDescription.Size = new System.Drawing.Size(223, 103);
            this.txtClassDescription.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Hit Points Dice Type";
            // 
            // cbDiceType
            // 
            this.cbDiceType.FormattingEnabled = true;
            this.cbDiceType.Location = new System.Drawing.Point(148, 213);
            this.cbDiceType.Name = "cbDiceType";
            this.cbDiceType.Size = new System.Drawing.Size(121, 21);
            this.cbDiceType.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbModifiers);
            this.groupBox1.Controls.Add(this.btnDeleteModifier);
            this.groupBox1.Controls.Add(this.btnUpdateModifier);
            this.groupBox1.Controls.Add(this.btnNewModifier);
            this.groupBox1.Controls.Add(this.btnAddModifier);
            this.groupBox1.Controls.Add(this.txtAmount);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cbStats);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(33, 258);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 176);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stat Modifiers";
            // 
            // cbModifiers
            // 
            this.cbModifiers.FormattingEnabled = true;
            this.cbModifiers.Location = new System.Drawing.Point(97, 29);
            this.cbModifiers.Name = "cbModifiers";
            this.cbModifiers.Size = new System.Drawing.Size(180, 21);
            this.cbModifiers.TabIndex = 10;
            // 
            // btnDeleteModifier
            // 
            this.btnDeleteModifier.Location = new System.Drawing.Point(249, 147);
            this.btnDeleteModifier.Name = "btnDeleteModifier";
            this.btnDeleteModifier.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteModifier.TabIndex = 9;
            this.btnDeleteModifier.Text = "Delete";
            this.btnDeleteModifier.UseVisualStyleBackColor = true;
            this.btnDeleteModifier.Click += new System.EventHandler(this.btnDeleteModifier_Click);
            // 
            // btnUpdateModifier
            // 
            this.btnUpdateModifier.Location = new System.Drawing.Point(168, 147);
            this.btnUpdateModifier.Name = "btnUpdateModifier";
            this.btnUpdateModifier.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateModifier.TabIndex = 8;
            this.btnUpdateModifier.Text = "Update";
            this.btnUpdateModifier.UseVisualStyleBackColor = true;
            this.btnUpdateModifier.Click += new System.EventHandler(this.btnUpdateModifier_Click);
            // 
            // btnNewModifier
            // 
            this.btnNewModifier.Location = new System.Drawing.Point(87, 147);
            this.btnNewModifier.Name = "btnNewModifier";
            this.btnNewModifier.Size = new System.Drawing.Size(75, 23);
            this.btnNewModifier.TabIndex = 7;
            this.btnNewModifier.Text = "New";
            this.btnNewModifier.UseVisualStyleBackColor = true;
            this.btnNewModifier.Click += new System.EventHandler(this.btnNewModifier_Click);
            // 
            // btnAddModifier
            // 
            this.btnAddModifier.Location = new System.Drawing.Point(6, 147);
            this.btnAddModifier.Name = "btnAddModifier";
            this.btnAddModifier.Size = new System.Drawing.Size(75, 23);
            this.btnAddModifier.TabIndex = 6;
            this.btnAddModifier.Text = "Add";
            this.btnAddModifier.UseVisualStyleBackColor = true;
            this.btnAddModifier.Click += new System.EventHandler(this.btnAddModifier_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(97, 97);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(77, 20);
            this.txtAmount.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Amount";
            // 
            // cbStats
            // 
            this.cbStats.FormattingEnabled = true;
            this.cbStats.Location = new System.Drawing.Point(97, 60);
            this.cbStats.Name = "cbStats";
            this.cbStats.Size = new System.Drawing.Size(121, 21);
            this.cbStats.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Stat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Modifiers";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(285, 450);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(204, 450);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(123, 450);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 11;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(42, 450);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(366, 450);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ClassesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 479);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.cbDiceType);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtClassDescription);
            this.Controls.Add(this.txtClassName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbClasses);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ClassesForm";
            this.Text = "ClassesForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClassesForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuLoad;
        private System.Windows.Forms.ToolStripMenuItem mnuSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbClasses;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.TextBox txtClassDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbDiceType;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbModifiers;
        private System.Windows.Forms.Button btnDeleteModifier;
        private System.Windows.Forms.Button btnUpdateModifier;
        private System.Windows.Forms.Button btnNewModifier;
        private System.Windows.Forms.Button btnAddModifier;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbStats;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClose;
    }
}