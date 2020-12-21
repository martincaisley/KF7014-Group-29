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

        [TestMethod]
        public void TestAddToDatabase()
        {
            NewAppointmentsModel newAppointmentsModel = new NewAppointmentsModel();

            int patientID = 1;
            DateTime appointmentDate = DateTime.Today.Date;
            TimeSpan appointmentStartTime = TimeSpan.Parse("11:00:00");
            TimeSpan appointmentEndTime = TimeSpan.Parse("11:30:00");
            int appointmentLength = 30;
            string appointmentType = "Checkup";
            string appointmentBand = "Band1";
            int cost = 0;


            newAppointmentsModel.AddAppointmentToDatabase(patientID, appointmentDate, appointmentStartTime, appointmentEndTime, appointmentLength, appointmentType, appointmentBand);

            Assert.AreEqual(1, patientID);
            //Assert.AreEqual(22.70, cost);
        }
    }
}
