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
        int patientID;
        private MedicalQuestionnairePresenter presenter;
       
        public MedicalQuestionnaireGUI(int patientID)
        {
            this.patientID = patientID;
            InitializeComponent();
        }
        private void MedicalQuestionnaireGUI_Load(object sender, EventArgs e)
        {
            presenter.GetPatientName(patientID);
        }

        public String GetMedicalConditions()
        { return TXT_medicalConditions.Text; }
        public String GetMedication()
        { return TXT_medication.Text; }
        public String GetAllergies()
        { return TXT_allergies.Text; }
        public String GetPatientID()
        { return TXT_patient.Text; }
        public void Register(MedicalQuestionnairePresenter MQP)
        {
            presenter = MQP;
        }
        public void setPatient(string name)
        {
            TXT_patient.Text = name;
            TXT_patient.ReadOnly = true;
        }

       

       
    }
}
