using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Team29_Group_Project;

namespace Team29TestProject
{
    [TestClass]
    public class NewAppointmentViewTest
    {
        [TestMethod]
        public void TestConstructor()
        {
            NewAppointment view = new NewAppointment(1);
            int patientID = view.getPatientID();
            Assert.AreEqual<int>(1, patientID);
        }
    }
}
