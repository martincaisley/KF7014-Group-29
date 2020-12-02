namespace Team29_Group_Project
{
    partial class PatientRegistration
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
            this.label1 = new System.Windows.Forms.Label();
            this.LBL_fname = new System.Windows.Forms.Label();
            this.LBL_lname = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.LBL_DoB = new System.Windows.Forms.Label();
            this.LBL_address = new System.Windows.Forms.Label();
            this.LBL_email = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LBL_occupation = new System.Windows.Forms.Label();
            this.BTN_fullTime = new System.Windows.Forms.RadioButton();
            this.BTN_partTime = new System.Windows.Forms.RadioButton();
            this.BTN_education = new System.Windows.Forms.RadioButton();
            this.BTN_partTimeEducation = new System.Windows.Forms.RadioButton();
            this.BTN_unemployed = new System.Windows.Forms.RadioButton();
            this.BTN_LIbenefits = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(264, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patient Registration";
            // 
            // LBL_fname
            // 
            this.LBL_fname.AutoSize = true;
            this.LBL_fname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_fname.Location = new System.Drawing.Point(12, 107);
            this.LBL_fname.Name = "LBL_fname";
            this.LBL_fname.Size = new System.Drawing.Size(86, 20);
            this.LBL_fname.TabIndex = 1;
            this.LBL_fname.Text = "First Name";
            // 
            // LBL_lname
            // 
            this.LBL_lname.AutoSize = true;
            this.LBL_lname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_lname.Location = new System.Drawing.Point(12, 154);
            this.LBL_lname.Name = "LBL_lname";
            this.LBL_lname.Size = new System.Drawing.Size(86, 20);
            this.LBL_lname.TabIndex = 2;
            this.LBL_lname.Text = "Last Name";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(117, 197);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(79, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // LBL_DoB
            // 
            this.LBL_DoB.AutoSize = true;
            this.LBL_DoB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_DoB.Location = new System.Drawing.Point(12, 197);
            this.LBL_DoB.Name = "LBL_DoB";
            this.LBL_DoB.Size = new System.Drawing.Size(99, 20);
            this.LBL_DoB.TabIndex = 4;
            this.LBL_DoB.Text = "Date of Birth";
            // 
            // LBL_address
            // 
            this.LBL_address.AutoSize = true;
            this.LBL_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_address.Location = new System.Drawing.Point(12, 238);
            this.LBL_address.Name = "LBL_address";
            this.LBL_address.Size = new System.Drawing.Size(68, 20);
            this.LBL_address.TabIndex = 5;
            this.LBL_address.Text = "Address";
            // 
            // LBL_email
            // 
            this.LBL_email.AutoSize = true;
            this.LBL_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_email.Location = new System.Drawing.Point(12, 276);
            this.LBL_email.Name = "LBL_email";
            this.LBL_email.Size = new System.Drawing.Size(48, 20);
            this.LBL_email.TabIndex = 6;
            this.LBL_email.Text = "Email";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BTN_LIbenefits);
            this.panel1.Controls.Add(this.BTN_unemployed);
            this.panel1.Controls.Add(this.BTN_partTimeEducation);
            this.panel1.Controls.Add(this.BTN_education);
            this.panel1.Controls.Add(this.BTN_partTime);
            this.panel1.Controls.Add(this.BTN_fullTime);
            this.panel1.Location = new System.Drawing.Point(16, 343);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(161, 208);
            this.panel1.TabIndex = 7;
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
            // BTN_unemployed
            // 
            this.BTN_unemployed.AutoSize = true;
            this.BTN_unemployed.Location = new System.Drawing.Point(0, 149);
            this.BTN_unemployed.Name = "BTN_unemployed";
            this.BTN_unemployed.Size = new System.Drawing.Size(84, 17);
            this.BTN_unemployed.TabIndex = 4;
            this.BTN_unemployed.TabStop = true;
            this.BTN_unemployed.Text = "Unemployed";
            this.BTN_unemployed.UseVisualStyleBackColor = true;
            // 
            // BTN_LIbenefits
            // 
            this.BTN_LIbenefits.AutoSize = true;
            this.BTN_LIbenefits.Location = new System.Drawing.Point(2, 188);
            this.BTN_LIbenefits.Name = "BTN_LIbenefits";
            this.BTN_LIbenefits.Size = new System.Drawing.Size(124, 17);
            this.BTN_LIbenefits.TabIndex = 5;
            this.BTN_LIbenefits.TabStop = true;
            this.BTN_LIbenefits.Text = "Low Income Benefits";
            this.BTN_LIbenefits.UseVisualStyleBackColor = true;
            // 
            // PatientRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 576);
            this.Controls.Add(this.LBL_occupation);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LBL_email);
            this.Controls.Add(this.LBL_address);
            this.Controls.Add(this.LBL_DoB);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.LBL_lname);
            this.Controls.Add(this.LBL_fname);
            this.Controls.Add(this.label1);
            this.Name = "PatientRegistration";
            this.Text = "PatientRegistration";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LBL_fname;
        private System.Windows.Forms.Label LBL_lname;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label LBL_DoB;
        private System.Windows.Forms.Label LBL_address;
        private System.Windows.Forms.Label LBL_email;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton BTN_fullTime;
        private System.Windows.Forms.Label LBL_occupation;
        private System.Windows.Forms.RadioButton BTN_education;
        private System.Windows.Forms.RadioButton BTN_partTime;
        private System.Windows.Forms.RadioButton BTN_LIbenefits;
        private System.Windows.Forms.RadioButton BTN_unemployed;
        private System.Windows.Forms.RadioButton BTN_partTimeEducation;
    }
}