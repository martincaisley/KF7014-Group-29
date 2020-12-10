namespace Team29_Group_Project
{
    partial class PatientRegistrationGUI
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
            this.LBL_patTitle = new System.Windows.Forms.Label();
            this.LBL_fname = new System.Windows.Forms.Label();
            this.LBL_lname = new System.Windows.Forms.Label();
            this.DTB_DoB = new System.Windows.Forms.DateTimePicker();
            this.LBL_DoB = new System.Windows.Forms.Label();
            this.LBL_address = new System.Windows.Forms.Label();
            this.LBL_email = new System.Windows.Forms.Label();
            this.PNL_occupations = new System.Windows.Forms.Panel();
            this.BTN_LIbenefits = new System.Windows.Forms.RadioButton();
            this.BTN_unemployed = new System.Windows.Forms.RadioButton();
            this.BTN_partTimeEducation = new System.Windows.Forms.RadioButton();
            this.BTN_education = new System.Windows.Forms.RadioButton();
            this.BTN_partTime = new System.Windows.Forms.RadioButton();
            this.BTN_fullTime = new System.Windows.Forms.RadioButton();
            this.LBL_occupation = new System.Windows.Forms.Label();
            this.TXT_fname = new System.Windows.Forms.TextBox();
            this.TXT_sname = new System.Windows.Forms.TextBox();
            this.TXT_address = new System.Windows.Forms.TextBox();
            this.TXT_email = new System.Windows.Forms.TextBox();
            this.BTN_medQuestionnaire = new System.Windows.Forms.Button();
            this.LBL_GPname = new System.Windows.Forms.Label();
            this.LBL_GPaddress = new System.Windows.Forms.Label();
            this.TXT_GPname = new System.Windows.Forms.TextBox();
            this.TXT_GPaddress = new System.Windows.Forms.TextBox();
            this.BTN_addPatient = new System.Windows.Forms.Button();
            this.LBL_phoneNum = new System.Windows.Forms.Label();
            this.TXT_phoneNum = new System.Windows.Forms.TextBox();
            this.LBL_age = new System.Windows.Forms.Label();
            this.TXT_age = new System.Windows.Forms.TextBox();
            this.PNL_occupations.SuspendLayout();
            this.SuspendLayout();
            // 
            // LBL_patTitle
            // 
            this.LBL_patTitle.AutoSize = true;
            this.LBL_patTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_patTitle.Location = new System.Drawing.Point(125, 19);
            this.LBL_patTitle.Name = "LBL_patTitle";
            this.LBL_patTitle.Size = new System.Drawing.Size(295, 37);
            this.LBL_patTitle.TabIndex = 0;
            this.LBL_patTitle.Text = "Patient Registration";
            // 
            // LBL_fname
            // 
            this.LBL_fname.AutoSize = true;
            this.LBL_fname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_fname.Location = new System.Drawing.Point(12, 94);
            this.LBL_fname.Name = "LBL_fname";
            this.LBL_fname.Size = new System.Drawing.Size(86, 20);
            this.LBL_fname.TabIndex = 1;
            this.LBL_fname.Text = "First Name";
            // 
            // LBL_lname
            // 
            this.LBL_lname.AutoSize = true;
            this.LBL_lname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_lname.Location = new System.Drawing.Point(12, 131);
            this.LBL_lname.Name = "LBL_lname";
            this.LBL_lname.Size = new System.Drawing.Size(86, 20);
            this.LBL_lname.TabIndex = 2;
            this.LBL_lname.Text = "Last Name";
            // 
            // DTB_DoB
            // 
            this.DTB_DoB.Location = new System.Drawing.Point(132, 173);
            this.DTB_DoB.Name = "DTB_DoB";
            this.DTB_DoB.Size = new System.Drawing.Size(149, 20);
            this.DTB_DoB.TabIndex = 3;
            this.DTB_DoB.ValueChanged += new System.EventHandler(this.DTB_DoB_ValueChanged);
            // 
            // LBL_DoB
            // 
            this.LBL_DoB.AutoSize = true;
            this.LBL_DoB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_DoB.Location = new System.Drawing.Point(11, 174);
            this.LBL_DoB.Name = "LBL_DoB";
            this.LBL_DoB.Size = new System.Drawing.Size(99, 20);
            this.LBL_DoB.TabIndex = 4;
            this.LBL_DoB.Text = "Date of Birth";
            // 
            // LBL_address
            // 
            this.LBL_address.AutoSize = true;
            this.LBL_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_address.Location = new System.Drawing.Point(12, 209);
            this.LBL_address.Name = "LBL_address";
            this.LBL_address.Size = new System.Drawing.Size(68, 20);
            this.LBL_address.TabIndex = 5;
            this.LBL_address.Text = "Address";
            // 
            // LBL_email
            // 
            this.LBL_email.AutoSize = true;
            this.LBL_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_email.Location = new System.Drawing.Point(12, 250);
            this.LBL_email.Name = "LBL_email";
            this.LBL_email.Size = new System.Drawing.Size(48, 20);
            this.LBL_email.TabIndex = 6;
            this.LBL_email.Text = "Email";
            // 
            // PNL_occupations
            // 
            this.PNL_occupations.Controls.Add(this.BTN_LIbenefits);
            this.PNL_occupations.Controls.Add(this.BTN_unemployed);
            this.PNL_occupations.Controls.Add(this.BTN_partTimeEducation);
            this.PNL_occupations.Controls.Add(this.BTN_education);
            this.PNL_occupations.Controls.Add(this.BTN_partTime);
            this.PNL_occupations.Controls.Add(this.BTN_fullTime);
            this.PNL_occupations.Location = new System.Drawing.Point(16, 343);
            this.PNL_occupations.Name = "PNL_occupations";
            this.PNL_occupations.Size = new System.Drawing.Size(161, 208);
            this.PNL_occupations.TabIndex = 7;
            // 
            // BTN_LIbenefits
            // 
            this.BTN_LIbenefits.AutoSize = true;
            this.BTN_LIbenefits.Location = new System.Drawing.Point(0, 188);
            this.BTN_LIbenefits.Name = "BTN_LIbenefits";
            this.BTN_LIbenefits.Size = new System.Drawing.Size(124, 17);
            this.BTN_LIbenefits.TabIndex = 5;
            this.BTN_LIbenefits.TabStop = true;
            this.BTN_LIbenefits.Text = "Low Income Benefits";
            this.BTN_LIbenefits.UseVisualStyleBackColor = true;
            // 
            // BTN_unemployed
            // 
            this.BTN_unemployed.AutoSize = true;
            this.BTN_unemployed.Location = new System.Drawing.Point(3, 149);
            this.BTN_unemployed.Name = "BTN_unemployed";
            this.BTN_unemployed.Size = new System.Drawing.Size(84, 17);
            this.BTN_unemployed.TabIndex = 4;
            this.BTN_unemployed.TabStop = true;
            this.BTN_unemployed.Text = "Unemployed";
            this.BTN_unemployed.UseVisualStyleBackColor = true;
            // 
            // BTN_partTimeEducation
            // 
            this.BTN_partTimeEducation.AutoSize = true;
            this.BTN_partTimeEducation.Location = new System.Drawing.Point(3, 112);
            this.BTN_partTimeEducation.Name = "BTN_partTimeEducation";
            this.BTN_partTimeEducation.Size = new System.Drawing.Size(116, 17);
            this.BTN_partTimeEducation.TabIndex = 3;
            this.BTN_partTimeEducation.TabStop = true;
            this.BTN_partTimeEducation.Text = "Part time education";
            this.BTN_partTimeEducation.UseVisualStyleBackColor = true;
            // 
            // BTN_education
            // 
            this.BTN_education.AutoSize = true;
            this.BTN_education.Location = new System.Drawing.Point(3, 78);
            this.BTN_education.Name = "BTN_education";
            this.BTN_education.Size = new System.Drawing.Size(113, 17);
            this.BTN_education.TabIndex = 2;
            this.BTN_education.TabStop = true;
            this.BTN_education.Text = "Full time education";
            this.BTN_education.UseVisualStyleBackColor = true;
            // 
            // BTN_partTime
            // 
            this.BTN_partTime.AutoSize = true;
            this.BTN_partTime.Location = new System.Drawing.Point(3, 45);
            this.BTN_partTime.Name = "BTN_partTime";
            this.BTN_partTime.Size = new System.Drawing.Size(125, 17);
            this.BTN_partTime.TabIndex = 1;
            this.BTN_partTime.TabStop = true;
            this.BTN_partTime.Text = "Part time employment";
            this.BTN_partTime.UseVisualStyleBackColor = true;
            // 
            // BTN_fullTime
            // 
            this.BTN_fullTime.AutoSize = true;
            this.BTN_fullTime.Location = new System.Drawing.Point(3, 12);
            this.BTN_fullTime.Name = "BTN_fullTime";
            this.BTN_fullTime.Size = new System.Drawing.Size(122, 17);
            this.BTN_fullTime.TabIndex = 0;
            this.BTN_fullTime.TabStop = true;
            this.BTN_fullTime.Text = "Full time employment";
            this.BTN_fullTime.UseVisualStyleBackColor = true;
            // 
            // LBL_occupation
            // 
            this.LBL_occupation.AutoSize = true;
            this.LBL_occupation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_occupation.Location = new System.Drawing.Point(12, 320);
            this.LBL_occupation.Name = "LBL_occupation";
            this.LBL_occupation.Size = new System.Drawing.Size(90, 20);
            this.LBL_occupation.TabIndex = 8;
            this.LBL_occupation.Text = "Occupation";
            // 
            // TXT_fname
            // 
            this.TXT_fname.Location = new System.Drawing.Point(132, 94);
            this.TXT_fname.Name = "TXT_fname";
            this.TXT_fname.Size = new System.Drawing.Size(149, 20);
            this.TXT_fname.TabIndex = 9;
            // 
            // TXT_sname
            // 
            this.TXT_sname.Location = new System.Drawing.Point(132, 133);
            this.TXT_sname.Name = "TXT_sname";
            this.TXT_sname.Size = new System.Drawing.Size(149, 20);
            this.TXT_sname.TabIndex = 10;
            // 
            // TXT_address
            // 
            this.TXT_address.Location = new System.Drawing.Point(132, 211);
            this.TXT_address.Name = "TXT_address";
            this.TXT_address.Size = new System.Drawing.Size(149, 20);
            this.TXT_address.TabIndex = 11;
            // 
            // TXT_email
            // 
            this.TXT_email.Location = new System.Drawing.Point(132, 250);
            this.TXT_email.Name = "TXT_email";
            this.TXT_email.Size = new System.Drawing.Size(149, 20);
            this.TXT_email.TabIndex = 12;
            // 
            // BTN_medQuestionnaire
            // 
            this.BTN_medQuestionnaire.Location = new System.Drawing.Point(296, 638);
            this.BTN_medQuestionnaire.Name = "BTN_medQuestionnaire";
            this.BTN_medQuestionnaire.Size = new System.Drawing.Size(158, 54);
            this.BTN_medQuestionnaire.TabIndex = 15;
            this.BTN_medQuestionnaire.Text = "Medical Questionnaire";
            this.BTN_medQuestionnaire.UseVisualStyleBackColor = true;
            this.BTN_medQuestionnaire.Click += new System.EventHandler(this.BTN_medQuestionnaire_Click);
            // 
            // LBL_GPname
            // 
            this.LBL_GPname.AutoSize = true;
            this.LBL_GPname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_GPname.Location = new System.Drawing.Point(15, 573);
            this.LBL_GPname.Name = "LBL_GPname";
            this.LBL_GPname.Size = new System.Drawing.Size(78, 20);
            this.LBL_GPname.TabIndex = 16;
            this.LBL_GPname.Text = "GP Name";
            // 
            // LBL_GPaddress
            // 
            this.LBL_GPaddress.AutoSize = true;
            this.LBL_GPaddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_GPaddress.Location = new System.Drawing.Point(15, 605);
            this.LBL_GPaddress.Name = "LBL_GPaddress";
            this.LBL_GPaddress.Size = new System.Drawing.Size(95, 20);
            this.LBL_GPaddress.TabIndex = 17;
            this.LBL_GPaddress.Text = "GP Address";
            // 
            // TXT_GPname
            // 
            this.TXT_GPname.Location = new System.Drawing.Point(117, 573);
            this.TXT_GPname.Name = "TXT_GPname";
            this.TXT_GPname.Size = new System.Drawing.Size(149, 20);
            this.TXT_GPname.TabIndex = 18;
            // 
            // TXT_GPaddress
            // 
            this.TXT_GPaddress.Location = new System.Drawing.Point(116, 607);
            this.TXT_GPaddress.Name = "TXT_GPaddress";
            this.TXT_GPaddress.Size = new System.Drawing.Size(149, 20);
            this.TXT_GPaddress.TabIndex = 19;
            // 
            // BTN_addPatient
            // 
            this.BTN_addPatient.Location = new System.Drawing.Point(296, 555);
            this.BTN_addPatient.Name = "BTN_addPatient";
            this.BTN_addPatient.Size = new System.Drawing.Size(158, 54);
            this.BTN_addPatient.TabIndex = 20;
            this.BTN_addPatient.Text = "Register Patient";
            this.BTN_addPatient.UseVisualStyleBackColor = true;
            this.BTN_addPatient.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BTN_addPatient_MouseClick);
            // 
            // LBL_phoneNum
            // 
            this.LBL_phoneNum.AutoSize = true;
            this.LBL_phoneNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_phoneNum.Location = new System.Drawing.Point(11, 285);
            this.LBL_phoneNum.Name = "LBL_phoneNum";
            this.LBL_phoneNum.Size = new System.Drawing.Size(115, 20);
            this.LBL_phoneNum.TabIndex = 21;
            this.LBL_phoneNum.Text = "Phone Number";
            // 
            // TXT_phoneNum
            // 
            this.TXT_phoneNum.Location = new System.Drawing.Point(132, 285);
            this.TXT_phoneNum.Name = "TXT_phoneNum";
            this.TXT_phoneNum.Size = new System.Drawing.Size(149, 20);
            this.TXT_phoneNum.TabIndex = 22;
            // 
            // LBL_age
            // 
            this.LBL_age.AutoSize = true;
            this.LBL_age.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_age.Location = new System.Drawing.Point(307, 173);
            this.LBL_age.Name = "LBL_age";
            this.LBL_age.Size = new System.Drawing.Size(38, 20);
            this.LBL_age.TabIndex = 23;
            this.LBL_age.Text = "Age";
            // 
            // TXT_age
            // 
            this.TXT_age.Location = new System.Drawing.Point(351, 174);
            this.TXT_age.Name = "TXT_age";
            this.TXT_age.Size = new System.Drawing.Size(149, 20);
            this.TXT_age.TabIndex = 24;
            // 
            // PatientRegistrationGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 749);
            this.Controls.Add(this.TXT_age);
            this.Controls.Add(this.LBL_age);
            this.Controls.Add(this.TXT_phoneNum);
            this.Controls.Add(this.LBL_phoneNum);
            this.Controls.Add(this.BTN_addPatient);
            this.Controls.Add(this.TXT_GPaddress);
            this.Controls.Add(this.TXT_GPname);
            this.Controls.Add(this.LBL_GPaddress);
            this.Controls.Add(this.LBL_GPname);
            this.Controls.Add(this.BTN_medQuestionnaire);
            this.Controls.Add(this.TXT_email);
            this.Controls.Add(this.TXT_address);
            this.Controls.Add(this.TXT_sname);
            this.Controls.Add(this.TXT_fname);
            this.Controls.Add(this.LBL_occupation);
            this.Controls.Add(this.PNL_occupations);
            this.Controls.Add(this.LBL_email);
            this.Controls.Add(this.LBL_address);
            this.Controls.Add(this.LBL_DoB);
            this.Controls.Add(this.DTB_DoB);
            this.Controls.Add(this.LBL_lname);
            this.Controls.Add(this.LBL_fname);
            this.Controls.Add(this.LBL_patTitle);
            this.Name = "PatientRegistrationGUI";
            this.Text = "PatientRegistration";
            this.Load += new System.EventHandler(this.PatientRegistrationGUI_Load);
            this.PNL_occupations.ResumeLayout(false);
            this.PNL_occupations.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_patTitle;
        private System.Windows.Forms.Label LBL_fname;
        private System.Windows.Forms.Label LBL_lname;
        private System.Windows.Forms.DateTimePicker DTB_DoB;
        private System.Windows.Forms.Label LBL_DoB;
        private System.Windows.Forms.Label LBL_address;
        private System.Windows.Forms.Label LBL_email;
        private System.Windows.Forms.Panel PNL_occupations;
        private System.Windows.Forms.RadioButton BTN_fullTime;
        private System.Windows.Forms.Label LBL_occupation;
        private System.Windows.Forms.RadioButton BTN_education;
        private System.Windows.Forms.RadioButton BTN_partTime;
        private System.Windows.Forms.RadioButton BTN_LIbenefits;
        private System.Windows.Forms.RadioButton BTN_unemployed;
        private System.Windows.Forms.RadioButton BTN_partTimeEducation;
        private System.Windows.Forms.TextBox TXT_fname;
        private System.Windows.Forms.TextBox TXT_sname;
        private System.Windows.Forms.TextBox TXT_address;
        private System.Windows.Forms.TextBox TXT_email;
        private System.Windows.Forms.Button BTN_medQuestionnaire;
        private System.Windows.Forms.Label LBL_GPname;
        private System.Windows.Forms.Label LBL_GPaddress;
        private System.Windows.Forms.TextBox TXT_GPname;
        private System.Windows.Forms.TextBox TXT_GPaddress;
        private System.Windows.Forms.Button BTN_addPatient;
        private System.Windows.Forms.Label LBL_phoneNum;
        private System.Windows.Forms.TextBox TXT_phoneNum;
        private System.Windows.Forms.Label LBL_age;
        private System.Windows.Forms.TextBox TXT_age;
    }
}