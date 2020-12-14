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
    public partial class PatientDetails : Form, IPatientDetailsGUI
    {
        int patientID;
        private PatientDetailsPresenter presenter;
        public PatientDetails(int patientID)
        {
            this.patientID = patientID;
            InitializeComponent();
        }
        private void PatientDetails_Load(object sender, EventArgs e)
        {
            presenter.showPatientDetails(patientID);
            presenter.showDetails(patientID);
            bool messages = presenter.getMessages(patientID);
            if (messages == false)
            {
                btn_messages.Hide();
            }
            else
            {
                btn_messages.Show();
            }
        }

        public void setLabel(string patientName)
        {
            lbl_name.Text = patientName;
        }
        private void btn_refresh_Click(object sender, EventArgs e)
        {
            presenter.showPatientDetails(patientID);
        }

        public void setDGV(DataTable dt)
        {
            if (dt.Rows.Count == 0)
            {
                dgv_patientAppointments.Hide();
                lbl_noAppointments.Text = "No Appointments";
            }
            else
            {
                dgv_patientAppointments.DataSource = dt;
                dgv_patientAppointments.AllowUserToAddRows = false;
                dgv_patientAppointments.AllowUserToDeleteRows = false;
                int cols = dgv_patientAppointments.ColumnCount;
                for (int x = 0; x < cols; x++)
                {
                    dgv_patientAppointments.Columns[x].ReadOnly = true;

                }
            }
        }

        private void btn_newAppointment_Click(object sender, EventArgs e)
        {
            NewAppointment newAppointment = new NewAppointment(patientID);
            NewAppointmentsPresenter NAP = new NewAppointmentsPresenter(newAppointment);
            this.Hide();
            newAppointment.ShowDialog();
            this.Show();
        }

        private void btn_messages_Click_1(object sender, EventArgs e)
        {
            Messages messages = new Messages(patientID);
            this.Hide();
            messages.ShowDialog();
            this.Show();
        }

        public void Register(PatientDetailsPresenter PDP)
        {
            presenter = PDP;
        }


    }
}
