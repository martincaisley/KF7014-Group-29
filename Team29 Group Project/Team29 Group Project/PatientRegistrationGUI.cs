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
    public partial class PatientRegistrationGUI : Form
    {
        public PatientRegistrationGUI()
        {
            InitializeComponent();
        }

        private void BTN_medQuestionnaire_Click(object sender, EventArgs e)
        {
            MedicalQuestionnaireGUI med = new MedicalQuestionnaireGUI();
            med.Show();
        }
    }
}
