
namespace AssessmentIdeas
{
    partial class AddPatient
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
            this.btn_addPatient = new System.Windows.Forms.Button();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_phoneNumber = new System.Windows.Forms.Label();
            this.lbl_address = new System.Windows.Forms.Label();
            this.lbl_addPatient = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_phoneNumber = new System.Windows.Forms.TextBox();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_addPatient
            // 
            this.btn_addPatient.Location = new System.Drawing.Point(242, 280);
            this.btn_addPatient.Name = "btn_addPatient";
            this.btn_addPatient.Size = new System.Drawing.Size(140, 23);
            this.btn_addPatient.TabIndex = 0;
            this.btn_addPatient.Text = "Add Patient";
            this.btn_addPatient.UseVisualStyleBackColor = true;
            this.btn_addPatient.Click += new System.EventHandler(this.btn_addPatient_Click);
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(38, 82);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(45, 17);
            this.lbl_name.TabIndex = 1;
            this.lbl_name.Text = "Name";
            // 
            // lbl_phoneNumber
            // 
            this.lbl_phoneNumber.AutoSize = true;
            this.lbl_phoneNumber.Location = new System.Drawing.Point(38, 150);
            this.lbl_phoneNumber.Name = "lbl_phoneNumber";
            this.lbl_phoneNumber.Size = new System.Drawing.Size(103, 17);
            this.lbl_phoneNumber.TabIndex = 2;
            this.lbl_phoneNumber.Text = "Phone Number";
            // 
            // lbl_address
            // 
            this.lbl_address.AutoSize = true;
            this.lbl_address.Location = new System.Drawing.Point(38, 114);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(60, 17);
            this.lbl_address.TabIndex = 3;
            this.lbl_address.Text = "Address";
            // 
            // lbl_addPatient
            // 
            this.lbl_addPatient.AutoSize = true;
            this.lbl_addPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lbl_addPatient.Location = new System.Drawing.Point(106, 14);
            this.lbl_addPatient.Name = "lbl_addPatient";
            this.lbl_addPatient.Size = new System.Drawing.Size(193, 39);
            this.lbl_addPatient.TabIndex = 4;
            this.lbl_addPatient.Text = "Add Patient";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(184, 77);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(100, 22);
            this.txt_name.TabIndex = 5;
            // 
            // txt_phoneNumber
            // 
            this.txt_phoneNumber.Location = new System.Drawing.Point(184, 145);
            this.txt_phoneNumber.Name = "txt_phoneNumber";
            this.txt_phoneNumber.Size = new System.Drawing.Size(100, 22);
            this.txt_phoneNumber.TabIndex = 6;
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(184, 109);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(100, 22);
            this.txt_address.TabIndex = 7;
            // 
            // AddPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 337);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.txt_phoneNumber);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.lbl_addPatient);
            this.Controls.Add(this.lbl_address);
            this.Controls.Add(this.lbl_phoneNumber);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.btn_addPatient);
            this.Name = "AddPatient";
            this.Text = "AddPatient";
            this.Load += new System.EventHandler(this.AddPatient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_addPatient;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_phoneNumber;
        private System.Windows.Forms.Label lbl_address;
        private System.Windows.Forms.Label lbl_addPatient;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_phoneNumber;
        private System.Windows.Forms.TextBox txt_address;
    }
}