using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team29_Group_Project
{
    public class PhoneRemindersPresenter
    {
        private PhoneRemindersModel remindersModel;
        private IPhoneRemindersGUI remindersScreen;

        public PhoneRemindersPresenter(IPhoneRemindersGUI remindersScreen)
        {
            this.remindersScreen = remindersScreen;
            remindersScreen.Register(this);
            remindersModel = new PhoneRemindersModel();
            getPhoneDetails();
        }
        public void getPhoneDetails()
        {
            remindersScreen.setPhoneDetails(remindersModel.getPhoneDetails());
        }

        public void rowSelcted(int index)
        {
            remindersScreen.viewChosenReminder(remindersModel.getAppointmentID(index));
        }
    }
}
