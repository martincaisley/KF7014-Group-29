using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team29_Group_Project
{
    class PayingPatient : Patient, IPatientType
    {
        void IPatientType.GetDetails()
        {
            Console.WriteLine("PAYING PATIENT");
        }
        public IPatientType CreatePatient()
        {
            return new PayingPatient();
        }
    }
}
