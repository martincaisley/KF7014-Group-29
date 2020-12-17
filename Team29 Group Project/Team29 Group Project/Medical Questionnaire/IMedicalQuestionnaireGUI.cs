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
        String GetPatientID();
        void setPatient(string name);

        void Register(MedicalQuestionnairePresenter MQP);
    }
}
