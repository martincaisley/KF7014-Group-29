using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentIdeas
{
    public interface IAddPatientGUI
    {
        String getName();
        String getAddress();
        String getPhoneNumber();
        void setName(String name);
        void setAddress(String address);
        void setPhoneNumber(String phoneNumber);
        void Register(AddPatientPresenter APP);
    }
}
