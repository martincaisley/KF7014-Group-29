using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team29_Group_Project
{


    public class PatientRegistrationModel
    {
        PatientFactory patientFactory = new PatientFactory();
        
      
        public void AddPatient(String firstName, String lastName, DateTime DoB, String address, String email, String phoneNum, String occupation, String GPname, String GPaddress, string type)
        {
            PatientTypes patientTypes = (PatientTypes)Enum.Parse(typeof(PatientTypes), type);
            Patient patient = patientFactory.GetPatientType(patientTypes);
            patient.firstName = firstName;
            patient.lastName = lastName;
            patient.DoB = DoB;
            patient.Address = address;
            patient.Email = email;
            patient.Occupation = occupation;
            patient.PhoneNum = phoneNum;
            patient.GPname = GPname;
            patient.GPaddress = GPaddress;

            UnitOfWork unitOfWork = new UnitOfWork(new MyDBEntities());
            unitOfWork.patient.Add(patient);
            unitOfWork.Save();
        }
       
    }

}
