using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team29_Group_Project
{
    interface IPatientRegistrationGUI
    {
        String GetFirstName();
        String GetLastName();
        DateTime GetDoB();
        String GetAddress();
        String GetEmail();
        String GetPhoneNumber();
        String GetOccupation();
        String GetGPname();
        String GetGPaddress();
    }
}
