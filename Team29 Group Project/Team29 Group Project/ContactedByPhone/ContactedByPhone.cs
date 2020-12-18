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
    public partial class ContactedByPhone : Form, IContactedByPhoneGUI
    {
        private ContactedByPhonePresenter presenter;
        int appointmentID;
        public ContactedByPhone(int appointmentID)
        {
            this.appointmentID = appointmentID;
            InitializeComponent();
        }

        private void ContactedByPhone_Load(object sender, EventArgs e)
        {

        }

        public int getAppointmentID()
        {
            return appointmentID;
        }

        public void setPatientName(string name)
        {
            txt_patientName.Text = name;
        }

        public void setAppointmentDate(DateTime date)
        {
            txt_appointmentDate.Text = date.ToString();
        }

        public void setAppointmentTime(TimeSpan time)
        {
            txt_appointmentTime.Text = time.ToString();
        }

        private void btn_contacted_Click(object sender, EventArgs e)
        {
            presenter.setContacted();
            this.Close();
        }
        public void Register(ContactedByPhonePresenter CBPP)
        {
            presenter = CBPP;
        }
    }
}
