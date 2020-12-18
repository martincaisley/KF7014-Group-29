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
            initaliseForm();            
        }

        public void initaliseForm()
        {
            contactedScreen.setPatientName(contactedModel.setName(contactedScreen.getAppointmentID()));
            contactedScreen.setAppointmentDate(contactedModel.setDate(contactedScreen.getAppointmentID()));
            contactedScreen.setAppointmentTime(contactedModel.setTime(contactedScreen.getAppointmentID()));
        }

        public void setContacted()
        {
            contactedModel.setToContacted(contactedScreen.getAppointmentID());
        }

    }
}
