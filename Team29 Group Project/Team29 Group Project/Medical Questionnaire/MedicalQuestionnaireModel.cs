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
            var questionnaireID = questionnaires[0].questionnaireID;
            int intQuestionnaireID = Int32.Parse(questionnaireID);

            if (questionnaires.Count == 0)
            {
                MedicalQuestionnaire questionnaire = new MedicalQuestionnaire();
                questionnaire.patientID = patientID;
                questionnaire.medicalConditions = medicalConditions;
                questionnaire.medication = medication;
                questionnaire.allergies = allergies;

                unitOfWork.questionnaire.Add(questionnaire);
                unitOfWork.Save();
            }
            else
            {
                MedicalQuestionnaire med = unitOfWork.questionnaire.GetByID(intQuestionnaireID);
                med.medicalConditions = medicalConditions;
                med.medication = medication;
                med.allergies = allergies;
                unitOfWork.Save();
            }

            /*


            MedicalQuestionnaire questionnaire = new MedicalQuestionnaire();
            questionnaire.patientID = patientID;
            questionnaire.medicalConditions = medicalConditions;
            questionnaire.medication = medication;
            questionnaire.allergies = allergies;

            UnitOfWork unitOfWork = new UnitOfWork(new MyDBEntities());
            unitOfWork.questionnaire.Add(questionnaire);
            unitOfWork.Save();
            */
        }
        
    }
       
}

