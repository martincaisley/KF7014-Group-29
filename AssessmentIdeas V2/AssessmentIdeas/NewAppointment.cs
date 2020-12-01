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
    }
}
