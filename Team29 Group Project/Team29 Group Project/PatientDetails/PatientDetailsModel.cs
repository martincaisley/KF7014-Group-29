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
        public DataTable getDT(int patientID)
        {
            try
            {
                using (var context = new MyDBEntities())
                {
                    var appointments = context.Appointments.ToList();

                    DataTable dt = new DataTable();
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
                    return dt;
                }
            }
            catch
            {
                return null;
            }
        }
        public bool messagesToView(int patientID)
        {
            using (var context = new MyDBEntities())
            {
                var appointments = context.Appointments.ToList();
                var patients = context.Patients.ToList();
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
}
