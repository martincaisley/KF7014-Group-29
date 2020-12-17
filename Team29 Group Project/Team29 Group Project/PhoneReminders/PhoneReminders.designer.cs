
namespace Team29_Group_Project
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
            this.lbl_phoneReminders.Location = new System.Drawing.Point(9, 7);
            this.lbl_phoneReminders.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_phoneReminders.Name = "lbl_phoneReminders";
            this.lbl_phoneReminders.Size = new System.Drawing.Size(271, 37);
            this.lbl_phoneReminders.TabIndex = 0;
            this.lbl_phoneReminders.Text = "Phone Reminders";
            // 
            // dgv_phoneReminders
            // 
            this.dgv_phoneReminders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_phoneReminders.Location = new System.Drawing.Point(15, 47);
            this.dgv_phoneReminders.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_phoneReminders.Name = "dgv_phoneReminders";
            this.dgv_phoneReminders.RowHeadersWidth = 51;
            this.dgv_phoneReminders.RowTemplate.Height = 24;
            this.dgv_phoneReminders.Size = new System.Drawing.Size(312, 299);
            this.dgv_phoneReminders.TabIndex = 1;
            this.dgv_phoneReminders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_phoneReminders_CellClick);
            this.dgv_phoneReminders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_phoneReminders_CellContentClick);
            this.dgv_phoneReminders.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_phoneReminders_CellContentDoubleClick);
            // 
            // PhoneReminders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 366);
            this.Controls.Add(this.dgv_phoneReminders);
            this.Controls.Add(this.lbl_phoneReminders);
            this.Margin = new System.Windows.Forms.Padding(2);
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