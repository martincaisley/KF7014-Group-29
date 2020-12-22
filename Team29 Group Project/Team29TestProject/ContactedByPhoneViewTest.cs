using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Team29_Group_Project;

namespace Team29TestProject
{
    [TestClass]
    public class ContactedByPhoneViewTest
    {
        [TestMethod]
        public void ConstructorTest()
        {
            ContactedByPhone view = new ContactedByPhone(1);
            int appointmentID = view.getAppointmentID();
            Assert.AreEqual(1, appointmentID);
        }
    }
}
