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

            String appointmentType = AppointmentType.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text;

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

        

        #endregion
    }
}
