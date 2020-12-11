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
            try
            {
                //DataTable dt = new DataTable();

                using (var context = new MyDBEntities())
                {
                    var patients = context.Patients.ToList();
                    var appointments = context.Appointments.ToList();

                    DataTable dt = new DataTable();
                    dt.Columns.Add("Patient Forename", typeof(string));
                    dt.Columns.Add("Patient Surname", typeof(string));
                    dt.Columns.Add("Appointment Date", typeof(DateTime));
                    dt.Columns.Add("Appointment Start Time", typeof(DateTime));
                    dt.Columns.Add("Appointment End Time", typeof(DateTime));
                    dt.Columns.Add("Appointment Type", typeof(string));
                    dt.Columns.Add("Appointment Length", typeof(int));

                    var appointmentQuery = from a in appointments.AsEnumerable()
                                           join p in patients.AsEnumerable()
                                           on a.patientID equals p.PatientID
                                           select dt.LoadDataRow(new object[]
                                           {
                                   p.firstName,
                                   p.lastName,
                                   a.appointmentDate,
                                   a.appointmentStartTime,
                                   a.appointmentEndTime,
                                   a.appointmentType,
                                   a.appointmentLength
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
            catch
            {

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
            rowSelcted(dgv_appointmentList.CurrentCell.RowIndex);
        }

        private void dgv_appointmentList_Click(object sender, EventArgs e)
        {
            rowSelcted(dgv_appointmentList.CurrentCell.RowIndex);
        }

        private void rowSelcted(int index)
        {
            using (var context = new MyDBEntities())
            {
                var appointments = context.Appointments.ToList();
                int appointmentID = appointments[index].appointmentID;
                AppointmentStatus appointmentStatus = new AppointmentStatus(appointmentID);
                this.Hide();
                appointmentStatus.ShowDialog();
                this.Show();
            }
        }

        private void btn_textReminders_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Reminders File Created");
            
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
                                   p.firstName,
                                   p.lastName,
                                   p.PhoneNum,
                                   a.appointmentDate,
                                   a.appointmentStartTime,
                                   a.appointmentEndTime,
                                   a.appointmentLength,
                                   a.appointmentType
                                       });
                
                foreach(var a in appointmentList)
                {
                    string row = a.firstName + "," + a.lastName + ", " + a.PhoneNum + ", " + a.appointmentDate + "," 
                        + a.appointmentStartTime + "," + a.appointmentEndTime + "," + a.appointmentLength + "," + a.appointmentType;
                    csv.Add(row);
                }
                string filePath = @"C:\Users\markb\Documents\Masters\Advanced Programming\Assessment\Github\Team29 Group Project\AppointmentTextReminders\" + fileName + ".txt";
                System.IO.File.WriteAllLines(filePath, csv);
            }
            
        }
    }
}
