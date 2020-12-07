using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team29_Group_Project
{
    enum PatientTypes
    {
        Band1 = 1,
        Band2 = 2,
        Band3 = 3,
        Free = 4

    }
    interface IPatientType
    {
         void GetDetails();
      
        
    }
   
}
