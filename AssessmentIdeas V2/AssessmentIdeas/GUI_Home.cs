using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KF7014_Group_29_Assignment
{
    public partial class GUI_home : Form
    {
        public GUI_home()
        {
            InitializeComponent();
           
            
        }

        private void BTN_Registration_MouseClick(object sender, MouseEventArgs e)
        {
            var patientGUI = new PatientFormGUI();
            patientGUI.Show();
            
        }
    }
}
