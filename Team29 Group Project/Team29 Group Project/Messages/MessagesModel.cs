using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team29_Group_Project
{
    class MessagesModel : IMessagesModel
    {
        UnitOfWork unitOfWork = new UnitOfWork(new MyDBEntities());
        public int getAppointmentID(int patientID)
        {
            var patients = unitOfWork.patient.GetAll();
            var appointments = unitOfWork.appointment.GetAll();

            var appQuery = from a in appointments.AsEnumerable()
                           join p in patients.AsEnumerable()
                           on a.patientID equals p.PatientID
                           where p.PatientID == patientID && a.arrivedToAppointment == "No" && a.appointmentDate < DateTime.Today
                           select new
                           {
                               appointmentID = a.appointmentID
                           };
            var appointment = appQuery.ToList();
            int appointmentID = appointment[0].appointmentID;
            return appointmentID;
        }
        public string getName(int patientID)
        {
            var patients = unitOfWork.patient.GetAll();
            var appointments = unitOfWork.appointment.GetAll();

            var appQuery = from a in appointments.AsEnumerable()
                           join p in patients.AsEnumerable()
                           on a.patientID equals p.PatientID
                           where p.PatientID == patientID && a.arrivedToAppointment == "No" && a.appointmentDate < DateTime.Today
                           select new
                           {
                               forename = p.firstName,
                               surname = p.lastName
                           };
            var appointment = appQuery.ToList();
            string name = appointment[0].forename + " " + appointment[0].surname;
            return name;

        }

        public DateTime getDate(int patientID)
        {
            var patients = unitOfWork.patient.GetAll();
            var appointments = unitOfWork.appointment.GetAll();

            var appQuery = from a in appointments.AsEnumerable()
                           join p in patients.AsEnumerable()
                           on a.patientID equals p.PatientID
                           where p.PatientID == patientID && a.arrivedToAppointment == "No" && a.appointmentDate < DateTime.Today
                           select new
                           {
                               appointmentDate = a.appointmentDate
                           };
            var appointment = appQuery.ToList();
            DateTime date = appointment[0].appointmentDate;
            return date;
        }

        public TimeSpan getTime(int patientID)
        {
            var patients = unitOfWork.patient.GetAll();
            var appointments = unitOfWork.appointment.GetAll();

            var appQuery = from a in appointments.AsEnumerable()
                           join p in patients.AsEnumerable()
                           on a.patientID equals p.PatientID
                           where p.PatientID == patientID && a.arrivedToAppointment == "No" && a.appointmentDate < DateTime.Today
                           select new
                           {
                               appointmentStartTime = a.appointmentStartTime
                           };
            var appointment = appQuery.ToList();
            TimeSpan time = appointment[0].appointmentStartTime;
            return time;
        }

        public void updateTables(int appointmentID, string value)
        {
            Appointment a = unitOfWork.appointment.GetByID(appointmentID);
            a.arrivedToAppointment = value;
            unitOfWork.Save();
        }

        public bool checkForRepeatOffence(int patientID)
        {
            var appointments = unitOfWork.appointment.GetAll();
            try
            {
                var repeatAppQuery = from a in appointments.AsEnumerable()
                                     where a.patientID == patientID && a.arrivedToAppointment == "Invalid" && a.appointmentDate >= DateTime.Today.AddYears(-3)
                                     group a by a.patientID into grouped
                                     select new
                                     {
                                         count = grouped.Count()
                                     };
                var offences = repeatAppQuery.ToList();
                int numberOfOffences = offences[0].count;
                if (numberOfOffences >= 3)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("No offences to show " + e.Message);
            }
            return false;
        }

    }
}
