
namespace AssessmentIdeas
{
    partial class ViewAppointments
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
            this.lbl_appointments = new System.Windows.Forms.Label();
            this.lbl_today = new System.Windows.Forms.Label();
            this.dgv_appointmentList = new System.Windows.Forms.DataGridView();
            this.btn_phoneReminders = new System.Windows.Forms.Button();
            this.btn_textReminders = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_appointmentList)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_appointments
            // 
            this.lbl_appointments.AutoSize = true;
            this.lbl_appointments.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.lbl_appointments.Location = new System.Drawing.Point(89, 9);
            this.lbl_appointments.Name = "lbl_appointments";
            this.lbl_appointments.Size = new System.Drawing.Size(264, 46);
            this.lbl_appointments.TabIndex = 0;
            this.lbl_appointments.Text = "Appointments";
            // 
            // lbl_today
            // 
            this.lbl_today.AutoSize = true;
            this.lbl_today.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbl_today.Location = new System.Drawing.Point(12, 96);
            this.lbl_today.Name = "lbl_today";
            this.lbl_today.Size = new System.Drawing.Size(81, 29);
            this.lbl_today.TabIndex = 1;
            this.lbl_today.Text = "Today";
            // 
            // dgv_appointmentList
            // 
            this.dgv_appointmentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_appointmentList.Location = new System.Drawing.Point(20, 149);
            this.dgv_appointmentList.Name = "dgv_appointmentList";
            this.dgv_appointmentList.RowHeadersWidth = 51;
            this.dgv_appointmentList.RowTemplate.Height = 24;
            this.dgv_appointmentList.Size = new System.Drawing.Size(313, 289);
            this.dgv_appointmentList.TabIndex = 2;
            this.dgv_appointmentList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_appointmentList_CellContentClick);
            this.dgv_appointmentList.Click += new System.EventHandler(this.dgv_appointmentList_Click);
            // 
            // btn_phoneReminders
            // 
            this.btn_phoneReminders.Location = new System.Drawing.Point(345, 149);
            this.btn_phoneReminders.Name = "btn_phoneReminders";
            this.btn_phoneReminders.Size = new System.Drawing.Size(109, 44);
            this.btn_phoneReminders.TabIndex = 3;
            this.btn_phoneReminders.Text = "Get Phone Reminders";
            this.btn_phoneReminders.UseVisualStyleBackColor = true;
            this.btn_phoneReminders.Click += new System.EventHandler(this.btn_phoneReminders_Click);
            // 
            // btn_textReminders
            // 
            this.btn_textReminders.Location = new System.Drawing.Point(345, 214);
            this.btn_textReminders.Name = "btn_textReminders";
            this.btn_textReminders.Size = new System.Drawing.Size(109, 44);
            this.btn_textReminders.TabIndex = 4;
            this.btn_textReminders.Text = "Get Text Reminders";
            this.btn_textReminders.UseVisualStyleBackColor = true;
            this.btn_textReminders.Click += new System.EventHandler(this.btn_textReminders_Click);
            // 
            // ViewAppointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 450);
            this.Controls.Add(this.btn_textReminders);
            this.Controls.Add(this.btn_phoneReminders);
            this.Controls.Add(this.dgv_appointmentList);
            this.Controls.Add(this.lbl_today);
            this.Controls.Add(this.lbl_appointments);
            this.Name = "ViewAppointments";
            this.Text = "ViewAppointments";
            this.Load += new System.EventHandler(this.ViewAppointments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_appointmentList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_appointments;
        private System.Windows.Forms.Label lbl_today;
        private System.Windows.Forms.DataGridView dgv_appointmentList;
        private System.Windows.Forms.Button btn_phoneReminders;
        private System.Windows.Forms.Button btn_textReminders;
    }
}