using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team29_Group_Project
{
    class ContactedByPhoneModel
    {
        public string setName(int appointmentID)
        {
            using (var context = new MyDBEntities())
            {
                var appointments = context.Appointments.ToList();
                var patients = context.Patients.ToList();
                var appQuery = from a in appointments.AsEnumerable()
                               join p in patients.AsEnumerable()
                               on a.patientID equals p.PatientID
                               where a.appointmentID == appointmentID
                               select new
                               {
                                   forename = p.firstName,
                                   surname = p.lastName
                               };
                var appointment = appQuery.ToList();
                string name = appointment[0].forename + " " + appointment[0].surname;
                return name;
            }
        }
        public DateTime setDate(int appointmentID)
        {
            using (var context = new MyDBEntities())
            {
                var appointments = context.Appointments.ToList();
                var patients = context.Patients.ToList();
                var appQuery = from a in appointments.AsEnumerable()
                               join p in patients.AsEnumerable()
                               on a.patientID equals p.PatientID
                               where a.appointmentID == appointmentID
                               select new
                               {
                                   appointmentDate = a.appointmentDate
                               };
                var appointment = appQuery.ToList();
                return appointment[0].appointmentDate;

            }
        }
        public TimeSpan setTime(int appointmentID)
        {
            using (var context = new MyDBEntities())
            {
                var appointments = context.Appointments.ToList();
                var patients = context.Patients.ToList();
                var appQuery = from a in appointments.AsEnumerable()
                               join p in patients.AsEnumerable()
                               on a.patientID equals p.PatientID
                               where a.appointmentID == appointmentID
                               select new
                               {
                                   appointmentStartTime = a.appointmentStartTime
                               };
                var appointment = appQuery.ToList();
                return appointment[0].appointmentStartTime;
            }
        }
        /*public void setDetails(int appointmentID)
        {
            using (var context = new MyDBEntities())
            {
                var appointments = context.Appointments.ToList();
                var patients = context.Patients.ToList();
                var appQuery = from a in appointments.AsEnumerable()
                               join p in patients.AsEnumerable()
                               on a.patientID equals p.PatientID
                               where a.appointmentID == appointmentID
                               select new
                               {
                                   appointmentDate = a.appointmentDate,
                                   appointmentStartTime = a.appointmentStartTime,
                                   forename = p.firstName,
                                   surname = p.lastName
                               };
                var appointment = appQuery.ToList();
            }
        }
        */
        public void setToContacted(int appointmentID)
        {
            using (var context = new MyDBEntities())
            {
                //https://stackoverflow.com/questions/20832684/update-records-using-linq
                (from a in context.Appointments
                 where a.appointmentID == appointmentID
                 select a).ToList().ForEach(x => x.contacted = "Yes");
                context.SaveChanges();
            }
        }
    }
}
