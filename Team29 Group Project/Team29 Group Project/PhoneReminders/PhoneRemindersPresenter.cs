using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
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
            initialiseForm();
        }
        public void initialiseForm()
        {
            getPhoneDetails();
        }
        public void getPhoneDetails()
        {
            DataTable dt = remindersModel.getPhoneDetails();
            if (dt.Rows.Count != 0)
            {
                remindersScreen.setPhoneDetails(dt);
            }
            else
            {
                remindersScreen.noPhoneReminders();
            }
        }

        public void rowSelcted(int index)
        {
            remindersScreen.viewChosenReminder(index);
        }
    }
}
