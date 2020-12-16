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
            this.BTN_submitQuestionnaire = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CMB_patients = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // LBL_medTitle
            // 
            this.LBL_medTitle.AutoSize = true;
            this.LBL_medTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_medTitle.Location = new System.Drawing.Point(138, 22);
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
            this.LBL_medication.Location = new System.Drawing.Point(3, 202);
            this.LBL_medication.Name = "LBL_medication";
            this.LBL_medication.Size = new System.Drawing.Size(98, 13);
            this.LBL_medication.TabIndex = 3;
            this.LBL_medication.Text = "Existing Medication";
            // 
            // TXT_medication
            // 
            this.TXT_medication.Location = new System.Drawing.Point(144, 202);
            this.TXT_medication.Name = "TXT_medication";
            this.TXT_medication.Size = new System.Drawing.Size(169, 20);
            this.TXT_medication.TabIndex = 4;
            // 
            // LBL_alllergies
            // 
            this.LBL_alllergies.AutoSize = true;
            this.LBL_alllergies.Location = new System.Drawing.Point(3, 293);
            this.LBL_alllergies.Name = "LBL_alllergies";
            this.LBL_alllergies.Size = new System.Drawing.Size(85, 13);
            this.LBL_alllergies.TabIndex = 5;
            this.LBL_alllergies.Text = "Existing Allergies";
            // 
            // TXT_allergies
            // 
            this.TXT_allergies.Location = new System.Drawing.Point(144, 290);
            this.TXT_allergies.Name = "TXT_allergies";
            this.TXT_allergies.Size = new System.Drawing.Size(169, 20);
            this.TXT_allergies.TabIndex = 6;
            // 
            // BTN_submitQuestionnaire
            // 
            this.BTN_submitQuestionnaire.Location = new System.Drawing.Point(279, 451);
            this.BTN_submitQuestionnaire.Name = "BTN_submitQuestionnaire";
            this.BTN_submitQuestionnaire.Size = new System.Drawing.Size(218, 65);
            this.BTN_submitQuestionnaire.TabIndex = 9;
            this.BTN_submitQuestionnaire.Text = "Submit";
            this.BTN_submitQuestionnaire.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(418, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Patient ";
            // 
            // CMB_patients
            // 
            this.CMB_patients.FormattingEnabled = true;
            this.CMB_patients.Location = new System.Drawing.Point(391, 157);
            this.CMB_patients.Name = "CMB_patients";
            this.CMB_patients.Size = new System.Drawing.Size(119, 21);
            this.CMB_patients.TabIndex = 11;
            // 
            // MedicalQuestionnaireGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 541);
            this.Controls.Add(this.CMB_patients);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTN_submitQuestionnaire);
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
        private System.Windows.Forms.Button BTN_submitQuestionnaire;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CMB_patients;
    }
}