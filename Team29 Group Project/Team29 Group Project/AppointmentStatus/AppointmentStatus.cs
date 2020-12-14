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
    public partial class AppointmentStatus : Form, IAppointmentStatusGUI
    {
        private AppointmentStatusPresenter presenter;
        int appointmentID;
        public AppointmentStatus(int appointmentID)
        {
            InitializeComponent();
            this.appointmentID = appointmentID;
        }

        private void AppointmentStatus_Load(object sender, EventArgs e)
        {
            presenter.getDetails(appointmentID);
        }

        public void setPatientName(string name)
        {
            txt_patientName.Text = name;
            txt_patientName.ReadOnly = true;
        }

        public void setAppointmentTime(TimeSpan appTime)
        {
            txt_appointmentTime.Text = appTime.ToString();
            txt_appointmentTime.ReadOnly = true;
        }

        private void btn_arrived_Click(object sender, EventArgs e)
        {
            MessageBox.Show(appointmentID.ToString());
            string value = "Yes";
            presenter.updateTable(appointmentID, value);
            this.Close();
        }

        private void btn_cancelledWithValidExcuse_Click(object sender, EventArgs e)
        {
            string value = "Valid";
            presenter.updateTable(appointmentID, value);
            this.Close();
        }
        
        public void Register(AppointmentStatusPresenter ASP)
        {
            presenter = ASP;
        }
    }
}
