using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team29_Group_Project
{
    public interface IPatientRegistrationGUI
    {
        String GetFirstname();
        String GetSurname();
        DateTime GetDoB();
        String GetAddress();
        String GetEmail();
        String GetPhoneNumber();
        String GetOccupation();
        String GetGPname();
        String GetGPaddress();
        bool GetPaymentType();
        void Message();
        void SetMessage(String message);
        void Register(PatientRegistrationPresenter PRP);
        void OpenDetails();
    }
}
