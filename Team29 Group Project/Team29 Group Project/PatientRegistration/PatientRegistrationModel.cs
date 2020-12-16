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

        public void AddPayingPatient(String firstName, String lastName, DateTime DoB, String address, String email, String phoneNum, String occupation, String GPname, String GPaddress)
        {
            try
            {
                Patient patient = patientFactory.GetPatientType(PatientTypes.Paying);

                patient.firstName = firstName;
                patient.lastName = lastName;
                patient.DoB = DoB;
                patient.Address = address;
                patient.Email = email;
                patient.Occupation = occupation;
                patient.PhoneNum = phoneNum;
                patient.GPname = GPname;
                patient.GPaddress = GPaddress;
                patient.isFree = false;

                UnitOfWork unitOfWork = new UnitOfWork(new MyDBEntities());
                unitOfWork.patient.Add(patient);
                unitOfWork.Save();
            }
            catch (Exception e)
            {
                Console.WriteLine("New Exception" + e.Message);
            }

        }
        public void AddFreePatient(String firstName, String lastName, DateTime DoB, String address, String email, String phoneNum, String occupation, String GPname, String GPaddress)
        {
            try
            {
                Patient patient = patientFactory.GetPatientType(PatientTypes.Free);

                patient.firstName = firstName;
                patient.lastName = lastName;
                patient.DoB = DoB;
                patient.Address = address;
                patient.Email = email;
                patient.Occupation = occupation;
                patient.PhoneNum = phoneNum;
                patient.GPname = GPname;
                patient.GPaddress = GPaddress;
                patient.isFree = true;

                UnitOfWork unitOfWork = new UnitOfWork(new MyDBEntities());
                unitOfWork.patient.Add(patient);
                unitOfWork.Save();
            }
            catch (Exception e)
            {
                Console.WriteLine("New Exception" + e.Message);
            }
        }
    }

}
