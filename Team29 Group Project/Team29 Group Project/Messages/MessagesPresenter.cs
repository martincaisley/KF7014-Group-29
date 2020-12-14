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
        }
        public void getDetaisl(int patientID)
        {
            messagesScreen.setAppID(messagesModel.getID(patientID));
            messagesScreen.setName(messagesModel.getName(patientID));
            messagesScreen.setAppDate(messagesModel.getDate(patientID));
            messagesScreen.setAppTime(messagesModel.getTime(patientID));

        }

        public void updateTable(int appointmentID, string value)
        {
            messagesModel.updateTables(appointmentID, value);
        }

        public bool checkForRepeatOffence(int patientID)
        {
            return messagesModel.checkForRepeatOffence(patientID);
        }
    }
}
