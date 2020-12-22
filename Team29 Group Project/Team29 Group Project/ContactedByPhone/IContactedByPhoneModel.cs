using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team29_Group_Project
{
    public interface IContactedByPhoneModel
    {
        string setName(int appointmentID);
        DateTime setDate(int appointmentID);
        TimeSpan setTime(int appointmentID);
        void setToContacted(int appointmentID);

    }
}
