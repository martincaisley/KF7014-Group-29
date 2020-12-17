using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team29_Group_Project
{
    public enum AppointmentCost
    {
        Band1 = 1,
        Band2 = 2,
        Band3 = 3
    }
    public class AppointmentFactory
    {
        public Appointment GetAppointmentCost(AppointmentCost appointmentCost)
        {
            if (appointmentCost == AppointmentCost.Band1)
            {
                return new Band1Appointment();
            }
            else if (appointmentCost == AppointmentCost.Band2)
            {
                return new Band2Appointment();
            }
            else
            {
                return new Band3Appointment();
            }
        }
    }
}
