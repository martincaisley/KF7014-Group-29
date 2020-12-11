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
    }
}
