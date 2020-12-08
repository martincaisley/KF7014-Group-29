
namespace Team29_Group_Project
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
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_time = new System.Windows.Forms.Label();
            this.btn_addAppointment = new System.Windows.Forms.Button();
            this.AppointmentBox = new System.Windows.Forms.GroupBox();
            this.radioButtonDentalVeneers = new System.Windows.Forms.RadioButton();
            this.radioButtonTeethWhitening = new System.Windows.Forms.RadioButton();
            this.radioButtonBrokenTooth = new System.Windows.Forms.RadioButton();
            this.radioButtonDentures = new System.Windows.Forms.RadioButton();
            this.radioButtonDentalImplants = new System.Windows.Forms.RadioButton();
            this.radioButtonWisdomTooth = new System.Windows.Forms.RadioButton();
            this.radioButtonBraces = new System.Windows.Forms.RadioButton();
            this.radioButtonScaleAndPolish = new System.Windows.Forms.RadioButton();
            this.radioButtonRootCanal = new System.Windows.Forms.RadioButton();
            this.radioButtonFillings = new System.Windows.Forms.RadioButton();
            this.radioButtonCrowns = new System.Windows.Forms.RadioButton();
            this.radioButtonBridges = new System.Windows.Forms.RadioButton();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.radioButtonCheckUp = new System.Windows.Forms.RadioButton();
            this.AppointmentBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.lbl_title.Location = new System.Drawing.Point(9, 7);
            this.lbl_title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(265, 37);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Add Appointment";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(105, 68);
            this.txt_name.Margin = new System.Windows.Forms.Padding(2);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(76, 20);
            this.txt_name.TabIndex = 1;
            // 
            // txt_time
            // 
            this.txt_time.Location = new System.Drawing.Point(105, 118);
            this.txt_time.Margin = new System.Windows.Forms.Padding(2);
            this.txt_time.Name = "txt_time";
            this.txt_time.Size = new System.Drawing.Size(76, 20);
            this.txt_time.TabIndex = 2;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(28, 68);
            this.lbl_name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(35, 13);
            this.lbl_name.TabIndex = 4;
            this.lbl_name.Text = "Name";
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Location = new System.Drawing.Point(28, 93);
            this.lbl_date.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(30, 13);
            this.lbl_date.TabIndex = 5;
            this.lbl_date.Text = "Date";
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Location = new System.Drawing.Point(28, 118);
            this.lbl_time.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(30, 13);
            this.lbl_time.TabIndex = 6;
            this.lbl_time.Text = "Time";
            // 
            // btn_addAppointment
            // 
            this.btn_addAppointment.Location = new System.Drawing.Point(63, 320);
            this.btn_addAppointment.Margin = new System.Windows.Forms.Padding(2);
            this.btn_addAppointment.Name = "btn_addAppointment";
            this.btn_addAppointment.Size = new System.Drawing.Size(130, 26);
            this.btn_addAppointment.TabIndex = 7;
            this.btn_addAppointment.Text = "Add Appointment";
            this.btn_addAppointment.UseVisualStyleBackColor = true;
            this.btn_addAppointment.Click += new System.EventHandler(this.btn_addAppointment_Click);
            // 
            // AppointmentBox
            // 
            this.AppointmentBox.Controls.Add(this.radioButtonCheckUp);
            this.AppointmentBox.Controls.Add(this.radioButtonDentalVeneers);
            this.AppointmentBox.Controls.Add(this.radioButtonTeethWhitening);
            this.AppointmentBox.Controls.Add(this.radioButtonBrokenTooth);
            this.AppointmentBox.Controls.Add(this.radioButtonDentures);
            this.AppointmentBox.Controls.Add(this.radioButtonDentalImplants);
            this.AppointmentBox.Controls.Add(this.radioButtonWisdomTooth);
            this.AppointmentBox.Controls.Add(this.radioButtonBraces);
            this.AppointmentBox.Controls.Add(this.radioButtonScaleAndPolish);
            this.AppointmentBox.Controls.Add(this.radioButtonRootCanal);
            this.AppointmentBox.Controls.Add(this.radioButtonFillings);
            this.AppointmentBox.Controls.Add(this.radioButtonCrowns);
            this.AppointmentBox.Controls.Add(this.radioButtonBridges);
            this.AppointmentBox.Location = new System.Drawing.Point(12, 139);
            this.AppointmentBox.Name = "AppointmentBox";
            this.AppointmentBox.Size = new System.Drawing.Size(247, 176);
            this.AppointmentBox.TabIndex = 8;
            this.AppointmentBox.TabStop = false;
            this.AppointmentBox.Text = "Appointment Type";
            // 
            // radioButtonDentalVeneers
            // 
            this.radioButtonDentalVeneers.AutoSize = true;
            this.radioButtonDentalVeneers.Location = new System.Drawing.Point(142, 134);
            this.radioButtonDentalVeneers.Name = "radioButtonDentalVeneers";
            this.radioButtonDentalVeneers.Size = new System.Drawing.Size(98, 17);
            this.radioButtonDentalVeneers.TabIndex = 22;
            this.radioButtonDentalVeneers.TabStop = true;
            this.radioButtonDentalVeneers.Text = "Dental Veneers";
            this.radioButtonDentalVeneers.UseVisualStyleBackColor = true;
            this.radioButtonDentalVeneers.CheckedChanged += new System.EventHandler(this.radioButtonDentalVeneers_CheckedChanged);
            // 
            // radioButtonTeethWhitening
            // 
            this.radioButtonTeethWhitening.AutoSize = true;
            this.radioButtonTeethWhitening.Location = new System.Drawing.Point(142, 111);
            this.radioButtonTeethWhitening.Name = "radioButtonTeethWhitening";
            this.radioButtonTeethWhitening.Size = new System.Drawing.Size(104, 17);
            this.radioButtonTeethWhitening.TabIndex = 21;
            this.radioButtonTeethWhitening.TabStop = true;
            this.radioButtonTeethWhitening.Text = "Teeth Whitening";
            this.radioButtonTeethWhitening.UseVisualStyleBackColor = true;
            this.radioButtonTeethWhitening.CheckedChanged += new System.EventHandler(this.radioButtonTeethWhitening_CheckedChanged);
            // 
            // radioButtonBrokenTooth
            // 
            this.radioButtonBrokenTooth.AutoSize = true;
            this.radioButtonBrokenTooth.Location = new System.Drawing.Point(142, 88);
            this.radioButtonBrokenTooth.Name = "radioButtonBrokenTooth";
            this.radioButtonBrokenTooth.Size = new System.Drawing.Size(90, 17);
            this.radioButtonBrokenTooth.TabIndex = 20;
            this.radioButtonBrokenTooth.TabStop = true;
            this.radioButtonBrokenTooth.Text = "Broken Tooth";
            this.radioButtonBrokenTooth.UseVisualStyleBackColor = true;
            this.radioButtonBrokenTooth.CheckedChanged += new System.EventHandler(this.radioButtonBrokenTooth_CheckedChanged);
            // 
            // radioButtonDentures
            // 
            this.radioButtonDentures.AutoSize = true;
            this.radioButtonDentures.Location = new System.Drawing.Point(142, 65);
            this.radioButtonDentures.Name = "radioButtonDentures";
            this.radioButtonDentures.Size = new System.Drawing.Size(68, 17);
            this.radioButtonDentures.TabIndex = 19;
            this.radioButtonDentures.TabStop = true;
            this.radioButtonDentures.Text = "Dentures";
            this.radioButtonDentures.UseVisualStyleBackColor = true;
            this.radioButtonDentures.CheckedChanged += new System.EventHandler(this.radioButtonDentures_CheckedChanged);
            // 
            // radioButtonDentalImplants
            // 
            this.radioButtonDentalImplants.AutoSize = true;
            this.radioButtonDentalImplants.Location = new System.Drawing.Point(142, 42);
            this.radioButtonDentalImplants.Name = "radioButtonDentalImplants";
            this.radioButtonDentalImplants.Size = new System.Drawing.Size(98, 17);
            this.radioButtonDentalImplants.TabIndex = 18;
            this.radioButtonDentalImplants.TabStop = true;
            this.radioButtonDentalImplants.Text = "Dental Implants";
            this.radioButtonDentalImplants.UseVisualStyleBackColor = true;
            this.radioButtonDentalImplants.CheckedChanged += new System.EventHandler(this.radioButtonDentalImplants_CheckedChanged);
            // 
            // radioButtonWisdomTooth
            // 
            this.radioButtonWisdomTooth.AutoSize = true;
            this.radioButtonWisdomTooth.Location = new System.Drawing.Point(142, 19);
            this.radioButtonWisdomTooth.Name = "radioButtonWisdomTooth";
            this.radioButtonWisdomTooth.Size = new System.Drawing.Size(94, 17);
            this.radioButtonWisdomTooth.TabIndex = 17;
            this.radioButtonWisdomTooth.TabStop = true;
            this.radioButtonWisdomTooth.Text = "Wisdom Tooth";
            this.radioButtonWisdomTooth.UseVisualStyleBackColor = true;
            this.radioButtonWisdomTooth.CheckedChanged += new System.EventHandler(this.radioButtonWisdomTooth_CheckedChanged);
            // 
            // radioButtonBraces
            // 
            this.radioButtonBraces.AutoSize = true;
            this.radioButtonBraces.Location = new System.Drawing.Point(4, 153);
            this.radioButtonBraces.Name = "radioButtonBraces";
            this.radioButtonBraces.Size = new System.Drawing.Size(58, 17);
            this.radioButtonBraces.TabIndex = 16;
            this.radioButtonBraces.TabStop = true;
            this.radioButtonBraces.Text = "Braces";
            this.radioButtonBraces.UseVisualStyleBackColor = true;
            this.radioButtonBraces.CheckedChanged += new System.EventHandler(this.radioButtonBraces_CheckedChanged);
            // 
            // radioButtonScaleAndPolish
            // 
            this.radioButtonScaleAndPolish.AutoSize = true;
            this.radioButtonScaleAndPolish.Location = new System.Drawing.Point(6, 130);
            this.radioButtonScaleAndPolish.Name = "radioButtonScaleAndPolish";
            this.radioButtonScaleAndPolish.Size = new System.Drawing.Size(104, 17);
            this.radioButtonScaleAndPolish.TabIndex = 15;
            this.radioButtonScaleAndPolish.TabStop = true;
            this.radioButtonScaleAndPolish.Text = "Scale and Polish";
            this.radioButtonScaleAndPolish.UseVisualStyleBackColor = true;
            this.radioButtonScaleAndPolish.CheckedChanged += new System.EventHandler(this.radioButtonScaleAndPolish_CheckedChanged);
            // 
            // radioButtonRootCanal
            // 
            this.radioButtonRootCanal.AutoSize = true;
            this.radioButtonRootCanal.Location = new System.Drawing.Point(6, 107);
            this.radioButtonRootCanal.Name = "radioButtonRootCanal";
            this.radioButtonRootCanal.Size = new System.Drawing.Size(78, 17);
            this.radioButtonRootCanal.TabIndex = 14;
            this.radioButtonRootCanal.TabStop = true;
            this.radioButtonRootCanal.Text = "Root Canal";
            this.radioButtonRootCanal.UseVisualStyleBackColor = true;
            this.radioButtonRootCanal.CheckedChanged += new System.EventHandler(this.radioButtonRootCanal_CheckedChanged);
            // 
            // radioButtonFillings
            // 
            this.radioButtonFillings.AutoSize = true;
            this.radioButtonFillings.Location = new System.Drawing.Point(6, 84);
            this.radioButtonFillings.Name = "radioButtonFillings";
            this.radioButtonFillings.Size = new System.Drawing.Size(56, 17);
            this.radioButtonFillings.TabIndex = 13;
            this.radioButtonFillings.TabStop = true;
            this.radioButtonFillings.Text = "Fillings";
            this.radioButtonFillings.UseVisualStyleBackColor = true;
            this.radioButtonFillings.CheckedChanged += new System.EventHandler(this.radioButtonFillings_CheckedChanged);
            // 
            // radioButtonCrowns
            // 
            this.radioButtonCrowns.AutoSize = true;
            this.radioButtonCrowns.Location = new System.Drawing.Point(6, 61);
            this.radioButtonCrowns.Name = "radioButtonCrowns";
            this.radioButtonCrowns.Size = new System.Drawing.Size(60, 17);
            this.radioButtonCrowns.TabIndex = 12;
            this.radioButtonCrowns.TabStop = true;
            this.radioButtonCrowns.Text = "Crowns";
            this.radioButtonCrowns.UseVisualStyleBackColor = true;
            this.radioButtonCrowns.CheckedChanged += new System.EventHandler(this.radioButtonCrowns_CheckedChanged);
            // 
            // radioButtonBridges
            // 
            this.radioButtonBridges.AutoSize = true;
            this.radioButtonBridges.Location = new System.Drawing.Point(6, 39);
            this.radioButtonBridges.Name = "radioButtonBridges";
            this.radioButtonBridges.Size = new System.Drawing.Size(60, 17);
            this.radioButtonBridges.TabIndex = 10;
            this.radioButtonBridges.TabStop = true;
            this.radioButtonBridges.Text = "Bridges";
            this.radioButtonBridges.UseVisualStyleBackColor = true;
            this.radioButtonBridges.CheckedChanged += new System.EventHandler(this.radioButtonBridges_CheckedChanged);
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(105, 93);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(130, 20);
            this.datePicker.TabIndex = 9;
            // 
            // radioButtonCheckUp
            // 
            this.radioButtonCheckUp.AutoSize = true;
            this.radioButtonCheckUp.Location = new System.Drawing.Point(6, 19);
            this.radioButtonCheckUp.Name = "radioButtonCheckUp";
            this.radioButtonCheckUp.Size = new System.Drawing.Size(70, 17);
            this.radioButtonCheckUp.TabIndex = 23;
            this.radioButtonCheckUp.TabStop = true;
            this.radioButtonCheckUp.Text = "CheckUp";
            this.radioButtonCheckUp.UseVisualStyleBackColor = true;
            // 
            // NewAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 357);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.AppointmentBox);
            this.Controls.Add(this.btn_addAppointment);
            this.Controls.Add(this.lbl_time);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.txt_time);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.lbl_title);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "NewAppointment";
            this.Text = "NewAppointment";
            this.Load += new System.EventHandler(this.NewAppointment_Load);
            this.AppointmentBox.ResumeLayout(false);
            this.AppointmentBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_time;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Button btn_addAppointment;
        private System.Windows.Forms.GroupBox AppointmentBox;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.RadioButton radioButtonBridges;
        private System.Windows.Forms.RadioButton radioButtonFillings;
        private System.Windows.Forms.RadioButton radioButtonCrowns;
        private System.Windows.Forms.RadioButton radioButtonBraces;
        private System.Windows.Forms.RadioButton radioButtonScaleAndPolish;
        private System.Windows.Forms.RadioButton radioButtonRootCanal;
        private System.Windows.Forms.RadioButton radioButtonDentalVeneers;
        private System.Windows.Forms.RadioButton radioButtonTeethWhitening;
        private System.Windows.Forms.RadioButton radioButtonBrokenTooth;
        private System.Windows.Forms.RadioButton radioButtonDentures;
        private System.Windows.Forms.RadioButton radioButtonDentalImplants;
        private System.Windows.Forms.RadioButton radioButtonWisdomTooth;
        private System.Windows.Forms.RadioButton radioButtonCheckUp;
    }
}
