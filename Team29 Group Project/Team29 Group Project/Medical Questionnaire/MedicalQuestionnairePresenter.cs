/*
 * Martin Caisley:17015608
 * Drummond Heckles:17005997
 * Mark Burns:16016013
 */
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
        private IMedicalQuestionnaireModel model;

        public MedicalQuestionnairePresenter(IMedicalQuestionnaireGUI medicalScreen, IMedicalQuestionnaireModel medModel)
        {
            this.view = medicalScreen;
            model = medModel;
            view.Register(this);
            initialiseForm();
        }

        public void initialiseForm()
        {
            view.setPatient(model.GetPatientName(view.GetPatientID()));
            view.setMedicalConditions(model.GetMedicalConditions(view.GetPatientID()));
            view.setAllergies(model.GetAllergies(view.GetPatientID()));
            view.setMedication(model.GetMedication(view.GetPatientID()));
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
