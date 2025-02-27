﻿/*
 * Martin Caisley:17015608
 * Drummond Heckles:17005997
 * Mark Burns:16016013
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Team29_Group_Project
{
    public class PatientDetailsModel: IPatientDetailsModel
    {
        public string getName(int patientID)
        {
            UnitOfWork unitOfWork = new UnitOfWork(new MyDBEntities());
            var UOW = unitOfWork.patient.GetByID(patientID);
            string patientName = UOW.firstName + " " + UOW.lastName;

            unitOfWork.Dispose();
            return patientName;
        }
        public DataTable getAppointmentList(int patientID)
        {
            DataTable dt = new DataTable();
            UnitOfWork unitOfWork = new UnitOfWork(new MyDBEntities());
            try
            {
                var appointments = unitOfWork.appointment.GetAll();
                dt.Columns.Add("Appointment Type", typeof(string));
                dt.Columns.Add("Appointment Date", typeof(DateTime));
                dt.Columns.Add("Appointment Time", typeof(TimeSpan));
                dt.Columns.Add("AppointmentID", typeof(int));

                var appointmentQuery = from a in appointments.AsEnumerable()
                                       where a.patientID == patientID
                                       orderby a.appointmentDate
                                       select dt.LoadDataRow(new object[]
                                       {
                                           a.appointmentType,
                                   a.appointmentDate,
                                   a.appointmentStartTime,
                                   a.appointmentID
                                       }, false);
                appointmentQuery.CopyToDataTable();
            }
            catch (Exception e)
            {
                Console.WriteLine("No Appointments to show" + e.Message);
            }
            unitOfWork.Dispose();
            return dt;
        }

        public void deleteEntry(int appointmentID)
        {
            UnitOfWork unitOfWork = new UnitOfWork(new MyDBEntities());
            Appointment appToDelete = unitOfWork.appointment.GetByID(appointmentID);
            unitOfWork.appointment.Remove(appToDelete);
            unitOfWork.Save();
            unitOfWork.Dispose();
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
                               forename = p.firstName
                           };
            var appointment = appQuery.ToList();
            if (appointment.Count() == 0)
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
        public bool checkQuestionnaireDate(int patientID)
        {
            UnitOfWork unitOfWork = new UnitOfWork(new MyDBEntities());
            var questionnaires = unitOfWork.questionnaire.GetAll();
            try
            {
                //checks to see if questionnaire was modified over a year ago
                var questionnaireDateQuery = from q in questionnaires.AsEnumerable()
                                 where q.patientID == patientID && q.DateCompleted < DateTime.Today.AddYears(-1)
                                 select new
                                 {
                                     q.questionnaireID
                                 };
                var dateQuestionnaireID = questionnaireDateQuery.ToList();

                //checks to see if a questionnaire entry exists
                var questionnaireExistsQuery = from q in questionnaires.AsEnumerable()
                                  where q.patientID == patientID
                                  select new
                                  {
                                      q.questionnaireID
                                  };
                var existsQuestionnaireID = questionnaireExistsQuery.ToList();

                if (dateQuestionnaireID.Count > 0 || existsQuestionnaireID.Count == 0)
                {
                    unitOfWork.Dispose();
                    return true;
                }
                else
                {
                    unitOfWork.Dispose();
                    return false;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("No questionnaire to show " + e.Message);
            }
            unitOfWork.Dispose();
            return false;
        }

        public bool checkRepeatOffences(int patientID)
        {
            UnitOfWork unitOfWork = new UnitOfWork(new MyDBEntities());
            var appointments = unitOfWork.appointment.GetAll();
            try
            {
                //checks how many missed appointments exist for this patient
                var repeatOffenceQuery = from a in appointments.AsEnumerable()
                                     where a.patientID == patientID && a.arrivedToAppointment == "Invalid" && a.appointmentDate >= DateTime.Today.AddYears(-3)
                                     group a by a.patientID into grouped
                                     select new
                                     {
                                         count = grouped.Count()
                                     };
                var offences = repeatOffenceQuery.ToList();
                int numberOfOffences = offences[0].count;
                if (numberOfOffences >= 3)
                {
                    unitOfWork.Dispose();
                    return true;
                }
                else
                {
                    unitOfWork.Dispose();
                    return false;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("No offences to show " + e.Message);
            }
            unitOfWork.Dispose();
            return false;
        }
    }
}
