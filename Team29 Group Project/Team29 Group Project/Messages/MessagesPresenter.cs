﻿/*
 * Martin Caisley:17015608
 * Drummond Heckles:17005997
 * Mark Burns:16016013
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team29_Group_Project
{
    public class MessagesPresenter
    {
        private IMessagesModel messagesModel;
        private IMessagesGUI messagesScreen;

        public MessagesPresenter(IMessagesGUI messagesScreen, IMessagesModel messagesModel)
        {
            this.messagesScreen = messagesScreen;
            messagesScreen.Register(this);
            this.messagesModel = messagesModel;
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
            messagesModel.updateTables(messagesScreen.getAppointmentID(), messagesScreen.getResponse());
        }

        public bool checkForRepeatOffence()
        {
            return messagesModel.checkForRepeatOffence(messagesScreen.getPatientID());
        }
    }
}
