using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team29_Group_Project
{
    public class ContactedByPhonePresenter
    {
        private ContactedByPhoneModel contactedModel;
        private IContactedByPhoneGUI contactedScreen;

        public ContactedByPhonePresenter(IContactedByPhoneGUI contactedScreen)
        {
            this.contactedScreen = contactedScreen;
            contactedScreen.Register(this);
            contactedModel = new ContactedByPhoneModel();
        }

        public void getDetails(int appointmentID)
        {
            contactedScreen.setPatientName(contactedModel.setName(appointmentID));
            contactedScreen.setAppointmentDate(contactedModel.setDate(appointmentID));
            contactedScreen.setAppointmentTime(contactedModel.setTime(appointmentID));
        }

        public void setContacted(int appointmentID)
        {
            contactedModel.setToContacted(appointmentID);
        }

    }
}
