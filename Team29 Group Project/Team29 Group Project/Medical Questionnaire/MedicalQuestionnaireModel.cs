using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team29_Group_Project
{
    class MedicalQuestionnaireModel
    {
        public String[] getPatientNames()
        { 
                using(var context = new MyDBEntities())
                {
                    var patientNames = context.Patients.Select(x => x.firstName).ToArray();

                    return patientNames;


                }
             
        }
    }
}
