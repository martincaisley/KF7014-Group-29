using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team29_Group_Project
{
  
    public class PatientFactory 
    {
        
        public Patient GetPatientType(PatientTypes patientType)
        {
            if (patientType == PatientTypes.Paying)
                return new PayingPatient();
            else
                return new FreePatient();

        }
    }
}
