namespace PoMToolkit
{
    partial class StatsGeneratorForm
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
            this.lvStats = new System.Windows.Forms.ListView();
            this.colStatName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colBaseValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRaceMod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colClassMod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colModifiedValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnGenerate = new System.Windows.Forms.Button();
            this.txtMaxAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMinAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvStats
            // 
            this.lvStats.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colStatName,
            this.colBaseValue,
            this.colRaceMod,
            this.colClassMod,
            this.colModifiedValue});
            this.lvStats.Location = new System.Drawing.Point(12, 12);
            this.lvStats.Name = "lvStats";
            this.lvStats.Size = new System.Drawing.Size(581, 211);
            this.lvStats.TabIndex = 0;
            this.lvStats.UseCompatibleStateImageBehavior = false;
            this.lvStats.View = System.Windows.Forms.View.Details;
            // 
            // colStatName
            // 
            this.colStatName.Text = "Stat Name";
            this.colStatName.Width = 186;
            // 
            // colBaseValue
            // 
            this.colBaseValue.Text = "Base Value";
            this.colBaseValue.Width = 87;
            // 
            // colRaceMod
            // 
            this.colRaceMod.Text = "Race Mod";
            this.colRaceMod.Width = 86;
            // 
            // colClassMod
            // 
            this.colClassMod.Text = "Class Mod";
            this.colClassMod.Width = 86;
            // 
            // colModifiedValue
            // 
            this.colModifiedValue.Text = "Modified Value";
            this.colModifiedValue.Width = 132;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(241, 240);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 1;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // txtMaxAmount
            // 
            this.txtMaxAmount.Location = new System.Drawing.Point(429, 285);
            this.txtMaxAmount.Name = "txtMaxAmount";
            this.txtMaxAmount.Size = new System.Drawing.Size(53, 20);
            this.txtMaxAmount.TabIndex = 88;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(311, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 87;
            this.label2.Text = "Maximum Stat Amount:";
            // 
            // txtMinAmount
            // 
            this.txtMinAmount.Location = new System.Drawing.Point(224, 285);
            this.txtMinAmount.Name = "txtMinAmount";
            this.txtMinAmount.Size = new System.Drawing.Size(53, 20);
            this.txtMinAmount.TabIndex = 86;
            this.txtMinAmount.Text = "40";
            this.txtMinAmount.Validating += new System.ComponentModel.CancelEventHandler(this.txtMinAmount_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 85;
            this.label1.Text = "Minimum Stat Amount:";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(280, 331);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 84;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Enabled = false;
            this.btnOK.Location = new System.Drawing.Point(196, 331);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 83;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // StatsGeneratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 371);
            this.Controls.Add(this.txtMaxAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMinAmount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.lvStats);
            this.Name = "StatsGeneratorForm";
            this.Text = "StatsGeneratorForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvStats;
        private System.Windows.Forms.ColumnHeader colStatName;
        private System.Windows.Forms.ColumnHeader colBaseValue;
        private System.Windows.Forms.ColumnHeader colRaceMod;
        private System.Windows.Forms.ColumnHeader colClassMod;
        private System.Windows.Forms.ColumnHeader colModifiedValue;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox txtMaxAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMinAmount;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Button btnCancel;
        internal System.Windows.Forms.Button btnOK;
    }
}