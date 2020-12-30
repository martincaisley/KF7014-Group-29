/*
 * Martin Caisley:17015608
 * Drummond Heckles:17005997
 * Mark Burns:16016013
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team29_Group_Project
{
    class AppointmentStatusModel : IAppointmentStatusModel
    {
        
        public string setName(int appointmentID)
        {
            UnitOfWork unitOfWork = new UnitOfWork(new MyDBEntities());
            var app = unitOfWork.appointment.GetByID(appointmentID);
            var pat = unitOfWork.patient.GetByID(app.patientID);
            string patientName = pat.firstName + " " + pat.lastName;
            unitOfWork.Dispose();
            return patientName;
        }
        public TimeSpan setTime(int appointmentID)
        {
            UnitOfWork unitOfWork = new UnitOfWork(new MyDBEntities());
            var UOW = unitOfWork.appointment.GetByID(appointmentID);
            TimeSpan time = UOW.appointmentStartTime;
            unitOfWork.Dispose();
            return time;
        }
        public double setCost(int appointmentID)
        {
            UnitOfWork unitOfWork = new UnitOfWork(new MyDBEntities());
            var UOW = unitOfWork.appointment.GetByID(appointmentID);
            double cost = UOW.appointmmentCost;
            unitOfWork.Dispose();
            return cost;
        }
        public void updateTable(int appointmentID, string appointmentStatus)
        {
            UnitOfWork unitOfWork = new UnitOfWork(new MyDBEntities());
            Appointment a = unitOfWork.appointment.GetByID(appointmentID);
            a.arrivedToAppointment = appointmentStatus;
            unitOfWork.Save();
            unitOfWork.Dispose();
        }
    }
}
