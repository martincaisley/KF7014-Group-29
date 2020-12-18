using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Team29_Group_Project;

namespace Team29TestProject
{
    [TestClass]
    public class AppointmentFactoryTests
    {
        [TestMethod]
        public void TestAppointmentFactoryGetAppointmentBand()
        {
        }
        [TestMethod]
        public void TestFactoryCosts()
        {
            AppointmentFactory factory = new AppointmentFactory();
            Appointment a = factory.GetAppointmentBand(AppointmentBand.Band1);
            Assert.AreEqual(22.70,a.appointmmentCost);
        }
        /*
        [TestMethod]
        public void TestFactoryCostsToFail()
        {
            AppointmentFactory factory = new AppointmentFactory();
            Appointment a = factory.GetAppointmentBand(AppointmentBand.Band2);
            Assert.AreEqual(22.70, a.appointmmentCost);
        }
        */
    }
}
