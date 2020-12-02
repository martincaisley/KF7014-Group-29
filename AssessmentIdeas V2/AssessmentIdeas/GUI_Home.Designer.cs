namespace KF7014_Group_29_Assignment
{
    partial class GUI_home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_title = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BTN_Registration = new System.Windows.Forms.Button();
            this.BTN_Appointments = new System.Windows.Forms.Button();
            this.LBL_guide = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_title.Location = new System.Drawing.Point(315, 27);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(175, 45);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Patient List";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(235, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(343, 353);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.Text = "dataGridView1";
            // 
            // BTN_Registration
            // 
            this.BTN_Registration.Location = new System.Drawing.Point(24, 85);
            this.BTN_Registration.Name = "BTN_Registration";
            this.BTN_Registration.Size = new System.Drawing.Size(129, 64);
            this.BTN_Registration.TabIndex = 2;
            this.BTN_Registration.Text = "Register a patient";
            this.BTN_Registration.UseVisualStyleBackColor = true;
            this.BTN_Registration.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BTN_Registration_MouseClick);
            // 
            // BTN_Appointments
            // 
            this.BTN_Appointments.Location = new System.Drawing.Point(24, 178);
            this.BTN_Appointments.Name = "BTN_Appointments";
            this.BTN_Appointments.Size = new System.Drawing.Size(129, 64);
            this.BTN_Appointments.TabIndex = 2;
            this.BTN_Appointments.Text = "View Appointments";
            this.BTN_Appointments.UseVisualStyleBackColor = true;
            // 
            // LBL_guide
            // 
            this.LBL_guide.AutoSize = true;
            this.LBL_guide.Location = new System.Drawing.Point(584, 85);
            this.LBL_guide.Name = "LBL_guide";
            this.LBL_guide.Size = new System.Drawing.Size(204, 15);
            this.LBL_guide.TabIndex = 3;
            this.LBL_guide.Text = "Click on a patient to view their details";
            // 
            // GUI_home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LBL_guide);
            this.Controls.Add(this.BTN_Appointments);
            this.Controls.Add(this.BTN_Registration);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbl_title);
            this.Name = "GUI_home";
            this.Text = "Quick Fix Dental Practice";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BTN_Registration;
        private System.Windows.Forms.Button BTN_Appointments;
        private System.Windows.Forms.Label LBL_guide;
    }
}

