using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssessmentIdeas
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
                                    name = p.PatientName
                                };
                var name = nameQuery.ToList();
                txt_name.Text = name[0].name;
                txt_name.ReadOnly = true;
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
                a.appointmentType = appointmentType;

                context.Appointments.Add(a);
                context.SaveChanges();

                this.Close();
            }
        }


        #region Chk box changed

        private void radioButtonBridges_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonBridges.Checked)
            {
                appointmentType = "Bridges";
            }
        }

        private void radioButtonCrowns_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonBridges.Checked)
            {
                appointmentType = "Crowns";
            }
        }

        private void radioButtonFillings_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonBridges.Checked)
            {
                appointmentType = "Fillings";
            }
        }

        private void radioButtonRootCanal_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonBridges.Checked)
            {
                appointmentType = "Root Canal";
            }
        }

        private void radioButtonScaleAndPolish_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonBridges.Checked)
            {
                appointmentType = "Scale and Polish";
            }
        }

        private void radioButtonBraces_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonBridges.Checked)
            {
                appointmentType = "Braces";
            }
        }

        private void radioButtonWisdomTooth_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonBridges.Checked)
            {
                appointmentType = "Wisdom Tooth";
            }
        }

        private void radioButtonDentalImplants_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonBridges.Checked)
            {
                appointmentType = "Dental Implants";
            }
        }

        private void radioButtonDentures_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonBridges.Checked)
            {
                appointmentType = "Dentures";
            }
        }

        private void radioButtonBrokenTooth_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonBridges.Checked)
            {
                appointmentType = "Broken Tooth";
            }
        }

        private void radioButtonTeethWhitening_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonBridges.Checked)
            {
                appointmentType = "Teeth Whitening";
            }
        }

        private void radioButtonDentalVeneers_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonBridges.Checked)
            {
                appointmentType = "Dental Veneers";
            }
        }

        #endregion
    }
}
