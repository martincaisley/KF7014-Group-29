using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentIdeas
{
    class AddPatientModel
    {
        public void addPatient(string name, string address, string phoneNumber)
        {
            string patienName = name;
            string patientAddress = address;
            string patientNumber = phoneNumber;

            using (var context = new MyDBEntities())
            {
                Patient p = new Patient();
                p.PatientName = patienName;
                p.PatientAddress = patientAddress;
                p.PatientPhoneNumber = patientNumber;

                context.Patients.Add(p);
                context.SaveChanges();
            }
        }
    }
}
