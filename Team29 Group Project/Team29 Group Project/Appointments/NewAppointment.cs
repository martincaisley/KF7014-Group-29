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
        string appointmentType;
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
            AppointmentTimePicker.ShowUpDown = true;



            radioButtonCheckUp.Checked = false;
            radioButtonBridges.Checked = false;
            radioButtonCrowns.Checked = false;
            radioButtonFillings.Checked = false;
            radioButtonRootCanal.Checked = false;
            radioButtonScaleAndPolish.Checked = false;
            radioButtonBraces.Checked = false;
            radioButtonWisdomTooth.Checked = false;
            radioButtonDentalImplants.Checked = false;
            radioButtonDentures.Checked = false;
            radioButtonBrokenTooth.Checked = false;
            radioButtonTeethWhitening.Checked = false;
            radioButtonDentalVeneers.Checked = false;
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

        public DateTime getAppointmentStartTime()
        {
            return AppointmentTimePicker.Value;
        }
        public DateTime getAppointmentEndTime()
        {
            return AppointmentTimePicker2.Value;
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
            
        }



        #endregion

       
    }
}
