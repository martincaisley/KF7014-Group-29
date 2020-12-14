using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team29_Group_Project
{
    enum Occupation
    {
        fullTime_emp,
        partTime_emp,
        fullTime_edu,
        partTime_edu,
        unemployed,
        LI_benefits
    }
    public class PatientRegistrationModel
    {
        public void AddPayingPatient(String patientID, String firstName, String lastName, DateTime DoB, String address, String email, String occupation, String phoneNum, String GPname, String GPaddress)
        {

        }
        public void AddFreePatient(String patientID, String firstName, String lastName, DateTime DoB, String address, String email, String occupation, String phoneNum, String GPname, String GPaddress, double treatmentCost)
        {

        }
    } 

}
