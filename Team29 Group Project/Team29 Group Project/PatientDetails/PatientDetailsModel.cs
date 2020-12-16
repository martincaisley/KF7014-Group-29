using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Team29_Group_Project
{
    class PatientDetailsModel
    {
        public String getName(int patientID)
        {
            UnitOfWork unitOfWork = new UnitOfWork(new MyDBEntities());
            var UOW = unitOfWork.patient.GetByID(patientID);
            string patientName = UOW.firstName + " " + UOW.lastName;

            return patientName;
        }
        public DataTable getDT(int patientID)
        {
            DataTable dt = new DataTable();
            try
            {
                UnitOfWork unitOfWork = new UnitOfWork(new MyDBEntities());
                var appointments = unitOfWork.appointment.GetAll();
                dt.Columns.Add("Appointment Date", typeof(DateTime));
                dt.Columns.Add("Appointment Time", typeof(TimeSpan));

                var appointmentQuery = from a in appointments.AsEnumerable()
                                       where a.patientID == patientID
                                       select dt.LoadDataRow(new object[]
                                       {
                                   a.appointmentDate,
                                   a.appointmentStartTime
                                       }, false);
                appointmentQuery.CopyToDataTable();
            }
            catch (Exception e)
            {
                Console.WriteLine("No Appointments to show" + e.Message);
            }
            return dt;
        }
        public bool messagesToView(int patientID)
        {
            UnitOfWork unitOfWork = new UnitOfWork(new MyDBEntities());
            var patients = unitOfWork.patient.GetAll();
            var appointments = unitOfWork.appointment.GetAll();

            var appQuery = from a in appointments.AsEnumerable()
                           join p in patients.AsEnumerable()
                           on a.patientID equals p.PatientID
                           where p.PatientID == patientID && a.arrivedToAppointment == "No" && a.appointmentDate < DateTime.Today
                           select new
                           {
                               forename = p.firstName,
                               surname = p.lastName,
                               appointmentDate = a.appointmentDate,
                               appointmentStartTime = a.appointmentStartTime
                           };
            var appointment = appQuery.ToList();
            if (appointment.Count() == 0)
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
