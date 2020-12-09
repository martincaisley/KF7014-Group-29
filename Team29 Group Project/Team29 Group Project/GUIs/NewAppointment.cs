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
    public partial class NewAppointment : Form
    {
        int patientID;
        string appointmentType;
        public NewAppointment(int patientID)
        {
            this.patientID = patientID;
            InitializeComponent();
        }

        private void NewAppointment_Load(object sender, EventArgs e)
        {
            AppointmentTimePicker.Format = DateTimePickerFormat.Custom;
            AppointmentTimePicker.CustomFormat = "HH:mm";
            AppointmentTimePicker.ShowUpDown = true;

            AppointmentTimePicker2.Format = DateTimePickerFormat.Custom;
            AppointmentTimePicker2.CustomFormat = "HH:mm";
            AppointmentTimePicker.ShowUpDown = true;

            using (var context = new MyDBEntities())
            {
                var patients = context.Patients.ToList();
                var nameQuery = from p in patients.AsEnumerable()
                                where p.PatientID == patientID
                                select new
                                {
                                    forename = p.firstName,
                                    surname = p.lastName
                                };
                var name = nameQuery.ToList();
                txt_name.Text = name[0].forename + " " + name[0].surname;
                txt_name.ReadOnly = true;
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
        }

        private void btn_addAppointment_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new MyDBEntities())
                {
                    Appointment a = new Appointment();
                    a.patientID = patientID;
                    a.appointmentDate = datePicker.Value;
                    a.appointmentStartTime = AppointmentTimePicker.Value;
                    a.appointmentEndTime = AppointmentTimePicker2.Value;
                    a.appointmentType = AppointmentBox.ToString();

                    context.Appointments.Add(a);
                    context.SaveChanges();

                    this.Close();
                }
            }
            catch(Exception f)
            {
                Console.WriteLine("New aPp Exception");
            }

        }

        enum AppType
        {
            Checkup = 30,
            Bridges = 60,
            Crowns = 30,
            Fillings = 20,
            RootCanal = 60,
            ScaleAndPolish = 45,
            Braces = 60,
            WisdomTooth = 20,
            DentalImplants = 60,
            Dentures = 60,
            BrokenTooth = 30,
            TeethWhitening = 90,
            DentalVeneers = 120

        }

       private void ProcessRadioButton(string AppointmentT)
            {
            AppType applength = (AppType)Enum.Parse(typeof(AppType), AppointmentT);
            MessageBox.Show("Appointment Length: " + Convert.ToInt32(applength).ToString());
            int appointmentLength = Convert.ToInt32(applength);

            AppointmentTimePicker2.Value = AppointmentTimePicker.Value.AddMinutes(appointmentLength);
            }

        #region Chk box changed


        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            string appType = "";
            foreach (var RadioButton in AppointmentBox.Controls.OfType<RadioButton>())
            {
                if (RadioButton.Checked)
                {
                    appType = RadioButton.Text;
                }
            }
            ProcessRadioButton(appType);
        }



        #endregion
    }
}
