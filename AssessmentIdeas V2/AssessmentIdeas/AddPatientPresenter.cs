using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentIdeas
{
    public class AddPatientPresenter
    {
        private AddPatientModel addPatientModel;
        private IAddPatientGUI addPatientScreen;
        
        public AddPatientPresenter(IAddPatientGUI addPatientScreen)
        {
            this.addPatientScreen = addPatientScreen;
            addPatientScreen.Register(this);
            addPatientModel = new AddPatientModel();
        }
        public void updateView()
        {
            processNewPatient();
        }
        public void processNewPatient()
        {
            string name = addPatientScreen.getName();
            string address = addPatientScreen.getAddress();
            string phoneNumber = addPatientScreen.getPhoneNumber();
            addPatientModel.addPatient(name, address, phoneNumber);
        }
    }
}
