using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team29_Group_Project
{
    public class AppointmentFactory
    {
        public Appointment GetAppointmentBand(AppointmentBand AppointmentBand)
        {
            if (AppointmentBand == AppointmentBand.Band1)
            {
                return new Band1Appointment();
            }
            else if (AppointmentBand == AppointmentBand.Band2)
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
