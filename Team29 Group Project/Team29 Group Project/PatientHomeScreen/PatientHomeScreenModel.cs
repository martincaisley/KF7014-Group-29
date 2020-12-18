using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team29_Group_Project
{
    class PatientHomeScreenModel
    {
        public DataTable getDT()
        {
            DataTable dt = new DataTable();
            try
            {
                UnitOfWork unitOfWork = new UnitOfWork(new MyDBEntities());
                var patients = unitOfWork.patient.GetAll();

                dt.Columns.Add("PatientID", typeof(int));
                dt.Columns.Add("Patient Name", typeof(string));
                dt.Columns.Add("Patient Phone Number", typeof(string));


                var patientQuery = from p in patients.AsEnumerable()
                                   select dt.LoadDataRow(new object[]
                                   {
                                           p.PatientID,
                                p.firstName + " " + p.lastName,
                                p.PhoneNum
                                   }, false);

                patientQuery.CopyToDataTable();
            }
            catch (Exception e)
            {
                Console.WriteLine("Home Screen Exception: " + e.Message);
                //add in exception here
            }
            return dt;
        }
        internal void deleteEntry(int patientID)
        {
            UnitOfWork unitOfWork = new UnitOfWork(new MyDBEntities());
            Patient patientToDelete = unitOfWork.patient.GetByID(patientID);
            unitOfWork.patient.Remove(patientToDelete);
            unitOfWork.Save();
        }
        /*
        public bool checkForLastApp(patientID)
        {
            
                UnitOfWork unitOfWork = new UnitOfWork(MyDBEntities());
                
                var patToRemove = unitOfWork.appointment.GetAll().Where(pats => pats.patientID == patientID);
                if (!patToRemove.Any())
                {
                    var patientsToRemoveQuery = from p in patients.AsEnumerable()
                                                where p.PatientID == patientIDs[i].PatientID
                                                select dt.LoadDataRow(new object[]
                                               {
                                                   p.PatientID,
                                                    p.firstName + " " + p.lastName,
                                                     p.PhoneNum
                                               }, false);


                    patientsToRemoveQuery.CopyToDataTable();
                }
                else
                {
                    var pat = patToRemove.OrderBy(app => app.appointmentDate);
                    var last = pat.Last().appointmentDate;
                    Console.WriteLine(last.ToString());

                    if (last < DateTime.Today.Date.AddYears(-1))
                    {
                        var patientsToRemoveQuery = from p in patients.AsEnumerable()
                                                    where p.PatientID == patientIDs[i].PatientID
                                                    select dt.LoadDataRow(new object[]
                                                   {
                                                   p.PatientID,
                                                    p.firstName + " " + p.lastName,
                                                     p.PhoneNum
                                                   }, false);


                        patientsToRemoveQuery.CopyToDataTable();
                    }
                }
            return true;

        }
            */
    }
}
