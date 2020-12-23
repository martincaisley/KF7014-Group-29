using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team29_Group_Project
{
    public interface IMessagesGUI
    {
        void setName(string name);
        void setAppDate(DateTime date);
        void setAppTime(TimeSpan time);
        void setAppID(int appID);
        void Register(MessagesPresenter MP);
        int getPatientID();
        string getResponse();
        int getAppointmentID();
    }
}
