using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team29_Group_Project
{
    public class PatientRegistrationPresenter
    {
        private PatientRegistrationModel model;
        private IPatientRegistrationGUI form;

        public PatientRegistrationPresenter(IPatientRegistrationGUI form)
        {
            this.form = form;
            model = new PatientRegistrationModel();
            
        }

        public void BTN_medQuestionnaire_event()
        {
            MedicalQuestionnaireGUI med = new MedicalQuestionnaireGUI();
            med.Show();
        }
       
    }
}
