using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team29_Group_Project
{
    public class MedicalQuestionnairePresenter
    {
        private IMedicalQuestionnaireGUI view;
        private MedicalQuestionnaireModel model;

        public MedicalQuestionnairePresenter(IMedicalQuestionnaireGUI medicalScreen)
        {
            this.view = medicalScreen;
            model = new MedicalQuestionnaireModel();
            view.Register(this);

        }

        

        public void GetPatientName(int patientID)
        {
            view.setPatient(model.GetPatientName(patientID));
        }
    }
}
