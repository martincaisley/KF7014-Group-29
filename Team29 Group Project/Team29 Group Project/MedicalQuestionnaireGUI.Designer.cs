namespace Team29_Group_Project
{
    partial class MedicalQuestionnaireGUI
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
            this.LBL_medTitle = new System.Windows.Forms.Label();
            this.LBL_medConditions = new System.Windows.Forms.Label();
            this.TXT_medicalConditions = new System.Windows.Forms.TextBox();
            this.LBL_medication = new System.Windows.Forms.Label();
            this.TXT_medication = new System.Windows.Forms.TextBox();
            this.LBL_alllergies = new System.Windows.Forms.Label();
            this.TXT_allergies = new System.Windows.Forms.TextBox();
            this.LBL_treatmentPlan = new System.Windows.Forms.Label();
            this.CMB_treatmentPlan = new System.Windows.Forms.ComboBox();
            this.BTN_submitPatient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBL_medTitle
            // 
            this.LBL_medTitle.AutoSize = true;
            this.LBL_medTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_medTitle.Location = new System.Drawing.Point(248, 23);
            this.LBL_medTitle.Name = "LBL_medTitle";
            this.LBL_medTitle.Size = new System.Drawing.Size(306, 33);
            this.LBL_medTitle.TabIndex = 0;
            this.LBL_medTitle.Text = "Medical Questionnaire";
            // 
            // LBL_medConditions
            // 
            this.LBL_medConditions.AutoSize = true;
            this.LBL_medConditions.Location = new System.Drawing.Point(3, 133);
            this.LBL_medConditions.Name = "LBL_medConditions";
            this.LBL_medConditions.Size = new System.Drawing.Size(135, 13);
            this.LBL_medConditions.TabIndex = 1;
            this.LBL_medConditions.Text = "Existing Medical Conditions";
            // 
            // TXT_medicalConditions
            // 
            this.TXT_medicalConditions.Location = new System.Drawing.Point(144, 130);
            this.TXT_medicalConditions.Name = "TXT_medicalConditions";
            this.TXT_medicalConditions.Size = new System.Drawing.Size(169, 20);
            this.TXT_medicalConditions.TabIndex = 2;
            // 
            // LBL_medication
            // 
            this.LBL_medication.AutoSize = true;
            this.LBL_medication.Location = new System.Drawing.Point(3, 187);
            this.LBL_medication.Name = "LBL_medication";
            this.LBL_medication.Size = new System.Drawing.Size(98, 13);
            this.LBL_medication.TabIndex = 3;
            this.LBL_medication.Text = "Existing Medication";
            // 
            // TXT_medication
            // 
            this.TXT_medication.Location = new System.Drawing.Point(144, 184);
            this.TXT_medication.Name = "TXT_medication";
            this.TXT_medication.Size = new System.Drawing.Size(169, 20);
            this.TXT_medication.TabIndex = 4;
            // 
            // LBL_alllergies
            // 
            this.LBL_alllergies.AutoSize = true;
            this.LBL_alllergies.Location = new System.Drawing.Point(3, 241);
            this.LBL_alllergies.Name = "LBL_alllergies";
            this.LBL_alllergies.Size = new System.Drawing.Size(85, 13);
            this.LBL_alllergies.TabIndex = 5;
            this.LBL_alllergies.Text = "Existing Allergies";
            // 
            // TXT_allergies
            // 
            this.TXT_allergies.Location = new System.Drawing.Point(144, 238);
            this.TXT_allergies.Name = "TXT_allergies";
            this.TXT_allergies.Size = new System.Drawing.Size(169, 20);
            this.TXT_allergies.TabIndex = 6;
            // 
            // LBL_treatmentPlan
            // 
            this.LBL_treatmentPlan.AutoSize = true;
            this.LBL_treatmentPlan.Location = new System.Drawing.Point(3, 288);
            this.LBL_treatmentPlan.Name = "LBL_treatmentPlan";
            this.LBL_treatmentPlan.Size = new System.Drawing.Size(79, 13);
            this.LBL_treatmentPlan.TabIndex = 7;
            this.LBL_treatmentPlan.Text = "Treatment Plan";
            // 
            // CMB_treatmentPlan
            // 
            this.CMB_treatmentPlan.FormattingEnabled = true;
            this.CMB_treatmentPlan.Items.AddRange(new object[] {
            "Band 1 ",
            "Band 2",
            "Band 3",
            "Free Treatment"});
            this.CMB_treatmentPlan.Location = new System.Drawing.Point(144, 288);
            this.CMB_treatmentPlan.Name = "CMB_treatmentPlan";
            this.CMB_treatmentPlan.Size = new System.Drawing.Size(169, 21);
            this.CMB_treatmentPlan.TabIndex = 8;
            // 
            // BTN_submitPatient
            // 
            this.BTN_submitPatient.Location = new System.Drawing.Point(282, 440);
            this.BTN_submitPatient.Name = "BTN_submitPatient";
            this.BTN_submitPatient.Size = new System.Drawing.Size(218, 65);
            this.BTN_submitPatient.TabIndex = 9;
            this.BTN_submitPatient.Text = "Add Patient";
            this.BTN_submitPatient.UseVisualStyleBackColor = true;
            // 
            // MedicalQuestionnaireGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 541);
            this.Controls.Add(this.BTN_submitPatient);
            this.Controls.Add(this.CMB_treatmentPlan);
            this.Controls.Add(this.LBL_treatmentPlan);
            this.Controls.Add(this.TXT_allergies);
            this.Controls.Add(this.LBL_alllergies);
            this.Controls.Add(this.TXT_medication);
            this.Controls.Add(this.LBL_medication);
            this.Controls.Add(this.TXT_medicalConditions);
            this.Controls.Add(this.LBL_medConditions);
            this.Controls.Add(this.LBL_medTitle);
            this.Name = "MedicalQuestionnaireGUI";
            this.Text = "MedicalQuestionnaireGUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_medTitle;
        private System.Windows.Forms.Label LBL_medConditions;
        private System.Windows.Forms.TextBox TXT_medicalConditions;
        private System.Windows.Forms.Label LBL_medication;
        private System.Windows.Forms.TextBox TXT_medication;
        private System.Windows.Forms.Label LBL_alllergies;
        private System.Windows.Forms.TextBox TXT_allergies;
        private System.Windows.Forms.Label LBL_treatmentPlan;
        private System.Windows.Forms.ComboBox CMB_treatmentPlan;
        private System.Windows.Forms.Button BTN_submitPatient;
    }
}