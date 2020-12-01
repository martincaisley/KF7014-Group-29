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
    public partial class PhoneReminders : Form
    {
        public PhoneReminders()
        {
            InitializeComponent();
        }
        private void PhoneReminders_Load(object sender, EventArgs e)
        {
            updateDGV();
        }
        private void dataGridView1_Click(object sender, EventArgs e)
        {
            ContactedByPhone contactedByPhone = new ContactedByPhone();
            this.Hide();
            contactedByPhone.ShowDialog();
            this.Show();
        }
        private void updateDGV()
        {
            using (var context = new MyDBEntities())
            {
                var patients = context.Patients.ToList();
                var appointments = context.Appointments.ToList();
                DataTable dt = new DataTable();
                dt.Columns.Add("Patient Name", typeof(string));
                dt.Columns.Add("Patient Number", typeof(string));
                dt.Columns.Add("Appointment Date", typeof(string));
                dt.Columns.Add("Appointment Time", typeof(string));

                var phoneQuery = from a in appointments.AsEnumerable()
                                 join p in patients.AsEnumerable()
                                 on a.patientID equals p.PatientID
                                 select dt.LoadDataRow(new object[]
                                 {
                                       p.PatientName,
                                       p.PatientPhoneNumber,
                                       a.appointmentDate,
                                       a.appointmentTime
                                 }, false);
                phoneQuery.CopyToDataTable();
                dgv_phoneReminders.DataSource = dt;
                dgv_phoneReminders.AllowUserToAddRows = false;
                dgv_phoneReminders.AllowUserToDeleteRows = false;
                int cols = dgv_phoneReminders.ColumnCount;
                for (int x = 0; x < cols; x++)
                {
                    dgv_phoneReminders.Columns[x].ReadOnly = true;
                }
            }
        }

        
    }
}
