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
    public partial class AddPatient : Form, IAddPatientGUI
    {
        private AddPatientPresenter presenter;

        public AddPatient()
        {
            InitializeComponent();
        }

        private void btn_addPatient_Click(object sender, EventArgs e)
        {
            presenter.updateView();
            this.Close();
        }

        private void AddPatient_Load(object sender, EventArgs e)
        {

        }
        public void setName(String name)
        {
            txt_name.Text = name;
        }
        public String getName()
        {
            return txt_name.Text;
        }
        public void setAddress(String address)
        {
            txt_address.Text = address;
        }
        public String getAddress()
        {
            return txt_address.Text;
        }
        public void setPhoneNumber(String phoneNumber)
        {
            txt_phoneNumber.Text = phoneNumber;
        }
        public String getPhoneNumber()
        {
            return txt_phoneNumber.Text;   
        }

        public void Register(AddPatientPresenter APP)
        {
            presenter = APP;
        }
    }
}
