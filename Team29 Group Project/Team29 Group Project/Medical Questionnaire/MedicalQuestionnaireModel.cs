using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team29_Group_Project
{
    class MedicalQuestionnaireModel
    {
        public string GetPatientName(int patientID)
        {
            UnitOfWork unitOfWork = new UnitOfWork(new MyDBEntities());
            var UOW = unitOfWork.patient.GetByID(patientID);
            string patientName = UOW.firstName + " " + UOW.lastName;

            return patientName;
        }

        public void AddQuestionnaire(int patientID, String medicalConditions, String medication, String allergies )
        {
            MedicalQuestionnaire questionnaire = new MedicalQuestionnaire();
            questionnaire.patientID = patientID;
            questionnaire.medicalConditions = medicalConditions;
            questionnaire.medication = medication;
            questionnaire.allergies = allergies;

            UnitOfWork unitOfWork = new UnitOfWork(new MyDBEntities());
            unitOfWork.questionnaire.Add(questionnaire);
            unitOfWork.Save();
        }
        
    }
       
}

