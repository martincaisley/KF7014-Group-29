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
        private NewAppointmentsPresenter presenter;
        int patientID;
        string appType = "";
        public NewAppointment(int patientID)
        {
            this.patientID = patientID;
            InitializeComponent();
        }

        private void NewAppointment_Load(object sender, EventArgs e)
        {
            presenter.getPatientName(patientID);

            AppointmentTimePicker.Format = DateTimePickerFormat.Custom;
            AppointmentTimePicker.CustomFormat = "HH:mm";
            AppointmentTimePicker.ShowUpDown = true;

            AppointmentTimePicker2.Format = DateTimePickerFormat.Custom;
            AppointmentTimePicker2.CustomFormat = "HH:mm";
            AppointmentTimePicker2.ShowUpDown = true;            
        }

        public void setName(string name)
        {
            txt_name.Text = name;
            txt_name.ReadOnly = true;
        }

        public DateTime getAppointmentDate()
        {
            return datePicker.Value;
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
            AppointmentTimePicker2.Value = AppointmentTimePicker.Value.AddMinutes(appointmentLength);
        }

        public void Register(NewAppointmentsPresenter NAP)
        {
            presenter = NAP;
        }

        private void btn_addAppointment_Click(object sender, EventArgs e)
        {
            presenter.processAppointment();
            MessageBox.Show("Appointment Added");
            this.Close();
        }

        #region Chk box changed

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {

            foreach (var RadioButton in AppointmentBox.Controls.OfType<RadioButton>())
            {
                if (RadioButton.Checked)
                {
                    appType = RadioButton.Text;
                }
            }
            presenter.setAppType(appType);

        }



        #endregion


    }
}
