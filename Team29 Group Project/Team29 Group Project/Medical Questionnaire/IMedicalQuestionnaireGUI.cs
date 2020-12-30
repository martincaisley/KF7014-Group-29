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
    public  interface IMedicalQuestionnaireGUI
    {   
        String GetMedicalConditions();
        String GetMedication();
        String GetAllergies();
        int GetPatientID();
        void setPatient(string name);
        void setMedicalConditions(string medicalConditions);
        void setMedication(string medications);
        void setAllergies(string allergies);
        String Message();
        void Register(MedicalQuestionnairePresenter MQP);
    }
}
