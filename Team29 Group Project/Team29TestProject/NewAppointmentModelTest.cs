using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Team29_Group_Project;

namespace Team29TestProject
{
    [TestClass]
    public class NewAppointmentModelTest
    {
        [TestMethod]
        public void TestAppointmentLengthReturn()
        {
            NewAppointmentsModel newAppointmentsModel = new NewAppointmentsModel();
            int appLength = newAppointmentsModel.getAppointmentLength("Checkup");
            Assert.AreEqual(30, appLength);

        }
    }
}
