using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Team29_Group_Project
{
    public class NewAppointmentsModel
    {
        public string GetPatientName(int patientID)
        {
            UnitOfWork unitOfWork = new UnitOfWork(new MyDBEntities());
            var UOW = unitOfWork.patient.GetByID(patientID);
            string patientName = UOW.firstName + " " + UOW.lastName;

            return patientName;
        }

        public void WriteToDatabase(int patientID, DateTime appointmentDate, TimeSpan appointmentStartTime, TimeSpan appointmentEndTime, int appointmentLength, string appointmentType, string appointmentBand)
        {
            try
            {
                UnitOfWork unitOfWork = new UnitOfWork(new MyDBEntities());
                bool patientType = unitOfWork.patient.GetByID(patientID).isFree;

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

                if (patientType == true && appointmentBand == "Band1")
                {
                    a.appointmmentCost = 0;
                }

                unitOfWork.appointment.Add(a);
                unitOfWork.Save();
            }
            catch (Exception f)
            {
                Console.WriteLine("New app Exception" + f.Message);
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
                UnitOfWork unitOfWork = new UnitOfWork(new MyDBEntities());
                var patient = unitOfWork.patient.GetAll();
                var appointment = unitOfWork.appointment.GetAll();

                dt.Columns.Add("Patient Name", typeof(string));
                dt.Columns.Add("Appointment Start Time", typeof(TimeSpan));
                dt.Columns.Add("Appointment End Time", typeof(TimeSpan));
                dt.Columns.Add("Appointment Type", typeof(string));
                dt.Columns.Add("AppointmentID", typeof(int));

                var appointmentQuery = from a in appointment.AsEnumerable()
                                       join p in patient.AsEnumerable()
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
            catch (Exception f)
            {
                Console.WriteLine("No Appointments to show " + f.Message);
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
            UnitOfWork unitOfWork = new UnitOfWork(new MyDBEntities());
            var patient = unitOfWork.patient.GetAll();
            var appointment = unitOfWork.appointment.GetAll();

            var appQuery = from a in appointment.AsEnumerable()
                           join p in patient.AsEnumerable()
                           on a.patientID equals p.PatientID
                           where a.appointmentDate == date && ((a.appointmentStartTime <= startTime && a.appointmentEndTime > startTime) || (a.appointmentStartTime > startTime && a.appointmentStartTime < endTime))
                           select new
                           {
                               a.appointmentDate,
                               a.appointmentStartTime,
                               a.appointmentEndTime
                           };
            var appointmentExist = appQuery.ToList();

            if (appointmentExist.Count > 0)
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
