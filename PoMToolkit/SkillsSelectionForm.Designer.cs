namespace PoMToolkit
{
    partial class SkillsSelectionForm
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblSkillPoints = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnUnselectSkill = new System.Windows.Forms.Button();
            this.btnSelectSkill = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.lstEntitySkills = new System.Windows.Forms.ListBox();
            this.lstSkills = new System.Windows.Forms.ListBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(226, 346);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 56;
            this.btnCancel.Text = "Cancel";
            // 
            // lblSkillPoints
            // 
            this.lblSkillPoints.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSkillPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSkillPoints.Location = new System.Drawing.Point(171, 33);
            this.lblSkillPoints.Name = "lblSkillPoints";
            this.lblSkillPoints.Size = new System.Drawing.Size(96, 24);
            this.lblSkillPoints.TabIndex = 55;
            this.lblSkillPoints.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label5
            // 
            this.Label5.Location = new System.Drawing.Point(171, 9);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(96, 16);
            this.Label5.TabIndex = 54;
            this.Label5.Text = "Skill Points";
            this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(19, 266);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(400, 56);
            this.txtDescription.TabIndex = 53;
            // 
            // Label4
            // 
            this.Label4.Location = new System.Drawing.Point(19, 250);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(72, 16);
            this.Label4.TabIndex = 52;
            this.Label4.Text = "Description:";
            // 
            // lblCost
            // 
            this.lblCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCost.Location = new System.Drawing.Point(51, 218);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(88, 16);
            this.lblCost.TabIndex = 51;
            this.lblCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label3
            // 
            this.Label3.Location = new System.Drawing.Point(19, 218);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(32, 16);
            this.Label3.TabIndex = 50;
            this.Label3.Text = "Cost:";
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(138, 346);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 49;
            this.btnOK.Text = "OK";
            // 
            // btnUnselectSkill
            // 
            this.btnUnselectSkill.Enabled = false;
            this.btnUnselectSkill.Location = new System.Drawing.Point(183, 120);
            this.btnUnselectSkill.Name = "btnUnselectSkill";
            this.btnUnselectSkill.Size = new System.Drawing.Size(75, 23);
            this.btnUnselectSkill.TabIndex = 48;
            this.btnUnselectSkill.Text = "<<";
            // 
            // btnSelectSkill
            // 
            this.btnSelectSkill.Enabled = false;
            this.btnSelectSkill.Location = new System.Drawing.Point(183, 88);
            this.btnSelectSkill.Name = "btnSelectSkill";
            this.btnSelectSkill.Size = new System.Drawing.Size(75, 23);
            this.btnSelectSkill.TabIndex = 47;
            this.btnSelectSkill.Text = ">>";
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(271, 11);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(72, 16);
            this.Label2.TabIndex = 46;
            this.Label2.Text = "Entity Skills:";
            // 
            // lstEntitySkills
            // 
            this.lstEntitySkills.Location = new System.Drawing.Point(271, 27);
            this.lstEntitySkills.Name = "lstEntitySkills";
            this.lstEntitySkills.Size = new System.Drawing.Size(148, 173);
            this.lstEntitySkills.TabIndex = 45;
            // 
            // lstSkills
            // 
            this.lstSkills.Location = new System.Drawing.Point(19, 27);
            this.lstSkills.Name = "lstSkills";
            this.lstSkills.Size = new System.Drawing.Size(148, 173);
            this.lstSkills.TabIndex = 44;
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(19, 11);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(88, 16);
            this.Label1.TabIndex = 43;
            this.Label1.Text = "Available Skills:";
            // 
            // SkillsSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 383);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblSkillPoints);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnUnselectSkill);
            this.Controls.Add(this.btnSelectSkill);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.lstEntitySkills);
            this.Controls.Add(this.lstSkills);
            this.Controls.Add(this.Label1);
            this.Name = "SkillsSelectionForm";
            this.Text = "SkillsSelectionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnCancel;
        internal System.Windows.Forms.Label lblSkillPoints;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox txtDescription;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label lblCost;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Button btnOK;
        internal System.Windows.Forms.Button btnUnselectSkill;
        internal System.Windows.Forms.Button btnSelectSkill;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.ListBox lstEntitySkills;
        internal System.Windows.Forms.ListBox lstSkills;
        internal System.Windows.Forms.Label Label1;
    }
}