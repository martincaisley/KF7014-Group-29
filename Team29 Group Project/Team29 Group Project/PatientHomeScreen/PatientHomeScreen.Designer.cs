
namespace Team29_Group_Project
{
    partial class PatientHomeScreen
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
            this.dgv_patientList = new System.Windows.Forms.DataGridView();
            this.btn_viewApps = new System.Windows.Forms.Button();
            this.btn_newPatient = new System.Windows.Forms.Button();
            this.lbl_patients = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.lbl_active = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_patientList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_patientList
            // 
            this.dgv_patientList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_patientList.Location = new System.Drawing.Point(11, 139);
            this.dgv_patientList.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_patientList.Name = "dgv_patientList";
            this.dgv_patientList.RowHeadersWidth = 51;
            this.dgv_patientList.RowTemplate.Height = 24;
            this.dgv_patientList.Size = new System.Drawing.Size(353, 263);
            this.dgv_patientList.TabIndex = 0;
            this.dgv_patientList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_patientList_CellContentClick);
            this.dgv_patientList.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_patientList_CellContentDoubleClick);
            // 
            // btn_viewApps
            // 
            this.btn_viewApps.Location = new System.Drawing.Point(11, 69);
            this.btn_viewApps.Margin = new System.Windows.Forms.Padding(2);
            this.btn_viewApps.Name = "btn_viewApps";
            this.btn_viewApps.Size = new System.Drawing.Size(109, 24);
            this.btn_viewApps.TabIndex = 1;
            this.btn_viewApps.Text = "View Appointments";
            this.btn_viewApps.UseVisualStyleBackColor = true;
            this.btn_viewApps.Click += new System.EventHandler(this.btn_viewApps_Click);
            // 
            // btn_newPatient
            // 
            this.btn_newPatient.Location = new System.Drawing.Point(133, 69);
            this.btn_newPatient.Margin = new System.Windows.Forms.Padding(2);
            this.btn_newPatient.Name = "btn_newPatient";
            this.btn_newPatient.Size = new System.Drawing.Size(109, 24);
            this.btn_newPatient.TabIndex = 2;
            this.btn_newPatient.Text = "New Patient";
            this.btn_newPatient.UseVisualStyleBackColor = true;
            this.btn_newPatient.Click += new System.EventHandler(this.btn_newPatient_Click);
            // 
            // lbl_patients
            // 
            this.lbl_patients.AutoSize = true;
            this.lbl_patients.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.lbl_patients.Location = new System.Drawing.Point(126, 7);
            this.lbl_patients.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_patients.Name = "lbl_patients";
            this.lbl_patients.Size = new System.Drawing.Size(132, 37);
            this.lbl_patients.TabIndex = 3;
            this.lbl_patients.Text = "Patients";
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(255, 69);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(2);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(109, 24);
            this.btn_delete.TabIndex = 4;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // lbl_active
            // 
            this.lbl_active.AutoSize = true;
            this.lbl_active.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbl_active.Location = new System.Drawing.Point(11, 113);
            this.lbl_active.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_active.Name = "lbl_active";
            this.lbl_active.Size = new System.Drawing.Size(131, 24);
            this.lbl_active.TabIndex = 7;
            this.lbl_active.Text = "Active Patients";
            // 
            // PatientHomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 415);
            this.Controls.Add(this.lbl_active);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.lbl_patients);
            this.Controls.Add(this.btn_newPatient);
            this.Controls.Add(this.btn_viewApps);
            this.Controls.Add(this.dgv_patientList);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PatientHomeScreen";
            this.Text = "Quick Fix Dental Clinic";
            this.Load += new System.EventHandler(this.PatientHomeScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_patientList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_patientList;
        private System.Windows.Forms.Button btn_viewApps;
        private System.Windows.Forms.Button btn_newPatient;
        private System.Windows.Forms.Label lbl_patients;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label lbl_active;
    }
}

