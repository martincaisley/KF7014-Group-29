using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team29_Group_Project
{
    class NewAppointmentsModel
    {

        public string GetPatientName(int patientID) 
        { 
            using (var context = new MyDBEntities())
            {
                var patients = context.Patients.ToList();
                var nameQuery = from p in patients.AsEnumerable()
                    where p.PatientID == patientID
                    select new
                    {
                        forename = p.firstName,
                        surname = p.lastName
                    };
                var name = nameQuery.ToList();
                string patientName = name[0].forename + " " + name[0].surname;
                

                return patientName;
            }
        }

        public void WriteToDatabase(int patientID, DateTime appointmentDate, DateTime appointmentStartTime, DateTime appointmentEndTime, string appointmentType)
        {
            try
            {
                using (var context = new MyDBEntities())
                {
                    Appointment a = new Appointment();
                    a.patientID = patientID;
                    a.appointmentDate = appointmentDate;
                    a.appointmentStartTime = appointmentStartTime;
                    a.appointmentEndTime = appointmentEndTime;
                    a.appointmentType = appointmentType;

                    context.Appointments.Add(a);
                    context.SaveChanges();

                   
                }
            }
            catch (Exception f)
            {
                Console.WriteLine("New aPp Exception");
            }

        }

        public int getAppointmentLength(string AppointmentT)
        {
            AppType applength = (AppType)Enum.Parse(typeof(AppType), AppointmentT);
          //  MessageBox.Show("Appointment Length: " + Convert.ToInt32(applength).ToString());
            int appointmentLength = Convert.ToInt32(applength);

            

            return appointmentLength;
        }


     






        enum AppType
        {
            Checkup = 30,
            Bridges = 60,
            Crowns = 30,
            Fillings = 20,
            RootCanal = 60,
            ScaleAndPolish = 45,
            Braces = 60,
            WisdomTooth = 20,
            DentalImplants = 60,
            Dentures = 60,
            BrokenTooth = 30,
            TeethWhitening = 90,
            DentalVeneers = 120

        }

    }
}
