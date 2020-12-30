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
    public interface IMedicalQuestionnaireModel
    {
        String Message();
        void setMessage(string messageToSet);
        string GetPatientName(int patientID);
        string GetMedicalConditions(int patientID);
        string GetMedication(int patientID);
        string GetAllergies(int patientID);
        void AddQuestionnaire(int patientID, String medicalConditions, String medication, String allergies);

    }
}
