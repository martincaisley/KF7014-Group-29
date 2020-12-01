
namespace AssessmentIdeas
{
    partial class NewAppointment
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
            this.lbl_title = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_time = new System.Windows.Forms.TextBox();
            this.txt_date = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_time = new System.Windows.Forms.Label();
            this.btn_addAppointment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.lbl_title.Location = new System.Drawing.Point(12, 9);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(326, 46);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Add Appointment";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(140, 84);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(100, 22);
            this.txt_name.TabIndex = 1;
            // 
            // txt_time
            // 
            this.txt_time.Location = new System.Drawing.Point(140, 140);
            this.txt_time.Name = "txt_time";
            this.txt_time.Size = new System.Drawing.Size(100, 22);
            this.txt_time.TabIndex = 2;
            // 
            // txt_date
            // 
            this.txt_date.Location = new System.Drawing.Point(140, 112);
            this.txt_date.Name = "txt_date";
            this.txt_date.Size = new System.Drawing.Size(100, 22);
            this.txt_date.TabIndex = 3;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(63, 84);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(45, 17);
            this.lbl_name.TabIndex = 4;
            this.lbl_name.Text = "Name";
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Location = new System.Drawing.Point(63, 115);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(38, 17);
            this.lbl_date.TabIndex = 5;
            this.lbl_date.Text = "Date";
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Location = new System.Drawing.Point(63, 145);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(39, 17);
            this.lbl_time.TabIndex = 6;
            this.lbl_time.Text = "Time";
            // 
            // btn_addAppointment
            // 
            this.btn_addAppointment.Location = new System.Drawing.Point(66, 178);
            this.btn_addAppointment.Name = "btn_addAppointment";
            this.btn_addAppointment.Size = new System.Drawing.Size(174, 23);
            this.btn_addAppointment.TabIndex = 7;
            this.btn_addAppointment.Text = "Add Appointment";
            this.btn_addAppointment.UseVisualStyleBackColor = true;
            this.btn_addAppointment.Click += new System.EventHandler(this.btn_addAppointment_Click);
            // 
            // NewAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 228);
            this.Controls.Add(this.btn_addAppointment);
            this.Controls.Add(this.lbl_time);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.txt_date);
            this.Controls.Add(this.txt_time);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.lbl_title);
            this.Name = "NewAppointment";
            this.Text = "NewAppointment";
            this.Load += new System.EventHandler(this.NewAppointment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_time;
        private System.Windows.Forms.TextBox txt_date;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Button btn_addAppointment;
    }
}