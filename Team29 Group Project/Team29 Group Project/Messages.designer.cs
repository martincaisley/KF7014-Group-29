
namespace Team29_Group_Project
{
    partial class Messages
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
            this.btn_valid = new System.Windows.Forms.Button();
            this.btn_invalid = new System.Windows.Forms.Button();
            this.lbl_appointmentDate = new System.Windows.Forms.Label();
            this.txt_appointmentDate = new System.Windows.Forms.TextBox();
            this.lbl_appTime = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.txt_appointmentTime = new System.Windows.Forms.TextBox();
            this.txt_patientName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_valid
            // 
            this.btn_valid.Location = new System.Drawing.Point(106, 125);
            this.btn_valid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_valid.Name = "btn_valid";
            this.btn_valid.Size = new System.Drawing.Size(80, 50);
            this.btn_valid.TabIndex = 0;
            this.btn_valid.Text = "Valid Excuse";
            this.btn_valid.UseVisualStyleBackColor = true;
            this.btn_valid.Click += new System.EventHandler(this.btn_valid_Click);
            // 
            // btn_invalid
            // 
            this.btn_invalid.Location = new System.Drawing.Point(17, 125);
            this.btn_invalid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_invalid.Name = "btn_invalid";
            this.btn_invalid.Size = new System.Drawing.Size(80, 50);
            this.btn_invalid.TabIndex = 1;
            this.btn_invalid.Text = "Invalid Excuse";
            this.btn_invalid.UseVisualStyleBackColor = true;
            this.btn_invalid.Click += new System.EventHandler(this.btn_invalid_Click);
            // 
            // lbl_appointmentDate
            // 
            this.lbl_appointmentDate.AutoSize = true;
            this.lbl_appointmentDate.Location = new System.Drawing.Point(15, 95);
            this.lbl_appointmentDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_appointmentDate.Name = "lbl_appointmentDate";
            this.lbl_appointmentDate.Size = new System.Drawing.Size(92, 13);
            this.lbl_appointmentDate.TabIndex = 20;
            this.lbl_appointmentDate.Text = "Appointment Date";
            // 
            // txt_appointmentDate
            // 
            this.txt_appointmentDate.Location = new System.Drawing.Point(111, 93);
            this.txt_appointmentDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_appointmentDate.Name = "txt_appointmentDate";
            this.txt_appointmentDate.Size = new System.Drawing.Size(76, 20);
            this.txt_appointmentDate.TabIndex = 19;
            // 
            // lbl_appTime
            // 
            this.lbl_appTime.AutoSize = true;
            this.lbl_appTime.Location = new System.Drawing.Point(15, 62);
            this.lbl_appTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_appTime.Name = "lbl_appTime";
            this.lbl_appTime.Size = new System.Drawing.Size(92, 13);
            this.lbl_appTime.TabIndex = 18;
            this.lbl_appTime.Text = "Appointment Time";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(15, 24);
            this.lbl_name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(35, 13);
            this.lbl_name.TabIndex = 17;
            this.lbl_name.Text = "Name";
            // 
            // txt_appointmentTime
            // 
            this.txt_appointmentTime.Location = new System.Drawing.Point(111, 59);
            this.txt_appointmentTime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_appointmentTime.Name = "txt_appointmentTime";
            this.txt_appointmentTime.Size = new System.Drawing.Size(76, 20);
            this.txt_appointmentTime.TabIndex = 16;
            // 
            // txt_patientName
            // 
            this.txt_patientName.Location = new System.Drawing.Point(111, 22);
            this.txt_patientName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_patientName.Name = "txt_patientName";
            this.txt_patientName.Size = new System.Drawing.Size(76, 20);
            this.txt_patientName.TabIndex = 15;
            // 
            // Messages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 198);
            this.Controls.Add(this.lbl_appointmentDate);
            this.Controls.Add(this.txt_appointmentDate);
            this.Controls.Add(this.lbl_appTime);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.txt_appointmentTime);
            this.Controls.Add(this.txt_patientName);
            this.Controls.Add(this.btn_invalid);
            this.Controls.Add(this.btn_valid);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Messages";
            this.Text = "Messages";
            this.Load += new System.EventHandler(this.Messages_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_valid;
        private System.Windows.Forms.Button btn_invalid;
        private System.Windows.Forms.Label lbl_appointmentDate;
        private System.Windows.Forms.TextBox txt_appointmentDate;
        private System.Windows.Forms.Label lbl_appTime;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox txt_appointmentTime;
        private System.Windows.Forms.TextBox txt_patientName;
    }
}