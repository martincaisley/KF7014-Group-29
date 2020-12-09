using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team29_Group_Project
{
    class PatientFactory
    {
        private static PatientFactory instance;
        private PatientFactory() { }
        public static PatientFactory Singleton
        {
            get
            {
                if (instance == null)
                    instance = new PatientFactory();
                return instance;
            }
        }
        public IPatientType GetPatientType(PatientTypes patientType)
        {
            if (patientType == PatientTypes.Paying)
                return new PayingPatient();
            else
                return new FreePatient();

        }
    }
}
