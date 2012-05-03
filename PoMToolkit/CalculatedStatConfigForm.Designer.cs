namespace PoMToolkit
{
    partial class CalculatedStatConfigForm
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
            this.lstStats = new System.Windows.Forms.ListBox();
            this.btnAddStat = new System.Windows.Forms.Button();
            this.btnBrack1 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnBrack2 = new System.Windows.Forms.Button();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.btnAddValue = new System.Windows.Forms.Button();
            this.btnRandomNum = new System.Windows.Forms.Button();
            this.txtStatCalculation = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstStats
            // 
            this.lstStats.FormattingEnabled = true;
            this.lstStats.Location = new System.Drawing.Point(12, 12);
            this.lstStats.Name = "lstStats";
            this.lstStats.Size = new System.Drawing.Size(120, 95);
            this.lstStats.TabIndex = 0;
            // 
            // btnAddStat
            // 
            this.btnAddStat.Location = new System.Drawing.Point(150, 54);
            this.btnAddStat.Name = "btnAddStat";
            this.btnAddStat.Size = new System.Drawing.Size(56, 23);
            this.btnAddStat.TabIndex = 1;
            this.btnAddStat.Text = ">>>";
            this.btnAddStat.UseVisualStyleBackColor = true;
            this.btnAddStat.Click += new System.EventHandler(this.btnAddStat_Click);
            // 
            // btnBrack1
            // 
            this.btnBrack1.Location = new System.Drawing.Point(12, 131);
            this.btnBrack1.Name = "btnBrack1";
            this.btnBrack1.Size = new System.Drawing.Size(52, 23);
            this.btnBrack1.TabIndex = 2;
            this.btnBrack1.Text = "(";
            this.btnBrack1.UseVisualStyleBackColor = true;
            this.btnBrack1.Click += new System.EventHandler(this.OperatorClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(70, 131);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(52, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.OperatorClick);
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(128, 131);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(52, 23);
            this.btnMinus.TabIndex = 4;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.OperatorClick);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Location = new System.Drawing.Point(186, 131);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(52, 23);
            this.btnMultiply.TabIndex = 5;
            this.btnMultiply.Text = "*";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.OperatorClick);
            // 
            // btnDivide
            // 
            this.btnDivide.Location = new System.Drawing.Point(244, 131);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(52, 23);
            this.btnDivide.TabIndex = 6;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.OperatorClick);
            // 
            // btnBrack2
            // 
            this.btnBrack2.Location = new System.Drawing.Point(302, 131);
            this.btnBrack2.Name = "btnBrack2";
            this.btnBrack2.Size = new System.Drawing.Size(52, 23);
            this.btnBrack2.TabIndex = 7;
            this.btnBrack2.Text = ")";
            this.btnBrack2.UseVisualStyleBackColor = true;
            this.btnBrack2.Click += new System.EventHandler(this.OperatorClick);
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(12, 171);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(100, 20);
            this.txtValue.TabIndex = 8;
            // 
            // btnAddValue
            // 
            this.btnAddValue.Location = new System.Drawing.Point(118, 169);
            this.btnAddValue.Name = "btnAddValue";
            this.btnAddValue.Size = new System.Drawing.Size(56, 23);
            this.btnAddValue.TabIndex = 9;
            this.btnAddValue.Text = ">>>";
            this.btnAddValue.UseVisualStyleBackColor = true;
            this.btnAddValue.Click += new System.EventHandler(this.btnAddValue_Click);
            // 
            // btnRandomNum
            // 
            this.btnRandomNum.Location = new System.Drawing.Point(255, 169);
            this.btnRandomNum.Name = "btnRandomNum";
            this.btnRandomNum.Size = new System.Drawing.Size(99, 23);
            this.btnRandomNum.TabIndex = 10;
            this.btnRandomNum.Text = "1-100 Random #";
            this.btnRandomNum.UseVisualStyleBackColor = true;
            this.btnRandomNum.Click += new System.EventHandler(this.btnRandomNum_Click);
            // 
            // txtStatCalculation
            // 
            this.txtStatCalculation.Location = new System.Drawing.Point(12, 233);
            this.txtStatCalculation.Name = "txtStatCalculation";
            this.txtStatCalculation.Size = new System.Drawing.Size(342, 20);
            this.txtStatCalculation.TabIndex = 11;
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(105, 287);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 12;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(186, 287);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // CalculatedStatConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 324);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtStatCalculation);
            this.Controls.Add(this.btnRandomNum);
            this.Controls.Add(this.btnAddValue);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.btnBrack2);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnBrack1);
            this.Controls.Add(this.btnAddStat);
            this.Controls.Add(this.lstStats);
            this.Name = "CalculatedStatConfigForm";
            this.Text = "CalculatedStatConfigForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstStats;
        private System.Windows.Forms.Button btnAddStat;
        private System.Windows.Forms.Button btnBrack1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnBrack2;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Button btnAddValue;
        private System.Windows.Forms.Button btnRandomNum;
        private System.Windows.Forms.TextBox txtStatCalculation;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
    }
}