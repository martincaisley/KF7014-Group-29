
namespace Team29_Group_Project
{
    partial class PatientDetails
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
            this.lbl_name = new System.Windows.Forms.Label();
            this.dgv_patientAppointments = new System.Windows.Forms.DataGridView();
            this.btn_newAppointment = new System.Windows.Forms.Button();
            this.BTN_medicalQuestionnaire = new System.Windows.Forms.Button();
            this.btn_messages = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.lbl_noAppointments = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_patientAppointments)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lbl_name.Location = new System.Drawing.Point(9, 7);
            this.lbl_name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(86, 31);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "Name";
            // 
            // dgv_patientAppointments
            // 
            this.dgv_patientAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_patientAppointments.Location = new System.Drawing.Point(14, 50);
            this.dgv_patientAppointments.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_patientAppointments.Name = "dgv_patientAppointments";
            this.dgv_patientAppointments.RowHeadersWidth = 51;
            this.dgv_patientAppointments.RowTemplate.Height = 24;
            this.dgv_patientAppointments.Size = new System.Drawing.Size(249, 296);
            this.dgv_patientAppointments.TabIndex = 1;
            // 
            // btn_newAppointment
            // 
            this.btn_newAppointment.Location = new System.Drawing.Point(289, 50);
            this.btn_newAppointment.Margin = new System.Windows.Forms.Padding(2);
            this.btn_newAppointment.Name = "btn_newAppointment";
            this.btn_newAppointment.Size = new System.Drawing.Size(98, 50);
            this.btn_newAppointment.TabIndex = 2;
            this.btn_newAppointment.Text = "New Appointment";
            this.btn_newAppointment.UseVisualStyleBackColor = true;
            this.btn_newAppointment.Click += new System.EventHandler(this.btn_newAppointment_Click);
            // 
            // BTN_medicalQuestionnaire
            // 
            this.BTN_medicalQuestionnaire.Location = new System.Drawing.Point(289, 121);
            this.BTN_medicalQuestionnaire.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_medicalQuestionnaire.Name = "BTN_medicalQuestionnaire";
            this.BTN_medicalQuestionnaire.Size = new System.Drawing.Size(98, 50);
            this.BTN_medicalQuestionnaire.TabIndex = 3;
            this.BTN_medicalQuestionnaire.Text = "Medical Record";
            this.BTN_medicalQuestionnaire.UseVisualStyleBackColor = true;
            this.BTN_medicalQuestionnaire.Click += new System.EventHandler(this.BTN_medicalQuestionnaire_Click);
            // 
            // btn_messages
            // 
            this.btn_messages.BackColor = System.Drawing.Color.Red;
            this.btn_messages.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_messages.ForeColor = System.Drawing.Color.White;
            this.btn_messages.Location = new System.Drawing.Point(292, 296);
            this.btn_messages.Margin = new System.Windows.Forms.Padding(2);
            this.btn_messages.Name = "btn_messages";
            this.btn_messages.Size = new System.Drawing.Size(98, 50);
            this.btn_messages.TabIndex = 4;
            this.btn_messages.Text = "Attention -  User missed previous appointment";
            this.btn_messages.UseVisualStyleBackColor = false;
            this.btn_messages.Click += new System.EventHandler(this.btn_messages_Click_1);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(289, 188);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(2);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(98, 50);
            this.btn_delete.TabIndex = 5;
            this.btn_delete.Text = "Delete Appointment";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // lbl_noAppointments
            // 
            this.lbl_noAppointments.AutoSize = true;
            this.lbl_noAppointments.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lbl_noAppointments.Location = new System.Drawing.Point(50, 54);
            this.lbl_noAppointments.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_noAppointments.Name = "lbl_noAppointments";
            this.lbl_noAppointments.Size = new System.Drawing.Size(0, 29);
            this.lbl_noAppointments.TabIndex = 6;
            // 
            // PatientDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 373);
            this.Controls.Add(this.lbl_noAppointments);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_messages);
            this.Controls.Add(this.BTN_medicalQuestionnaire);
            this.Controls.Add(this.btn_newAppointment);
            this.Controls.Add(this.dgv_patientAppointments);
            this.Controls.Add(this.lbl_name);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PatientDetails";
            this.Text = "PatientDetails";
            this.Load += new System.EventHandler(this.PatientDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_patientAppointments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.DataGridView dgv_patientAppointments;
        private System.Windows.Forms.Button btn_newAppointment;
        private System.Windows.Forms.Button BTN_medicalQuestionnaire;
        private System.Windows.Forms.Button btn_messages;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label lbl_noAppointments;
    }
}