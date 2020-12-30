/*
 * Martin Caisley:17015608
 * Drummond Heckles:17005997
 * Mark Burns:16016013
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team29_Group_Project
{


    public class PatientRegistrationModel : IPatientRegistrationModel
    {
        PatientFactory patientFactory = new PatientFactory();
        

        public void AddPatient(String firstName, String lastName, DateTime DoB, String address, String email, String phoneNum, String occupation, String GPname, String GPaddress, string type)
        {
            UnitOfWork unitOfWork = new UnitOfWork(new MyDBEntities());
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

            unitOfWork.patient.Add(patient);
            unitOfWork.Save();
            unitOfWork.Dispose();
        }

        public int getLastPatientID()
        {
            UnitOfWork unitOfWork = new UnitOfWork(new MyDBEntities());
            var patients = unitOfWork.patient.GetAll();
            var appointments = unitOfWork.appointment.GetAll();


            var patientQuery = from p in patients.AsEnumerable()
                               select new
                               {
                                   p.PatientID
                               };

            var patientIDs = patientQuery.ToList();
            List<int> patids = new List<int> { };

            for (int i = 0; i < patientIDs.Count; i++)
            {
                patids.Add(patientIDs[i].PatientID);
            }


            int patientID = patids.Max();
            unitOfWork.Dispose();
            return patientID;
        }
       
    }

}
