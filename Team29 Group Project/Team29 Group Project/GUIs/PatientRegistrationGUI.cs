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

        private void PatientRegistrationGUI_Load(object sender, EventArgs e)
        {
            DateValidation();
        }

        private void BTN_medQuestionnaire_Click(object sender, EventArgs e)
        {
            MedicalQuestionnaireGUI med = new MedicalQuestionnaireGUI();
            med.Show();
        }

        private void BTN_addPatient_MouseClick(object sender, MouseEventArgs e)
        {
            TextValidation(TXT_fname);
            TextValidation(TXT_sname);
            TextValidation(TXT_address);
            TextValidation(TXT_email);
            TextValidation(TXT_GPname);
            TextValidation(TXT_GPaddress);
            OccupationValidation();
           

        }

        private void TextValidation(TextBox tb)
        {
            if(string.IsNullOrWhiteSpace(tb.Text))
            {
                MessageBox.Show("All fields are not completed");
            }
        }

        private void DateValidation()
        {
            DTB_DoB.MinDate = DateTime.Today;
            DTB_DoB.CustomFormat = "dd MMMM, yyyy";
            DTB_DoB.Format = DateTimePickerFormat.Custom;

        }

        private bool OccupationValidation()
        {
            

            foreach (var RadioButton in PNL_occupations.Controls.OfType<RadioButton>())
            {
                if(RadioButton.Checked)
                {
                    return true;
                }
            }

            MessageBox.Show("A occupation has not been chosen.");

            return false;
        }

       
    }
}
