using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team29_Group_Project
{
    public  interface IMedicalQuestionnaireGUI
    {   //add code in program.cs later
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
