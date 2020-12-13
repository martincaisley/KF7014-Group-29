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
    public partial class Messages : Form
    {
        int patientID;
        int appointmentID;
        public Messages(int patientID)
        {
            this.patientID = patientID;
            InitializeComponent();
        }
        private void Messages_Load(object sender, EventArgs e)
        {
            using (var context = new MyDBEntities())
            {
                var appointments = context.Appointments.ToList();
                var patients = context.Patients.ToList();
                var appQuery = from a in appointments.AsEnumerable()
                               join p in patients.AsEnumerable()
                               on a.patientID equals p.PatientID
                               where p.PatientID == patientID && a.arrivedToAppointment == "No" && a.appointmentDate < DateTime.Today
                               select new
                               {
                                   appointmentID = a.appointmentID,
                                   forename = p.firstName,
                                   surname = p.lastName,
                                   appointmentDate = a.appointmentDate,
                                   appointmentStartTime = a.appointmentStartTime
                               };
                var appointment = appQuery.ToList();
                if (appointment.Count() == 0)
                {
                    txt_patientName.Text = "No Messages";
                    txt_patientName.ReadOnly = true;
                }
                else
                {
                    txt_appointmentTime.Text = appointment[0].appointmentStartTime.ToString();
                    txt_appointmentTime.ReadOnly = true;
                    txt_patientName.Text = appointment[0].forename + " " + appointment[0].surname;
                    txt_patientName.ReadOnly = true;
                    txt_appointmentDate.Text = appointment[0].appointmentDate.ToString();
                    txt_appointmentDate.ReadOnly = true;
                    appointmentID = appointment[0].appointmentID;
                }
            }
        }
        private bool checkForRepeatOffence()
        {
            using (var context = new MyDBEntities())
            {
                var appointments = context.Appointments.ToList();
                var repeatAppQuery = from a in appointments.AsEnumerable()
                                     where a.patientID == patientID && a.arrivedToAppointment == "Invalid" && a.appointmentDate >= DateTime.Today.AddYears(-3)
                                     group a by a.patientID into grouped
                                     select new
                                     {
                                         count = grouped.Count()
                                     };
                var offences = repeatAppQuery.ToList();
                int numberOfOffences = offences[0].count;

                if (numberOfOffences == 3)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        private void btn_invalid_Click(object sender, EventArgs e)
        {
            string value = "Invalid";
            updateTable(value);
            bool repeatOffence = checkForRepeatOffence();
            if (repeatOffence == true)
            {
                MessageBox.Show("Patient needs to be removed");
            }
            else
            {
                this.Close();
            }

        }

        private void btn_valid_Click(object sender, EventArgs e)
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
