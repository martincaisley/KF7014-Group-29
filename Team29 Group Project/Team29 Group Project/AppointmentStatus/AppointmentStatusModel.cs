using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team29_Group_Project
{
    class AppointmentStatusModel : IAppointmentStatusModel
    {
        UnitOfWork unitOfWork = new UnitOfWork(new MyDBEntities());
        public string setName(int appointmentID)
        {
            var app = unitOfWork.appointment.GetByID(appointmentID);
            var pat = unitOfWork.patient.GetByID(app.patientID);

            string patientName = pat.firstName + " " + pat.lastName;
            return patientName;
        }
        public TimeSpan setTime(int appointmentID)
        {
            var UOW = unitOfWork.appointment.GetByID(appointmentID);
            TimeSpan time = UOW.appointmentStartTime;

            return time;
        }
        public double setCost(int appointmentID)
        {
            var UOW = unitOfWork.appointment.GetByID(appointmentID);
            double cost = UOW.appointmmentCost;

            return cost;
        }
        public void updateTable(int appointmentID, string appointmentStatus)
        {
            Appointment a = unitOfWork.appointment.GetByID(appointmentID);
            a.arrivedToAppointment = appointmentStatus;
            unitOfWork.Save();
        }
    }
}
