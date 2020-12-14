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
        private void updateDGV()
        {
            try
            {
                using (var context = new MyDBEntities())
                {
                    var patients = context.Patients.ToList();
                    var appointments = context.Appointments.ToList();
                    DataTable dt = new DataTable();
                    dt.Columns.Add("Patient Forename", typeof(string));
                    dt.Columns.Add("Patient Surname", typeof(string));
                    dt.Columns.Add("Patient Phone Number", typeof(string));
                    dt.Columns.Add("Appointment Date", typeof(DateTime));
                    dt.Columns.Add("Appointment Start Time", typeof(TimeSpan));
                    dt.Columns.Add("Appointment End Time", typeof(TimeSpan));
                    dt.Columns.Add("Appointment Length", typeof(int));
                    dt.Columns.Add("Appointment Type", typeof(string));

                    var phoneQuery = from a in appointments.AsEnumerable()
                                     join p in patients.AsEnumerable()
                                     on a.patientID equals p.PatientID
                                     select dt.LoadDataRow(new object[]
                                     {
                                    p.firstName,
                                    p.lastName,
                                    p.PhoneNum,
                                    a.appointmentDate,
                                    a.appointmentStartTime,
                                    a.appointmentEndTime,
                                    a.appointmentLength,
                                    a.appointmentType
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
            catch
            {

            }
        }

        private void dgv_phoneReminders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            rowSelcted(dgv_phoneReminders.CurrentCell.RowIndex);
        }

        private void dgv_phoneReminders_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            rowSelcted(dgv_phoneReminders.CurrentCell.RowIndex);
        }
        private void rowSelcted(int index)
        {
            using (var context = new MyDBEntities())
            {
                var appointments = context.Appointments.ToList();
                int appointmentID = appointments[index].appointmentID;
                ContactedByPhone contactedByPhone = new ContactedByPhone(appointmentID);
                ContactedByPhonePresenter CBPP = new ContactedByPhonePresenter(contactedByPhone);
                this.Hide();
                contactedByPhone.ShowDialog();
                //code to refresh
                this.Show();
            }
        }
    }
}
