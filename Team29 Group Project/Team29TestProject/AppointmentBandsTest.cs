using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Team29_Group_Project;

namespace Team29TestProject
{
    [TestClass]
    public class AppointmentBandsTest
    {
        [TestMethod]
        public void TestBand1AppointmentBandCheck()
        {
            Band1Appointment band1 = new Band1Appointment();
            Assert.AreEqual(22.70, band1.appointmmentCost);
        }
        [TestMethod]
        public void TestBand2AppointmentBandCheck()
        {
            Band2Appointment band2 = new Band2Appointment();
            Assert.AreEqual(122.70, band2.appointmmentCost);
        }
        [TestMethod]
        public void TestBan3AppointmentBandCheck()
        {
            Band3Appointment band3 = new Band3Appointment();
            Assert.AreEqual(222.70, band3.appointmmentCost);
        }
    }
}