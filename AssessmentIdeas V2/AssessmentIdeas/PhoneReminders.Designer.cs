
namespace AssessmentIdeas
{
    partial class PhoneReminders
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
            this.lbl_phoneReminders = new System.Windows.Forms.Label();
            this.dgv_phoneReminders = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_phoneReminders)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_phoneReminders
            // 
            this.lbl_phoneReminders.AutoSize = true;
            this.lbl_phoneReminders.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.lbl_phoneReminders.Location = new System.Drawing.Point(12, 9);
            this.lbl_phoneReminders.Name = "lbl_phoneReminders";
            this.lbl_phoneReminders.Size = new System.Drawing.Size(339, 46);
            this.lbl_phoneReminders.TabIndex = 0;
            this.lbl_phoneReminders.Text = "Phone Reminders";
            // 
            // dgv_phoneReminders
            // 
            this.dgv_phoneReminders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_phoneReminders.Location = new System.Drawing.Point(20, 58);
            this.dgv_phoneReminders.Name = "dgv_phoneReminders";
            this.dgv_phoneReminders.RowHeadersWidth = 51;
            this.dgv_phoneReminders.RowTemplate.Height = 24;
            this.dgv_phoneReminders.Size = new System.Drawing.Size(416, 368);
            this.dgv_phoneReminders.TabIndex = 1;
            this.dgv_phoneReminders.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // PhoneReminders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 450);
            this.Controls.Add(this.dgv_phoneReminders);
            this.Controls.Add(this.lbl_phoneReminders);
            this.Name = "PhoneReminders";
            this.Text = "PhoneReminders";
            this.Load += new System.EventHandler(this.PhoneReminders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_phoneReminders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_phoneReminders;
        private System.Windows.Forms.DataGridView dgv_phoneReminders;
    }
}