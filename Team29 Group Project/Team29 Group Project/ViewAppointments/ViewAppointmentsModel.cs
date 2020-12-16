using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace Team29_Group_Project
{
    class ViewAppointmentsModel
    {
        public DataTable getDT(DateTime date)
        {
            DataTable dt = new DataTable();
            try
            {
                UnitOfWork unitOfWork = new UnitOfWork(new MyDBEntities());
                var patients = unitOfWork.patient.GetAll();
                var appointments = unitOfWork.appointment.GetAll();

                dt.Columns.Add("AppointmentID", typeof(int));
                dt.Columns.Add("Patient Forename", typeof(string));
                dt.Columns.Add("Patient Surname", typeof(string));
                dt.Columns.Add("Appointment Date", typeof(DateTime));
                dt.Columns.Add("Appointment Start Time", typeof(TimeSpan));
                dt.Columns.Add("Appointment End Time", typeof(TimeSpan));
                dt.Columns.Add("Appointment Type", typeof(string));
                dt.Columns.Add("Appointment Length", typeof(int));

                var appointmentQuery = from a in appointments.AsEnumerable()
                                       join p in patients.AsEnumerable()
                                       on a.patientID equals p.PatientID
                                       where a.appointmentDate == date && a.arrivedToAppointment == "No"
                                       select dt.LoadDataRow(new object[]
                                       {
                                   a.appointmentID,
                                   p.firstName,
                                   p.lastName,
                                   a.appointmentDate,
                                   a.appointmentStartTime,
                                   a.appointmentEndTime,
                                   a.appointmentType,
                                   a.appointmentLength
                                       }, false);

                appointmentQuery.CopyToDataTable();
            }
            catch (Exception e)
            {
                Console.WriteLine("No Appointments to show" + e.Message);
            }

            return dt;
        }
        public void showAppointmentReminders()
        {
            List<string> csv = new List<string>();

            UnitOfWork unitOfWork = new UnitOfWork(new MyDBEntities());
            var patients = unitOfWork.patient.GetAll();
            var appointments = unitOfWork.appointment.GetAll();

            string fileName = "TextReminders";
            var appointmentList = (from a in appointments.AsEnumerable()
                                   join p in patients.AsEnumerable()
                                   on a.patientID equals p.PatientID
                                   where (a.appointmentDate == DateTime.Today.Date.AddDays(5) || a.appointmentDate == DateTime.Today.Date.AddDays(1))
                                   select new
                                   {
                                       p.firstName,
                                       p.lastName,
                                       p.PhoneNum,
                                       a.appointmentDate,
                                       a.appointmentStartTime,
                                       a.appointmentEndTime
                                   });

            foreach (var a in appointmentList)
            {
                string row = a.firstName + " " + a.lastName + ", " + a.PhoneNum + ", " + a.appointmentDate + ","
                    + a.appointmentStartTime + "," + a.appointmentEndTime;
                csv.Add(row);
            }
            string filePath = @"C:\Users\markb\Documents\Masters\Advanced Programming\Assessment\Github\Team29 Group Project\AppointmentTextReminders\" + fileName + ".txt";
            System.IO.File.WriteAllLines(filePath, csv);
        }
    }
}
