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
    public partial class AppointmentStatus : Form
    {
        int appointmentID;
        public AppointmentStatus(int appointmentID)
        {
            InitializeComponent();
            this.appointmentID = appointmentID;
        }

        private void AppointmentStatus_Load(object sender, EventArgs e)
        {
            using (var context = new MyDBEntities())
            {
                var appointments = context.Appointments.ToList();
                var patients = context.Patients.ToList();
                var appQuery = from a in appointments.AsEnumerable()
                               join p in patients.AsEnumerable()
                               on a.patientID equals p.PatientID
                               where a.appointmentID == appointmentID
                               select new
                               {
                                   patID = a.patientID,
                                   appointmentStartTime = a.appointmentStartTime,
                                   forename = p.firstName,
                                   surname = p.lastName
                               };
                var appointment = appQuery.ToList();
                txt_appointmentTime.Text = appointment[0].appointmentStartTime.ToString();
                txt_appointmentTime.ReadOnly = true;
                txt_patientName.Text = appointment[0].forename + " " + appointment[0].surname;
                txt_patientName.ReadOnly = true;
            }
        }

        private void btn_arrived_Click(object sender, EventArgs e)
        {
            string value = "Yes";
            updateTable(value);
            this.Close();
        }

        private void btn_cancelledWithValidExcuse_Click(object sender, EventArgs e)
        {
            string value = "Valid";
            updateTable(value);
            this.Close();
        }
        private void updateTable(string value)
        {
            using (var context = new MyDBEntities())
            {
                //https://stackoverflow.com/questions/20832684/update-records-using-linq
                (from a in context.Appointments
                 where a.appointmentID == appointmentID
                 select a).ToList().ForEach(x => x.arrivedToAppointment = value);
                context.SaveChanges();
            }
        }
    }
}
