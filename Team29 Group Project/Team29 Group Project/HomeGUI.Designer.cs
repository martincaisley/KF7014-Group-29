namespace Team29_Group_Project
{
    partial class HomeGUI
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
            this.DGV_patientList = new System.Windows.Forms.DataGridView();
            this.BTN_registerPatient = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_patientList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(215, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quick Fix Dental Practice";
            // 
            // DGV_patientList
            // 
            this.DGV_patientList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_patientList.Location = new System.Drawing.Point(222, 85);
            this.DGV_patientList.Name = "DGV_patientList";
            this.DGV_patientList.Size = new System.Drawing.Size(368, 336);
            this.DGV_patientList.TabIndex = 1;
            // 
            // BTN_registerPatient
            // 
            this.BTN_registerPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_registerPatient.Location = new System.Drawing.Point(22, 85);
            this.BTN_registerPatient.Name = "BTN_registerPatient";
            this.BTN_registerPatient.Size = new System.Drawing.Size(170, 76);
            this.BTN_registerPatient.TabIndex = 2;
            this.BTN_registerPatient.Text = "Register a patient";
            this.BTN_registerPatient.UseVisualStyleBackColor = true;
            this.BTN_registerPatient.Click += new System.EventHandler(this.BTN_registerPatient_Click);
            // 
            // HomeGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTN_registerPatient);
            this.Controls.Add(this.DGV_patientList);
            this.Controls.Add(this.label1);
            this.Name = "HomeGUI";
            this.Text = "HomeGUI";
            this.Load += new System.EventHandler(this.HomeGUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_patientList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGV_patientList;
        private System.Windows.Forms.Button BTN_registerPatient;
    }
}