using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team29_Group_Project
{
    public interface IAppointmentStatusGUI
    {
        void setPatientName(string name);
        void setAppointmentTime(TimeSpan appTime);
        void Register(AppointmentStatusPresenter ASP);
    }

}
