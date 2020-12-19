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
    public partial class MedicalQuestionnaireGUI : Form, IMedicalQuestionnaireGUI
    {
        private string message;
        int patientID;
        private MedicalQuestionnairePresenter presenter;
       
        public MedicalQuestionnaireGUI(int patientID)
        {
            this.patientID = patientID;
            InitializeComponent();
        }
        private void MedicalQuestionnaireGUI_Load(object sender, EventArgs e)
        {

        }
        #region interface methods
        public String GetMedicalConditions()
        { return TXT_medicalConditions.Text; }
        public String GetMedication()
        { return TXT_medication.Text; }
        public String GetAllergies()
        { return TXT_allergies.Text; }
        public int GetPatientID()
        { return patientID; }
        public void Register(MedicalQuestionnairePresenter MQP)
        {
            presenter = MQP;
        }
       
        public void setPatient(string name)
        {
            TXT_patient.Text = name;
            TXT_patient.ReadOnly = true;
        }
        public String Message()
        {


            return presenter.GetMessage();
        }

        public void setMedicalConditions(string medicalConditions)
        {
            TXT_medicalConditions.Text = medicalConditions;
        }

        public void setMedication(string medications)
        {
            TXT_medication.Text = medications;
        }

        public void setAllergies(string allergies)
        {
            TXT_allergies.Text = allergies;
        }
        #endregion

        private void BTN_submitQuestionnaire_Click(object sender, EventArgs e)
        {
            presenter.ProcessNewAppointment();
            MessageBox.Show(Message());
          
            this.Close();
        }

        
    }
}
