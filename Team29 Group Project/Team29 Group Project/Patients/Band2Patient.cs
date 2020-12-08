using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team29_Group_Project
{
    class Band2Patient : Patient, IPatientType
    {
        public static double treatmentCost { get; set; } = 62.10;
        public void GetDetails()
        {

        }
    }
}
