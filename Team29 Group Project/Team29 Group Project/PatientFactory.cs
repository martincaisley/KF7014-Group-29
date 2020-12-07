using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team29_Group_Project
{
    class PatientFactory
    {
        public IPatientType GetPatientType(PatientTypes patientType)
        {
            if (patientType == PatientTypes.Band1)
                return new Band1Patient();

            if (patientType == PatientTypes.Band2)
                return new Band2Patient();

            if (patientType == PatientTypes.Band3)
                return new Band3Patient();
            else
                return new FreePatient();

        }
    }
}
