using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Team29_Group_Project
{
    class NewAppointmentsModel
    {
        public string GetPatientName(int patientID)
        {
            var repo = new PatientRepository();
            string patientName = repo.GetByID(patientID).firstName + " " + repo.GetByID(patientID).lastName;

            return patientName;
        }

        public void WriteToDatabase(int patientID, DateTime appointmentDate, TimeSpan appointmentStartTime, TimeSpan appointmentEndTime, int appointmentLength, string appointmentType, string appointmentBand)
        {
            try
            {
                AppointmentFactory factory = new AppointmentFactory();
                AppointmentCost appointmentCosts = (AppointmentCost)Enum.Parse(typeof(AppointmentCost), appointmentBand);
                Appointment a = factory.GetAppointmentCost(appointmentCosts);

                a.patientID = patientID;
                a.appointmentDate = appointmentDate;
                a.appointmentStartTime = appointmentStartTime;
                a.appointmentEndTime = appointmentEndTime;
                a.appointmentLength = appointmentLength;
                a.appointmentType = appointmentType;
                a.arrivedToAppointment = "No";
                a.contacted = "No";

                var repo = new AppointmentRepository();
                repo.Add(a);
                repo.Save();
            }
            catch (Exception f)
            {
                Console.WriteLine("New aPp Exception" + f.Message);
            }

        }

        public int getAppointmentLength(string AppointmentT)
        {
            AppType applength = (AppType)Enum.Parse(typeof(AppType), AppointmentT);
            int appointmentLength = Convert.ToInt32(applength);

            return appointmentLength;
        }

        public DataTable getDT(DateTime AppDate)
        {
            DataTable dt = new DataTable();
            try
            {
                using (var context = new MyDBEntities())
                {
                    var patients = context.Patients.ToList();
                    var appointments = context.Appointments.ToList();

                    dt.Columns.Add("Patient Name", typeof(string));
                    dt.Columns.Add("Appointment Start Time", typeof(TimeSpan));
                    dt.Columns.Add("Appointment End Time", typeof(TimeSpan));
                    dt.Columns.Add("Appointment Type", typeof(string));
                    dt.Columns.Add("AppointmentID", typeof(int));

                    var appointmentQuery = from a in appointments.AsEnumerable()
                                           join p in patients.AsEnumerable()
                                           on a.patientID equals p.PatientID
                                           where a.appointmentDate == AppDate
                                           orderby a.appointmentStartTime
                                           select dt.LoadDataRow(new object[]
                                           {
                                                p.firstName + " " + p.lastName,
                                                a.appointmentStartTime,
                                                a.appointmentEndTime,
                                                a.appointmentType,
                                                a.appointmentID

                                           }, false);

                    appointmentQuery.CopyToDataTable();
                }
            }
            catch
            {


            }

            return dt;
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

        public bool checkTime(DateTime date, TimeSpan startTime, TimeSpan endTime)
        {
            using (var context = new MyDBEntities())
            {
                var appointments = context.Appointments.ToList();
                var patients = context.Patients.ToList();
                var appQuery = from a in appointments.AsEnumerable()
                               join p in patients.AsEnumerable()
                               on a.patientID equals p.PatientID
                               where a.appointmentDate == date && ((a.appointmentStartTime <= startTime && a.appointmentEndTime > startTime) || (a.appointmentStartTime > startTime && a.appointmentStartTime < endTime))


                               select new
                               {
                                   a.appointmentDate,
                                   a.appointmentStartTime,
                                   a.appointmentEndTime
                               };
                var appointment = appQuery.ToList();

                if (appointment.Count > 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }


            }


        }
    }
}
