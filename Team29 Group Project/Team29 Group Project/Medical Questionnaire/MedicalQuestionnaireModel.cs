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
    class MedicalQuestionnaireModel : IMedicalQuestionnaireModel
    {
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
            UnitOfWork unitOfWork = new UnitOfWork(new MyDBEntities());
            var UOW = unitOfWork.patient.GetByID(patientID);
            string patientName = UOW.firstName + " " + UOW.lastName;
            unitOfWork.Dispose();
            return patientName;
        }
        public string GetMedicalConditions(int patientID)
        {
            UnitOfWork unitOfWork = new UnitOfWork(new MyDBEntities());
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
                unitOfWork.Dispose();
                return medicalConditions;
            }
            else
            {
                unitOfWork.Dispose();
                return "";
            }
        }
        public string GetMedication(int patientID)
        {
            UnitOfWork unitOfWork = new UnitOfWork(new MyDBEntities());
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

                unitOfWork.Dispose();
                return medication;
            }
            else
            {
                unitOfWork.Dispose();
                return "";
            }
        }
        public string GetAllergies(int patientID)
        {
            UnitOfWork unitOfWork = new UnitOfWork(new MyDBEntities());
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
                unitOfWork.Dispose();
                return allergies;
            }
            else
            {
                unitOfWork.Dispose();
                return "";
            }
        }

        public void AddQuestionnaire(int patientID, String medicalConditions, String medication, String allergies )
        {
            UnitOfWork unitOfWork = new UnitOfWork(new MyDBEntities());
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
                unitOfWork.Dispose();
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
                unitOfWork.Dispose();
                setMessage("Medical record updated successfully");
            }

         
        }
        
    }
       
}

