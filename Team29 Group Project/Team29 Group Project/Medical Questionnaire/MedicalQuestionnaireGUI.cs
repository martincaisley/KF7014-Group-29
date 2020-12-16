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
