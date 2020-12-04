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
    public partial class HomeGUI : Form
    {
        public HomeGUI()
        {
            InitializeComponent();
        }

        private void HomeGUI_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Hello");
        }

        private void BTN_registerPatient_Click(object sender, EventArgs e)
        {
            PatientRegistrationGUI pr = new PatientRegistrationGUI();
            pr.Show();
        }
    }
}
