
namespace AssessmentIdeas
{
    partial class ContactedByPhone
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
            this.btn_contacted = new System.Windows.Forms.Button();
            this.lbl_appTime = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.txt_appointmentTime = new System.Windows.Forms.TextBox();
            this.txt_patientName = new System.Windows.Forms.TextBox();
            this.lbl_appStatus = new System.Windows.Forms.Label();
            this.lbl_appointmentDate = new System.Windows.Forms.Label();
            this.txt_appointmentDate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_contacted
            // 
            this.btn_contacted.Location = new System.Drawing.Point(189, 214);
            this.btn_contacted.Name = "btn_contacted";
            this.btn_contacted.Size = new System.Drawing.Size(100, 23);
            this.btn_contacted.TabIndex = 12;
            this.btn_contacted.Text = "Contacted";
            this.btn_contacted.UseVisualStyleBackColor = true;
            // 
            // lbl_appTime
            // 
            this.lbl_appTime.AutoSize = true;
            this.lbl_appTime.Location = new System.Drawing.Point(61, 136);
            this.lbl_appTime.Name = "lbl_appTime";
            this.lbl_appTime.Size = new System.Drawing.Size(122, 17);
            this.lbl_appTime.TabIndex = 11;
            this.lbl_appTime.Text = "Appointment Time";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(61, 90);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(45, 17);
            this.lbl_name.TabIndex = 10;
            this.lbl_name.Text = "Name";
            // 
            // txt_appointmentTime
            // 
            this.txt_appointmentTime.Location = new System.Drawing.Point(189, 133);
            this.txt_appointmentTime.Name = "txt_appointmentTime";
            this.txt_appointmentTime.Size = new System.Drawing.Size(100, 22);
            this.txt_appointmentTime.TabIndex = 9;
            // 
            // txt_patientName
            // 
            this.txt_patientName.Location = new System.Drawing.Point(189, 87);
            this.txt_patientName.Name = "txt_patientName";
            this.txt_patientName.Size = new System.Drawing.Size(100, 22);
            this.txt_patientName.TabIndex = 8;
            // 
            // lbl_appStatus
            // 
            this.lbl_appStatus.AutoSize = true;
            this.lbl_appStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.lbl_appStatus.Location = new System.Drawing.Point(12, 9);
            this.lbl_appStatus.Name = "lbl_appStatus";
            this.lbl_appStatus.Size = new System.Drawing.Size(368, 46);
            this.lbl_appStatus.TabIndex = 7;
            this.lbl_appStatus.Text = "Appointment Status";
            // 
            // lbl_appointmentDate
            // 
            this.lbl_appointmentDate.AutoSize = true;
            this.lbl_appointmentDate.Location = new System.Drawing.Point(61, 177);
            this.lbl_appointmentDate.Name = "lbl_appointmentDate";
            this.lbl_appointmentDate.Size = new System.Drawing.Size(121, 17);
            this.lbl_appointmentDate.TabIndex = 14;
            this.lbl_appointmentDate.Text = "Appointment Date";
            // 
            // txt_appointmentDate
            // 
            this.txt_appointmentDate.Location = new System.Drawing.Point(189, 174);
            this.txt_appointmentDate.Name = "txt_appointmentDate";
            this.txt_appointmentDate.Size = new System.Drawing.Size(100, 22);
            this.txt_appointmentDate.TabIndex = 13;
            // 
            // ContactedByPhone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 261);
            this.Controls.Add(this.lbl_appointmentDate);
            this.Controls.Add(this.txt_appointmentDate);
            this.Controls.Add(this.btn_contacted);
            this.Controls.Add(this.lbl_appTime);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.txt_appointmentTime);
            this.Controls.Add(this.txt_patientName);
            this.Controls.Add(this.lbl_appStatus);
            this.Name = "ContactedByPhone";
            this.Text = "ContactedByPhone";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_contacted;
        private System.Windows.Forms.Label lbl_appTime;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox txt_appointmentTime;
        private System.Windows.Forms.TextBox txt_patientName;
        private System.Windows.Forms.Label lbl_appStatus;
        private System.Windows.Forms.Label lbl_appointmentDate;
        private System.Windows.Forms.TextBox txt_appointmentDate;
    }
}