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
                txt_name.Text = name[0].ToString();
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
            using (var context = new MyDBEntities())
            {
                Appointment a = new Appointment();
                a.patientID = patientID;
                a.appointmentDate = datePicker.Text;
                a.appointmentTime = txt_time.Text;
                a.appointmentType = AppointmentBox.ToString();

                context.Appointments.Add(a);
                context.SaveChanges();

                this.Close();
            }
        }

        enum AppType
        {
            CheckUp = 10,
            Bridge = 10,
            Crown = 10,
            Filling = 10,
            RootCanal = 10,
            ScaleAndPolish = 10,
            Braces = 10,
            WisdomTooth = 10,
            DentalImplants = 10,
            Dentures = 10,
            BrokenTooth = 10,
            TeethWhitening = 10,
            DentalVeneers = 10

        }


        #region Chk box changed

       private void radioButtonCheckUp_CheckedChanged(object sender, EventArgs e)
       {
            string appointmentType = "CheckUp";
            AppType applength = (AppType)Enum.Parse(typeof(AppType), appointmentType);
            MessageBox.Show("Appointment Length: " + Convert.ToInt32(applength).ToString());
            
       }


        private void radioButtonBridges_CheckedChanged(object sender, EventArgs e)
        {
            string appointmentType = "Bridge";
            AppType applength = (AppType)Enum.Parse(typeof(AppType), appointmentType);
            MessageBox.Show("Appointment Length: " + Convert.ToInt32(applength).ToString());

        }

        private void radioButtonCrowns_CheckedChanged(object sender, EventArgs e)
        {
            string appointmentType = "Crown";
            AppType applength = (AppType)Enum.Parse(typeof(AppType), appointmentType);
            MessageBox.Show("Appointment Length: " + Convert.ToInt32(applength).ToString());
        }

        private void radioButtonFillings_CheckedChanged(object sender, EventArgs e)
        {
            string appointmentType = "Filling";
            AppType applength = (AppType)Enum.Parse(typeof(AppType), appointmentType);
            MessageBox.Show("Appointment Length: " + Convert.ToInt32(applength).ToString());
        }

        private void radioButtonRootCanal_CheckedChanged(object sender, EventArgs e)
        {
            string appointmentType = "RootCanal";
            AppType applength = (AppType)Enum.Parse(typeof(AppType), appointmentType);
            MessageBox.Show("Appointment Length: " + Convert.ToInt32(applength).ToString());
        }

        private void radioButtonScaleAndPolish_CheckedChanged(object sender, EventArgs e)
        {
            string appointmentType = "ScaleAndPolish";
            AppType applength = (AppType)Enum.Parse(typeof(AppType), appointmentType);
            MessageBox.Show("Appointment Length: " + Convert.ToInt32(applength).ToString());
        }

        private void radioButtonBraces_CheckedChanged(object sender, EventArgs e)
        {
            string appointmentType = "Braces";
            AppType applength = (AppType)Enum.Parse(typeof(AppType), appointmentType);
            MessageBox.Show("Appointment Length: " + Convert.ToInt32(applength).ToString());
        }

        private void radioButtonWisdomTooth_CheckedChanged(object sender, EventArgs e)
        {
            string appointmentType = "WisdomTooth";
            AppType applength = (AppType)Enum.Parse(typeof(AppType), appointmentType);
            MessageBox.Show("Appointment Length: " + Convert.ToInt32(applength).ToString());
        }

        private void radioButtonDentalImplants_CheckedChanged(object sender, EventArgs e)
        {
            string appointmentType = "DentalImplants";
            AppType applength = (AppType)Enum.Parse(typeof(AppType), appointmentType);
            MessageBox.Show("Appointment Length: " + Convert.ToInt32(applength).ToString());
        }

        private void radioButtonDentures_CheckedChanged(object sender, EventArgs e)
        {
            string appointmentType = "Dentures";
            AppType applength = (AppType)Enum.Parse(typeof(AppType), appointmentType);
            MessageBox.Show("Appointment Length: " + Convert.ToInt32(applength).ToString());
        }

        private void radioButtonBrokenTooth_CheckedChanged(object sender, EventArgs e)
        {
            string appointmentType = "BrokenTooth";
            AppType applength = (AppType)Enum.Parse(typeof(AppType), appointmentType);
            MessageBox.Show("Appointment Length: " + Convert.ToInt32(applength).ToString());
        }

        private void radioButtonTeethWhitening_CheckedChanged(object sender, EventArgs e)
        {
            string appointmentType = "TeethWhitening";
            AppType applength = (AppType)Enum.Parse(typeof(AppType), appointmentType);
            MessageBox.Show("Appointment Length: " + Convert.ToInt32(applength).ToString());
        }

        private void radioButtonDentalVeneers_CheckedChanged(object sender, EventArgs e)
        {
            string appointmentType = "DentalVeneers";
            AppType applength = (AppType)Enum.Parse(typeof(AppType), appointmentType);
            MessageBox.Show("Appointment Length: " + Convert.ToInt32(applength).ToString());
        }

        #endregion
    }
}
