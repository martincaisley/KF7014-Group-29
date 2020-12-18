using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team29_Group_Project
{
    public class MessagesPresenter
    {
        private MessagesModel messagesModel;
        private IMessagesGUI messagesScreen;

        public MessagesPresenter(IMessagesGUI messagesScreen)
        {
            this.messagesScreen = messagesScreen;
            messagesScreen.Register(this);
            messagesModel = new MessagesModel();
            initialiseForm();
        }
        public void initialiseForm()
        {
            messagesScreen.setAppID(messagesModel.getAppointmentID(messagesScreen.getPatientID()));
            messagesScreen.setName(messagesModel.getName(messagesScreen.getPatientID()));
            messagesScreen.setAppDate(messagesModel.getDate(messagesScreen.getPatientID()));
            messagesScreen.setAppTime(messagesModel.getTime(messagesScreen.getPatientID()));
        }

        public void updateTable()
        {
            messagesModel.updateTables(messagesScreen.getPatientID(), messagesScreen.getResponse());
        }

        public bool checkForRepeatOffence()
        {
            return messagesModel.checkForRepeatOffence(messagesScreen.getPatientID());
        }
    }
}
