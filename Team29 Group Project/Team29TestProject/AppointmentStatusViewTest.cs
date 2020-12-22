using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Team29_Group_Project;

namespace Team29TestProject
{
    [TestClass]
    public class AppointmentStatusViewTest
    {
        [TestMethod]
        public void TestConstructor()
        {
            AppointmentStatus view = new AppointmentStatus(1);
            int appointmentID = view.getAppointmentID();
            Assert.AreEqual(1, appointmentID);
        }
    }
}
