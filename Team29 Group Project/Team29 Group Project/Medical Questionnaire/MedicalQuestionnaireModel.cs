using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team29_Group_Project
{
    class MedicalQuestionnaireModel
    {
        public string message;
        public String Message()
        {
            
            return message;
        }
        public string GetPatientName(int patientID)
        {
            UnitOfWork unitOfWork = new UnitOfWork(new MyDBEntities());
            var UOW = unitOfWork.patient.GetByID(patientID);
            string patientName = UOW.firstName + " " + UOW.lastName;

            return patientName;
        }

        public void AddQuestionnaire(int patientID, String medicalConditions, String medication, String allergies )
        {
            UnitOfWork unitOfWork = new UnitOfWork(new MyDBEntities());
            MedicalQuestionnaire mq = unitOfWork.questionnaire.GetByID(patientID);

            var quetionnaire = unitOfWork.questionnaire.GetAll();

            var appQuery = from q in quetionnaire.AsEnumerable()
                           where q.patientID == patientID 
                           select new
                           {
                               q.questionnaireID
                           };
            var questionnaires = appQuery.ToList();
            


            if (questionnaires.Count == 0)
            {
                MedicalQuestionnaire questionnaire = new MedicalQuestionnaire();
                questionnaire.patientID = patientID;
                questionnaire.medicalConditions = medicalConditions;
                questionnaire.medication = medication;
                questionnaire.allergies = allergies;
                questionnaire.DateCompleted = DateTime.Today.Date;

                unitOfWork.questionnaire.Add(questionnaire);
                unitOfWork.Save();
                message = "Medical record added successfully";
            }
            else
            {
                var questionnaireID = questionnaires[0].questionnaireID;

                MedicalQuestionnaire med = unitOfWork.questionnaire.GetByID(questionnaireID);
                med.medicalConditions = medicalConditions;
                med.medication = medication;
                med.allergies = allergies;
                med.DateCompleted = DateTime.Today.Date;
                unitOfWork.Save();
                message = "Medical record updated successfully";
            }

         
        }
        
    }
       
}

