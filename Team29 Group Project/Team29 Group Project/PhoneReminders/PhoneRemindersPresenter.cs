/*
 * Martin Caisley:17015608
 * Drummond Heckles:17005997
 * Mark Burns:16016013
 */
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
        private IPhoneRemindersModel remindersModel;
        private IPhoneRemindersGUI remindersScreen;

        public PhoneRemindersPresenter(IPhoneRemindersGUI remindersScreen, IPhoneRemindersModel remindersModel)
        {
            this.remindersScreen = remindersScreen;
            remindersScreen.Register(this);
            this.remindersModel = remindersModel;
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
