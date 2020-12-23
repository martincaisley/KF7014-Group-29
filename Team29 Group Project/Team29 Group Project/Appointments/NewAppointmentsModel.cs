using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Team29_Group_Project
{
    public class NewAppointmentsModel : INewAppointmentsModel
    {
        #region Get from Database / Write to Database
        public string GetPatientName(int patientID)
        {
            UnitOfWork unitOfWork = new UnitOfWork(new MyDBEntities());
            var UOW = unitOfWork.patient.GetByID(patientID);
            string patientName = UOW.firstName + " " + UOW.lastName;

            unitOfWork.Dispose();
            return patientName;
        }

        public void AddAppointmentToDatabase(int patientID, DateTime appointmentDate, TimeSpan appointmentStartTime, TimeSpan appointmentEndTime, int appointmentLength, string appointmentType, string appointmentBand)
        {
            try
            {
                UnitOfWork unitOfWork = new UnitOfWork(new MyDBEntities());
                bool patientType = unitOfWork.patient.GetByID(patientID).isFree;

                AppointmentFactory factory = new AppointmentFactory();
                //insired by https://docs.microsoft.com/en-us/dotnet/api/system.enum.parse?view=net-5.0
                AppointmentBand AppointmentBands = (AppointmentBand)Enum.Parse(typeof(AppointmentBand), appointmentBand);
                Appointment a = factory.GetAppointmentBand(AppointmentBands);

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
                unitOfWork.Dispose();
            }
            catch (Exception f)
            {
                Console.WriteLine("Add appointment exception in NewAppointmentsModel: " + f.Message);
            }

        }
        

        public int getAppointmentLength(string AppointmentT)
        {
            //insired by https://docs.microsoft.com/en-us/dotnet/api/system.enum.parse?view=net-5.0
            AppType applength = (AppType)Enum.Parse(typeof(AppType), AppointmentT);
            int appointmentLength = Convert.ToInt32(applength);

            return appointmentLength;
        }

        public DataTable getAppointmentsDT(DateTime AppDate)
        {
            UnitOfWork unitOfWork = new UnitOfWork(new MyDBEntities());
            DataTable dt = new DataTable();
            try
            {
                var patient = unitOfWork.patient.GetAll();
                var appointment = unitOfWork.appointment.GetAll();

                dt.Columns.Add("Appointment Start Time", typeof(TimeSpan));
                dt.Columns.Add("Appointment End Time", typeof(TimeSpan));
                dt.Columns.Add("Patient Name", typeof(string));
                dt.Columns.Add("Appointment Type", typeof(string));
                dt.Columns.Add("AppointmentID", typeof(int));

                var appointmentQuery = from a in appointment.AsEnumerable()
                                       join p in patient.AsEnumerable()
                                       on a.patientID equals p.PatientID
                                       where a.appointmentDate == AppDate
                                       orderby a.appointmentStartTime
                                       select dt.LoadDataRow(new object[]
                                       {
                                                a.appointmentStartTime,
                                                a.appointmentEndTime,
                                                p.firstName + " " + p.lastName,
                                                a.appointmentType,
                                                a.appointmentID

                                       }, false);

                appointmentQuery.CopyToDataTable();
            }
            catch (Exception f)
            {
                Console.WriteLine("No Appointments to show " + f.Message);
            }
            unitOfWork.Dispose();
            return dt;
        }
        #endregion

        #region Check Appointment Time
        public bool checkIfCanBookAtThisTime(DateTime selectedDate, TimeSpan selectedStartTime, TimeSpan selectedEndTime)
        {
            UnitOfWork unitOfWork = new UnitOfWork(new MyDBEntities());
            var patient = unitOfWork.patient.GetAll();
            var appointment = unitOfWork.appointment.GetAll();

            var appQuery = from a in appointment.AsEnumerable()
                           join p in patient.AsEnumerable()
                           on a.patientID equals p.PatientID
                           where a.appointmentDate == selectedDate && ((a.appointmentStartTime <= selectedStartTime && a.appointmentEndTime > selectedStartTime) 
                           || (a.appointmentStartTime > selectedStartTime && a.appointmentStartTime < selectedEndTime))
                           select new
                           {
                               a.appointmentDate,
                               a.appointmentStartTime,
                               a.appointmentEndTime
                           };
            var appointmentExist = appQuery.ToList();

            if (appointmentExist.Count > 0)
            {
                unitOfWork.Dispose();
                return false;
            }
            else
            {
                unitOfWork.Dispose();
                return true;
            }
        }
        #endregion
    }
}
