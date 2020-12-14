using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team29_Group_Project
{
    
   
    public class PatientRegistrationModel
    {
        public void AddPayingPatient(String firstName, String lastName, DateTime DoB, String address, String email, String phoneNum, String occupation, String GPname, String GPaddress)
        {
            try
            {
                using (var context = new MyDBEntities())
                {
                    PayingPatient patient = new PayingPatient();
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


                     context.Patients.Add(patient);
                     context.SaveChanges();
                }
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
                using (var context = new MyDBEntities())
                {
                    IPatientType patientType = PatientFactory.Singleton.GetPatientType(PatientTypes.Free);
                    patientType.GetDetails();
                    

                    FreePatient patient = new FreePatient();
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

                    context.Patients.Add(patient);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("New Exception" + e.Message);
            }



        }
    } 

}
