using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Team29_Group_Project
{
    public partial class NewAppointment : Form, INewAppointmentsGUI
    {
        #region Instance Variables
        private NewAppointmentsPresenter presenter;
        int patientID;
        string appType = "";
        #endregion

        #region Constructor and FormLoad
        public NewAppointment(int patientID)
        {
            this.patientID = patientID;
            InitializeComponent();
        }

        private void NewAppointment_Load(object sender, EventArgs e)
        {
        }
        #endregion

        #region Getters and Setters
        public void setName(string name)
        {
            txt_name.Text = name;
            txt_name.ReadOnly = true;
        }

        public DateTime getAppointmentDate()
        {
            return datePicker.Value.Date;
        }

        public TimeSpan getAppointmentStartTime()
        {
            return AppointmentTimePicker.Value.TimeOfDay;
        }
        public TimeSpan getAppointmentEndTime()
        {
            return AppointmentTimePicker2.Value.TimeOfDay;
        }

        public int getPatientID()
        {
            return patientID;
        }

        public string getAppointmentType()
        {
            return appType;
        }

        public void setAppointmentEndTime(int appointmentLength)
        {
            //inspired by http://zetcode.com/csharp/datetime/
            AppointmentTimePicker2.Value = AppointmentTimePicker.Value.AddMinutes(appointmentLength);
        }

        public void Register(NewAppointmentsPresenter NAP)
        {
            presenter = NAP;
        }

        public void setDGV(DataTable DT)
        {
            DGV_AddApp.DataSource = DT;
            DGV_AddApp.AllowUserToAddRows = false;
            DGV_AddApp.AllowUserToDeleteRows = false;
            int cols = DGV_AddApp.ColumnCount;
            for (int x = 0; x < cols; x++)
            {
                DGV_AddApp.Columns[x].ReadOnly = true;
            }
        }
        #endregion

        #region TimePickerSet

        public void setTimePickers()
        {
            AppointmentTimePicker.Format = DateTimePickerFormat.Custom;
            AppointmentTimePicker.CustomFormat = "HH:mm";
            AppointmentTimePicker.Value = DateTime.Parse("09:00:00");
            AppointmentTimePicker.ShowUpDown = true;

            AppointmentTimePicker2.Format = DateTimePickerFormat.Custom;
            AppointmentTimePicker2.CustomFormat = "HH:mm";
            AppointmentTimePicker2.Value = DateTime.Parse("09:00:00");
            AppointmentTimePicker2.ShowUpDown = true;
        }

        #endregion

        #region Add Appointment
        private void btn_addAppointment_Click(object sender, EventArgs e)
        {
            if (AppTypeValidation() && dateValidation() && timeValidation())
            {
                bool inWorkingHours = presenter.checkInWorkingHours(AppointmentTimePicker.Value.TimeOfDay, AppointmentTimePicker2.Value.TimeOfDay);
                if (inWorkingHours)
                {
                    bool emergencyAppointment = presenter.checkEmergency(datePicker.Value.Date, AppointmentTimePicker.Value.TimeOfDay, AppointmentTimePicker2.Value.TimeOfDay);
                    if (emergencyAppointment == true)
                    {
                        bool canBook = presenter.checkTime(datePicker.Value.Date, AppointmentTimePicker.Value.TimeOfDay, AppointmentTimePicker2.Value.TimeOfDay);
                        if (canBook == false)
                        {
                            MessageBox.Show("Appointment already booked for this time");
                        }
                        else
                        {
                            presenter.processAppointment();
                            MessageBox.Show("Appointment Added");
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("These time slots are reserved");
                    }
                }
                else
                {
                    MessageBox.Show("Choose an appointment in working hours 9-5");
                }
            }
        }

        #endregion

        #region Radio botton changed

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            foreach (var RadioButton in AppointmentBox.Controls.OfType<RadioButton>())
            {
                if (RadioButton.Checked)
                {
                    appType = RadioButton.Text;   
                }
            }
            presenter.setAppLength(appType);
        }

        #endregion


        #region Validation
        private bool AppTypeValidation()
        {
            foreach (var RadioButton in AppointmentBox.Controls.OfType<RadioButton>())
            {
                if (RadioButton.Checked)
                {
                    return true;
                }
            }
            MessageBox.Show("An Appointment type has not been chosen.");
            return false;
        }

        private bool dateValidation()
        {
            if (datePicker.Value < DateTime.Today.Date)
            {
                MessageBox.Show("Appointment date cannot be before today");
                datePicker.Value = DateTime.Today.Date;
                return false;
            }
            return true;
        }
        private bool timeValidation()
        {
            if (AppointmentTimePicker2.Value < AppointmentTimePicker.Value)
            {
                MessageBox.Show("Appointment end time cannot be before start time");
                return false;
            }
            return true;
        }

        #endregion

        #region DatePicker Changed
        private void datePicker_ValueChanged(object sender, EventArgs e)
        {
            presenter.showAppointmentList(datePicker.Value.Date);
        }
        #endregion
    }
}
