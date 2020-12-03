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
                checkBoxBridges.Checked = false;
                checkBoxCrowns.Checked = false;
                checkBoxFillings.Checked = false;
                checkBoxRootCanal.Checked = false;
                checkBoxScaleAndPolish.Checked = false;
                checkBoxBraces.Checked = false;
                checkBoxWisdomTooth.Checked = false;
                checkBoxDentalImplants.Checked = false;
                checkBoxDentures.Checked = false;
                checkBoxBrokenTooth.Checked = false;
                checkBoxTeethWhitening.Checked = false;
                checkBoxDentalVeneers.Checked = false;
        
            }
        }

        private void btn_addAppointment_Click(object sender, EventArgs e)
        {
            using (var context = new MyDBEntities())
            {
                Appointment a = new Appointment();
                a.patientID = patientID;
                a.appointmentDate = txt_date.Text;
                a.appointmentTime = txt_time.Text;

                context.Appointments.Add(a);
                context.SaveChanges();

                this.Close();
            }
        }

           #region Chk box changed

        private void checkBoxBridges_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxCrowns_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxFillings_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxRootCanal_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxScaleAndPolish_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void checkBoxBraces_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxWisdomTooth_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxDentalImplants_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxDentures_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxBrokenTooth_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxTeethWhitening_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxDentalVeneers_CheckedChanged(object sender, EventArgs e)
        {

        }

        #endregion
    }
}
