using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team29_Group_Project
{
    public interface IContactedByPhoneGUI
    {
        void setPatientName(string name);
        void setAppointmentDate(DateTime date);
        void setAppointmentTime(TimeSpan time);
        void Register(ContactedByPhonePresenter CBPP);
    }
}
