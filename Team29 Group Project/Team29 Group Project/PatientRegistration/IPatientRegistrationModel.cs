using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team29_Group_Project
{
    public interface IPatientRegistrationModel
    {
        void AddPatient(String firstName, String lastName, DateTime DoB, String address, String email, String phoneNum, String occupation, String GPname, String GPaddress, string type);
        int getLastPatientID();
    }
}
