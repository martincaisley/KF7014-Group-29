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
            DateFormat();
        }

        private void BTN_medQuestionnaire_Click(object sender, EventArgs e)
        {
            MedicalQuestionnaireGUI med = new MedicalQuestionnaireGUI();
            med.Show();
        }

        private void BTN_addPatient_MouseClick(object sender, MouseEventArgs e)
        {
            AddPatient();
        }
        private bool TextValidation()
        {
            string EmptyTextBoxes = string.Join(Environment.NewLine,
            (
              from T in this.Controls.OfType<TextBox>()
              where string.IsNullOrWhiteSpace(T.Text)
              select T.Name).ToArray());
            if (EmptyTextBoxes.Length > 0)
            {
                MessageBox.Show("Please complete every text field");
                return false;
            }
            else
                return true;
        }

        private void DateFormat()
        {

            DTB_DoB.CustomFormat = "dd MMMM, yyyy";
            DTB_DoB.Format = DateTimePickerFormat.Custom;

        }

        private bool OccupationValidation()
        {
            foreach (var RadioButton in PNL_occupations.Controls.OfType<RadioButton>())
            {
                if (RadioButton.Checked)
                {
                    return true;
                }
            }

            MessageBox.Show("A occupation has not been chosen.");

            return false;
        }

        private void AddPatient()
        {
            if (TextValidation() && OccupationValidation())
            {
                MessageBox.Show("Patient added");
            }
            else
            {

            }

        }

      
    }
}
