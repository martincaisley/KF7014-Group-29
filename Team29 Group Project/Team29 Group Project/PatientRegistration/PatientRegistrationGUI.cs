/*
 * Martin Caisley:17015608
 * Drummond Heckles:17005997
 * Mark Burns:16016013
 */
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
    public partial class PatientRegistrationGUI : Form, IPatientRegistrationGUI
    {
        private PatientRegistrationPresenter presenter;
        public String message;

        #region Getters for presenter
        public String GetFirstname()
        {
            return TXT_fname.Text;
        }
        public String GetSurname()
        {
            return TXT_sname.Text;
        }
        public DateTime GetDoB()
        {
            return DTB_DoB.Value;
        }
        public String GetAddress()
        {
            return TXT_address.Text;
        }
        public String GetEmail()
        {
            return TXT_email.Text;
        }
        public String GetPhoneNumber()
        {
            return TXT_phoneNum.Text;
        }
        public String GetOccupation()
        {
            var checkedButton = PNL_occupations.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            return checkedButton.Text; 
        }

        public String GetGPname()
        {
            return TXT_GPname.Text;

        }
        public String GetGPaddress()
        {
            return TXT_GPaddress.Text;
        }
        public bool GetPaymentType()
        {
            if(FreePatientValidation())
            {
                return true;
            }
            return false;
        }

        #endregion

        public void Message()
        {
            MessageBox.Show(message);
        }
        public void SetMessage(String message)
        {
            this.message = message;
        }
       
        public PatientRegistrationGUI()
        {
            InitializeComponent();
        }

        private void PatientRegistrationGUI_Load(object sender, EventArgs e)
        {
            DateFormat();
            TXT_age.ReadOnly = true;
            TXT_fname.Clear();
            TXT_sname.Clear();
            TXT_address.Clear();
            TXT_email.Clear();
            TXT_phoneNum.Clear();
            TXT_GPname.Clear();
            TXT_GPaddress.Clear();
            TXT_age.Text = "0";
            DTB_DoB.MaxDate = DateTime.Today;
        }
        public void Register(PatientRegistrationPresenter PRP)
        {
            presenter = PRP;
        }

       

        private void BTN_addPatient_MouseClick(object sender, MouseEventArgs e)
        {
            PatientSubmit();
        }
        /*
         * finding age based on date of birth while taking into account leap years taken from
         * https://stackoverflow.com/questions/9/in-c-how-do-i-calculate-someones-age-based-on-a-datetime-type-birthday
         */
        private void DTB_DoB_ValueChanged(object sender, EventArgs e)
        {
            var today = DateTime.Today;
            var age = today.Year - DTB_DoB.Value.Year;
            if (DTB_DoB.Value.Date > today.AddYears(-age)) age--;
            TXT_age.Text = age.ToString();
        }

        /*
         * code to check all text boxes to see if theuy're null inspired from.
         *https://stackoverflow.com/questions/8750290/how-can-i-check-multiple-textboxes-if-null-or-empty-without-a-unique-test-for-ea
         */

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
        /*
         * Code for checking every radio button in a panel inspired by:
         * https://stackoverflow.com/questions/8750290/how-can-i-check-multiple-textboxes-if-null-or-empty-without-a-unique-test-for-ea
         */
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

        private bool FreePatientValidation()
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
            else if(age <= 18)
            {
                return true;
            }
            return false;
        }
        
    
        private void PatientSubmit()
        {
            if (TextValidation() && OccupationValidation())
            {
                presenter.ProcessNewPatient();
               
                
                

            }
            else 
            {
                
            }


        }
        public void OpenDetails()
        {
            int patientID1 = presenter.getLastPatientID();
            PatientDetails patientDetails = new PatientDetails(patientID1);
            PatientDetailsModel patientDetailsModel = new PatientDetailsModel();
            PatientDetailsPresenter PDP = new PatientDetailsPresenter(patientDetails, patientDetailsModel);
            this.Close();
            patientDetails.ShowDialog();
        }


    }
}
