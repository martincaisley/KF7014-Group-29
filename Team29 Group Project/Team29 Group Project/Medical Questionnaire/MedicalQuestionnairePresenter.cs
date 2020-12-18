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

        public void GetMedicalConditions(int patientID)
        {
            view.setMedicalConditions(model.GetMedicalConditions(patientID));
        }
        public void GetAllergies(int patientID)
        {
            view.setAllergies(model.GetAllergies(patientID));
        }
        public void GetMedication(int patientID)
        {
            view.setMedication(model.GetMedication(patientID));
        }
        public String GetMessage()
        {
            return model.Message();
        }

        public void ProcessNewAppointment()
        {
            String medicalConditions = view.GetMedicalConditions();
            String medication = view.GetMedication();
            String allergies = view.GetAllergies();
            int patientID = Convert.ToInt32( view.GetPatientID());

            model.AddQuestionnaire(patientID,medicalConditions, medication, allergies );
            String result = model.Message();
            
        }
    }
}
