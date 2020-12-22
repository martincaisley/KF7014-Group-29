using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team29_Group_Project
{
    class MedicalQuestionnaireModel : IMedicalQuestionnaireModel
    {
        UnitOfWork unitOfWork = new UnitOfWork(new MyDBEntities());
        public string message;
        public string Message()
        {
            return message;
        }

        public void setMessage(string messageToSet)
        {
            message = messageToSet;
        }
        public string GetPatientName(int patientID)
        {
            var UOW = unitOfWork.patient.GetByID(patientID);
            string patientName = UOW.firstName + " " + UOW.lastName;

            return patientName;
        }
        public string GetMedicalConditions(int patientID)
        {
            var quetionnaire = unitOfWork.questionnaire.GetAll();

            var appQuery = from q in quetionnaire.AsEnumerable()
                           where q.patientID == patientID
                           select new
                           {
                               q.questionnaireID
                           };
            var questionnaires = appQuery.ToList();
            if (questionnaires.Count != 0)
            {

                var mq = unitOfWork.questionnaire.GetByID(questionnaires[0].questionnaireID);
                string medicalConditions = mq.medicalConditions;

                return medicalConditions;
            }
            else
            {
                return "";
            }
        }
        public string GetMedication(int patientID)
        {
            var quetionnaire = unitOfWork.questionnaire.GetAll();

            var appQuery = from q in quetionnaire.AsEnumerable()
                           where q.patientID == patientID
                           select new
                           {
                               q.questionnaireID
                           };
            var questionnaires = appQuery.ToList();

            if (questionnaires.Count != 0)
            {
                var mq = unitOfWork.questionnaire.GetByID(questionnaires[0].questionnaireID);
                string medication = mq.medication;

                return medication;
            }
            else
            {
                return "";
            }
        }
        public string GetAllergies(int patientID)
        {
            var quetionnaire = unitOfWork.questionnaire.GetAll();

            var appQuery = from q in quetionnaire.AsEnumerable()
                           where q.patientID == patientID
                           select new
                           {
                               q.questionnaireID
                           };
            var questionnaires = appQuery.ToList();

            if (questionnaires.Count != 0)
            {

                var mq = unitOfWork.questionnaire.GetByID(questionnaires[0].questionnaireID);
                string allergies = mq.allergies;

                return allergies;
            }
            else
            {
                return "";
            }
        }

        public void AddQuestionnaire(int patientID, String medicalConditions, String medication, String allergies )
        {
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
                setMessage("Medical record added successfully");
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
                setMessage("Medical record updated successfully");
            }

         
        }
        
    }
       
}

