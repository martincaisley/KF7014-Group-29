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
    public partial class PatientDetails : Form
    {
        int patientID;
        string patientName;
        public PatientDetails(int patientID)
        {
            this.patientID = patientID;
            InitializeComponent();
        }
        private void PatientDetails_Load(object sender, EventArgs e)
        {
            using (var context = new MyDBEntities())
            {
                var patients = context.Patients.ToList();
                updateDGV();
                var nameQuery = from p in patients.AsEnumerable()
                                where p.PatientID == patientID
                                select new
                                {
                                    name = p.PatientName
                                };
                var name = nameQuery.ToList();
                patientName = name[0].name;
                lbl_name.Text = patientName;
            }
        }
        
        private void btn_refresh_Click(object sender, EventArgs e)
        {
            updateDGV();
        }

        private void updateDGV()
        {
            using (var context = new MyDBEntities())
            {
                var appointments = context.Appointments.ToList();

                DataTable dt = new DataTable();
                dt.Columns.Add("Appointment Date", typeof(string));
                dt.Columns.Add("Appointment Time", typeof(string));

                var appointmentQuery = from a in appointments.AsEnumerable()
                                   where a.patientID == patientID
                                   select dt.LoadDataRow(new object[]
                                   {
                                   a.appointmentDate,
                                   a.appointmentTime
                                   }, false);
                try
                {
                    appointmentQuery.CopyToDataTable();
                    dgv_patientAppointments.DataSource = dt;
                    dgv_patientAppointments.AllowUserToAddRows = false;
                    dgv_patientAppointments.AllowUserToDeleteRows = false;
                    int cols = dgv_patientAppointments.ColumnCount;
                    for (int x = 0; x < cols; x++)
                    {
                        dgv_patientAppointments.Columns[x].ReadOnly = true;

                    }
                }
                catch 
                {
                    dgv_patientAppointments.Hide();
                    lbl_noAppointments.Text = "No Appointments";
                }
            }
        }

        private void btn_newAppointment_Click(object sender, EventArgs e) 
        {
            NewAppointment newAppointment = new NewAppointment(patientID);
            this.Hide();
            newAppointment.ShowDialog();
            this.Show();
        }

        private void txt_messages_Click(object sender, EventArgs e)
        {
            Messages messages = new Messages();
            this.Hide();
            messages.ShowDialog();
            this.Show();
        }
    }
}
