using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team29_Group_Project
{
    public interface IPatientRegistrationGUI
    {
        String Firstname { set; get; }
        String Surname { set; get; }
        DateTime DoB { set; get; }
        String Address { set; get; }
        String Email { set; get; }
        String PhoneNumber { set; get; }
        String Occupation { set; get; }
        String GPname { set; get; }
        String GPaddress { set; get; }
        void Message(String message);
        void Register(PatientRegistrationPresenter PRP);
    }
}
