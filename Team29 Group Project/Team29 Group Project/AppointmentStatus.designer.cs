
namespace Team29_Group_Project
{
    partial class AppointmentStatus
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
            this.lbl_appStatus = new System.Windows.Forms.Label();
            this.txt_patientName = new System.Windows.Forms.TextBox();
            this.txt_appointmentTime = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_appTime = new System.Windows.Forms.Label();
            this.btn_arrived = new System.Windows.Forms.Button();
            this.btn_cancelledWithValidExcuse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_appStatus
            // 
            this.lbl_appStatus.AutoSize = true;
            this.lbl_appStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.lbl_appStatus.Location = new System.Drawing.Point(9, 7);
            this.lbl_appStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_appStatus.Name = "lbl_appStatus";
            this.lbl_appStatus.Size = new System.Drawing.Size(298, 37);
            this.lbl_appStatus.TabIndex = 0;
            this.lbl_appStatus.Text = "Appointment Status";
            // 
            // txt_patientName
            // 
            this.txt_patientName.Location = new System.Drawing.Point(142, 71);
            this.txt_patientName.Margin = new System.Windows.Forms.Padding(2);
            this.txt_patientName.Name = "txt_patientName";
            this.txt_patientName.Size = new System.Drawing.Size(76, 20);
            this.txt_patientName.TabIndex = 1;
            // 
            // txt_appointmentTime
            // 
            this.txt_appointmentTime.Location = new System.Drawing.Point(142, 108);
            this.txt_appointmentTime.Margin = new System.Windows.Forms.Padding(2);
            this.txt_appointmentTime.Name = "txt_appointmentTime";
            this.txt_appointmentTime.Size = new System.Drawing.Size(76, 20);
            this.txt_appointmentTime.TabIndex = 2;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(46, 73);
            this.lbl_name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(35, 13);
            this.lbl_name.TabIndex = 3;
            this.lbl_name.Text = "Name";
            // 
            // lbl_appTime
            // 
            this.lbl_appTime.AutoSize = true;
            this.lbl_appTime.Location = new System.Drawing.Point(46, 110);
            this.lbl_appTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_appTime.Name = "lbl_appTime";
            this.lbl_appTime.Size = new System.Drawing.Size(92, 13);
            this.lbl_appTime.TabIndex = 4;
            this.lbl_appTime.Text = "Appointment Time";
            // 
            // btn_arrived
            // 
            this.btn_arrived.Location = new System.Drawing.Point(49, 145);
            this.btn_arrived.Margin = new System.Windows.Forms.Padding(2);
            this.btn_arrived.Name = "btn_arrived";
            this.btn_arrived.Size = new System.Drawing.Size(169, 19);
            this.btn_arrived.TabIndex = 5;
            this.btn_arrived.Text = "Arrived";
            this.btn_arrived.UseVisualStyleBackColor = true;
            this.btn_arrived.Click += new System.EventHandler(this.btn_arrived_Click);
            // 
            // btn_cancelledWithValidExcuse
            // 
            this.btn_cancelledWithValidExcuse.Location = new System.Drawing.Point(49, 168);
            this.btn_cancelledWithValidExcuse.Margin = new System.Windows.Forms.Padding(2);
            this.btn_cancelledWithValidExcuse.Name = "btn_cancelledWithValidExcuse";
            this.btn_cancelledWithValidExcuse.Size = new System.Drawing.Size(169, 19);
            this.btn_cancelledWithValidExcuse.TabIndex = 6;
            this.btn_cancelledWithValidExcuse.Text = "Cancelled With Valid Excuse";
            this.btn_cancelledWithValidExcuse.UseVisualStyleBackColor = true;
            this.btn_cancelledWithValidExcuse.Click += new System.EventHandler(this.btn_cancelledWithValidExcuse_Click);
            // 
            // AppointmentStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 209);
            this.Controls.Add(this.btn_cancelledWithValidExcuse);
            this.Controls.Add(this.btn_arrived);
            this.Controls.Add(this.lbl_appTime);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.txt_appointmentTime);
            this.Controls.Add(this.txt_patientName);
            this.Controls.Add(this.lbl_appStatus);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AppointmentStatus";
            this.Text = "AppointmentStatus";
            this.Load += new System.EventHandler(this.AppointmentStatus_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_appStatus;
        private System.Windows.Forms.TextBox txt_patientName;
        private System.Windows.Forms.TextBox txt_appointmentTime;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_appTime;
        private System.Windows.Forms.Button btn_arrived;
        private System.Windows.Forms.Button btn_cancelledWithValidExcuse;
    }
}