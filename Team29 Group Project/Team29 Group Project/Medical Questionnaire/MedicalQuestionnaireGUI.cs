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
        private MedicalQuestionnairePresenter presenter;
       
        public MedicalQuestionnaireGUI()
        {
            InitializeComponent();
        }
        private void MedicalQuestionnaireGUI_Load(object sender, EventArgs e)
        {
            SetDropBox();
        }

        public String GetMedicalConditions()
        { return TXT_medicalConditions.Text; }
        public String GetMedication()
        { return TXT_medication.Text; }
        public String GetAllergies()
        { return TXT_allergies.Text; }
        public String GetPatientID()
        { return CMB_patients.SelectedItem.ToString(); }
        public void Register(MedicalQuestionnairePresenter MQP)
        {
            presenter = MQP;
        }

        public void SetDropBox()
        {
            CMB_patients.DataSource = presenter.getPatientList();
        }

       
    }
}
