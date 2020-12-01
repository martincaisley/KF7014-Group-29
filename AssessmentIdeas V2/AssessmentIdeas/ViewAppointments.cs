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
    public partial class ViewAppointments : Form
    {
        public ViewAppointments()
        {
            InitializeComponent();
        }
        private void ViewAppointments_Load(object sender, EventArgs e)
        {
            updateDGV();
        }
        private void updateDGV()
        {
            using (var context = new MyDBEntities())
            {
                var patients = context.Patients.ToList();
                var appointments = context.Appointments.ToList();

                DataTable dt = new DataTable();
                dt.Columns.Add("Patient Name", typeof(string));
                dt.Columns.Add("Appointment Date", typeof(string));
                dt.Columns.Add("Appointment Time", typeof(string));

                var appointmentQuery = from a in appointments.AsEnumerable()
                                       join p in patients.AsEnumerable()
                                       on a.patientID equals p.PatientID
                                       select dt.LoadDataRow(new object[]
                                       {
                                   p.PatientName,
                                   a.appointmentDate,
                                   a.appointmentTime
                                       }, false);

                appointmentQuery.CopyToDataTable();
                dgv_appointmentList.DataSource = dt;
                dgv_appointmentList.AllowUserToAddRows = false;
                dgv_appointmentList.AllowUserToDeleteRows = false;
                int cols = dgv_appointmentList.ColumnCount;
                for (int x = 0; x < cols; x++)
                {
                    dgv_appointmentList.Columns[x].ReadOnly = true;
                }
            }
        }
        private void btn_phoneReminders_Click(object sender, EventArgs e)
        {
            PhoneReminders phoneReminders = new PhoneReminders();
            this.Hide();
            phoneReminders.ShowDialog();
            this.Show();
        }

        private void dgv_appointmentList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            AppointmentStatus appointmentStatus = new AppointmentStatus();
            this.Hide();
            appointmentStatus.ShowDialog();
            this.Show();
        }

        private void dgv_appointmentList_Click(object sender, EventArgs e)
        {
            AppointmentStatus appointmentStatus = new AppointmentStatus();
            this.Hide();
            appointmentStatus.ShowDialog();
            this.Show();
        }

        private void btn_textReminders_Click(object sender, EventArgs e)
        {
            using (var context = new MyDBEntities())
            {
                List<string> csv = new List<string>();

                var patients = context.Patients.ToList();
                var appointments = context.Appointments.ToList();
                string fileName = "TextReminders";
                var appointmentList = (from a in appointments.AsEnumerable()
                                       join p in patients.AsEnumerable()
                                       on a.patientID equals p.PatientID
                                       select new
                                       {
                                   p.PatientName,
                                   p.PatientPhoneNumber,
                                   a.appointmentDate,
                                   a.appointmentTime,
                                       });
                
                foreach(var a in appointmentList)
                {
                    string row = a.PatientName + "," + a.PatientPhoneNumber + "," + a.appointmentDate + "," + a.appointmentTime + ",";
                    csv.Add(row);
                }
                string filePath = @"C:\Users\markb\Documents\Masters\Advanced Programming\Assessment\AssessmentIdeas V2\AppointmentTextReminders\" + fileName + ".txt";
                System.IO.File.WriteAllLines(filePath, csv);
            }
        }
    }
}
