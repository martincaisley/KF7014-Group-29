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
            TXT_age.ReadOnly = true;
        }

        private void BTN_medQuestionnaire_Click(object sender, EventArgs e)
        {
            MedicalQuestionnaireGUI med = new MedicalQuestionnaireGUI();
            med.Show();
        }

        private void BTN_addPatient_MouseClick(object sender, MouseEventArgs e)
        {
            PatientSubmit();
        }

        private void DTB_DoB_ValueChanged(object sender, EventArgs e)
        {
            var today = DateTime.Today;
            var age = today.Year - DTB_DoB.Value.Year;
            if (DTB_DoB.Value.Date > today.AddYears(-age)) age--;
            TXT_age.Text = age.ToString();
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

        private bool FreePatientCheck()
        {
            string occupation = null;
            int age = int.Parse(TXT_age.Text.ToString());
            foreach (var RadioButton in PNL_occupations.Controls.OfType<RadioButton>())
            {
                if (RadioButton.Checked)
                {
                     occupation = RadioButton.Text;
                }
            }
            if(occupation == "Full time education" && age < 19)
            {
                return true;
            }
            return false;
        }

        private void PatientSubmit()
        {
            if (TextValidation() && OccupationValidation())
            {
                if(FreePatientCheck())
                {
                    IPatientType patientType = PatientFactory.Singleton.GetPatientType(PatientTypes.Free);
                    patientType.GetType();
                    MessageBox.Show("Free patient added");
                }
                else 
                {
                    IPatientType patientType = PatientFactory.Singleton.GetPatientType(PatientTypes.Paying);
                    patientType.GetType();
                    MessageBox.Show("Paying patient added");
                }
                   
            }
            else
            {

            }

        }

       
    }
}
