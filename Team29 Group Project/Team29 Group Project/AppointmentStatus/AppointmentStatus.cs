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
        string appointmentStatus;
        public AppointmentStatus(int appointmentID)
        {
            InitializeComponent();
            this.appointmentID = appointmentID;
        }

        private void AppointmentStatus_Load(object sender, EventArgs e)
        {

        }

        public int getAppointmentID()
        {
            return appointmentID;
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

        public void setAppointmentCost(double cost)
        {
            txt_cost.Text = "£" + cost.ToString() + "0";
            txt_cost.ReadOnly = true;
        }

        public string getAppointmentStatus()
        {
            return appointmentStatus;
        }

        private void btn_arrived_Click(object sender, EventArgs e)
        {
            appointmentStatus = "Yes";
            presenter.updateTable();
            this.Close();
        }

        private void btn_cancelledWithValidExcuse_Click(object sender, EventArgs e)
        {
            appointmentStatus = "Valid";
            presenter.updateTable();
            this.Close();
        }

        public void Register(AppointmentStatusPresenter ASP)
        {
            presenter = ASP;
        }
    }
}
