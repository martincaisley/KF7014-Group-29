using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Team29_Group_Project
{
    class PhoneRemindersModel
    {
        public DataTable getPhoneDetails()
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
                    dt.Columns.Add("Patient Phone Number", typeof(string));
                    dt.Columns.Add("Appointment Date", typeof(DateTime));
                    dt.Columns.Add("Appointment Start Time", typeof(TimeSpan));
                    dt.Columns.Add("Appointment End Time", typeof(TimeSpan));
                    dt.Columns.Add("Appointment Length", typeof(int));
                    dt.Columns.Add("Appointment Type", typeof(string));

                    var phoneQuery = from a in appointments.AsEnumerable()
                                     join p in patients.AsEnumerable()
                                     on a.patientID equals p.PatientID
                                     where a.contacted == "No" && a.appointmentLength >= 40 && (a.appointmentDate == DateTime.Today.Date.AddDays(3) || a.appointmentDate == DateTime.Today.Date.AddDays(2))
                                     select dt.LoadDataRow(new object[]
                                     {
                                         a.appointmentID,
                                    p.firstName,
                                    p.lastName,
                                    p.PhoneNum,
                                    a.appointmentDate,
                                    a.appointmentStartTime,
                                    a.appointmentEndTime,
                                    a.appointmentLength,
                                    a.appointmentType
                                     }, false);
                    phoneQuery.CopyToDataTable();
            }
            catch (Exception f)
            {
                Console.WriteLine("Exception in Phone Reminders Model: " + f.Message);
            }
            return dt;
        }
    }
}
