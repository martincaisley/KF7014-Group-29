using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Team29_Group_Project
{
    class FreePatient : Patient, IPatientType
    {
        public static double treatmentCost { get; set; } = 0;
        void IPatientType.GetDetails()
        {
            Console.WriteLine("FREE PATIENT");
        }
        public IPatientType CreatePatient()
        {
            return new FreePatient();
        }

    }
}
