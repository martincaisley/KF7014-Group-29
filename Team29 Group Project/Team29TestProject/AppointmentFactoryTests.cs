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
        public void TestFactoryBand1Costs()
        {
            AppointmentFactory factory = new AppointmentFactory();
            Appointment a = factory.GetAppointmentBand(AppointmentBand.Band1);
            Assert.AreEqual(22.70,a.appointmmentCost);
        }
        
        [TestMethod]
        public void TestFactoryBand1CostsToFail()
        {
            AppointmentFactory factory = new AppointmentFactory();
            Appointment a = factory.GetAppointmentBand(AppointmentBand.Band1);
            Assert.AreNotEqual(122.70, a.appointmmentCost);
        }
        [TestMethod]
        public void TestFactoryBand2Costs()
        {
            AppointmentFactory factory = new AppointmentFactory();
            Appointment a = factory.GetAppointmentBand(AppointmentBand.Band2);
            Assert.AreEqual(122.70, a.appointmmentCost);
        }

        [TestMethod]
        public void TestFactoryBand2CostsToFail()
        {
            AppointmentFactory factory = new AppointmentFactory();
            Appointment a = factory.GetAppointmentBand(AppointmentBand.Band2);
            Assert.AreNotEqual(222.70, a.appointmmentCost);
        }
        [TestMethod]
        public void TestFactoryBand3Costs()
        {
            AppointmentFactory factory = new AppointmentFactory();
            Appointment a = factory.GetAppointmentBand(AppointmentBand.Band3);
            Assert.AreEqual(222.70, a.appointmmentCost);
        }

        [TestMethod]
        public void TestFactoryBand3CostsToFail()
        {
            AppointmentFactory factory = new AppointmentFactory();
            Appointment a = factory.GetAppointmentBand(AppointmentBand.Band3);
            Assert.AreNotEqual(22.70, a.appointmmentCost);
        }

    }
}
