using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team29_Group_Project
{
     class Band1Patient : Patient, IPatientType
    {
        public static double treatmentCost { get; set; } = 22.70;
        public void GetDetails()
        {
            
        }
       
        
    }
}
