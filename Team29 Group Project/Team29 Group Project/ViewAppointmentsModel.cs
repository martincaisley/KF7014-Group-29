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
        public DataTable getDT()
        {
            DataTable dt = new DataTable();
            try
            {
                using (var context = new MyDBEntities())
                {
                    var patients = context.Patients.ToList();
                    var appointments = context.Appointments.ToList();

                    dt.Columns.Add("Patient Forename", typeof(string));
                    dt.Columns.Add("Patient Surname", typeof(string));
                    dt.Columns.Add("Appointment Date", typeof(DateTime));
                    dt.Columns.Add("Appointment Start Time", typeof(DateTime));
                    dt.Columns.Add("Appointment End Time", typeof(DateTime));
                    dt.Columns.Add("Appointment Type", typeof(string));
                    dt.Columns.Add("Appointment Length", typeof(int));

                    var appointmentQuery = from a in appointments.AsEnumerable()
                                           join p in patients.AsEnumerable()
                                           on a.patientID equals p.PatientID
                                           select dt.LoadDataRow(new object[]
                                           {
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
            }
            catch
            {

            }

            return dt;
        }
        public int getAppointmentID(int rowIndex)
        {
            using (var context = new MyDBEntities())
            {
                var appointments = context.Appointments.ToList();
                int appointmentID = appointments[rowIndex].appointmentID;

                return appointmentID;
            }
            
        }
        public void showAppointmentReminders()
        {
            using (var context = new MyDBEntities())
            {
                List<string> csv = new List<string>();

                var patients = context.Patients.ToList();
                var appointments = context.Appointments.ToList();
                string fileName = "TextReminders";
                var appointmentList = (from a in appointments.AsEnumerable()
                                       join p in patients.AsEnumerable()
                                       on a.patientID equals p.PatientID
                                       select new
                                       {
                                           p.firstName,
                                           p.lastName,
                                           p.PhoneNum,
                                           a.appointmentDate,
                                           a.appointmentStartTime,
                                           a.appointmentEndTime,
                                           a.appointmentLength,
                                           a.appointmentType
                                       });

                foreach (var a in appointmentList)
                {
                    string row = a.firstName + "," + a.lastName + ", " + a.PhoneNum + ", " + a.appointmentDate + ","
                        + a.appointmentStartTime + "," + a.appointmentEndTime + "," + a.appointmentLength + "," + a.appointmentType;
                    csv.Add(row);
                }
                string filePath = @"C:\Users\markb\Documents\Masters\Advanced Programming\Assessment\Github\Team29 Group Project\AppointmentTextReminders\" + fileName + ".txt";
                System.IO.File.WriteAllLines(filePath, csv);
            }
        }
    }
}
