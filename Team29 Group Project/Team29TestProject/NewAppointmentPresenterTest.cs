/*
 * Martin Caisley:17015608
 * Drummond Heckles:17005997
 * Mark Burns:16016013
 */
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using NSubstitute;
using Team29_Group_Project;

namespace Team29TestProject
{
    [TestClass]
    public class NewAppointmentMVPTest
    {    
        Mock<INewAppointmentsGUI> view;
        NewAppointmentsPresenter presenter;
        Mock<INewAppointmentsModel> model;

        [TestInitialize]
        public void TestInitialiser()
        {
            view = new Mock<INewAppointmentsGUI>();
            model = new Mock<INewAppointmentsModel>();

            presenter = new NewAppointmentsPresenter(view.Object, model.Object);
        }

        [TestMethod]
        public void TestGetBandFromAppointmentType()
        {
            string appType = "Checkup";
            string result = presenter.findAppBand(appType);
            Assert.AreEqual("Band1", result);
        }
        [TestMethod]
        public void TestGetBandFromAppointmentTypeFail()
        {
            string appType = "Veneer";
            string result = presenter.findAppBand(appType);
            Assert.AreNotEqual("Band1", result);
        }

        [TestMethod]
        public void TestAppTypeCheckedValidation()
        {
            string appType = "Checkup";
            bool result = presenter.appointmentRadioChecked(appType);
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void TestAppTypeCheckedValidationFail()
        {
            string appType = "";
            bool result = presenter.appointmentRadioChecked(appType);
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void TestAppDateNotBeforeTodayValidation()
        {
            DateTime date = DateTime.Today.Date;
            bool result = presenter.appDateBeforeToday(date);
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void TestAppDateNotBeforeTodayValidationFail()
        {
            DateTime date = DateTime.Today.Date.AddDays(-1);
            bool result = presenter.appDateBeforeToday(date);
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void TestEndTimeNotBeforeStartTimeValidation()
        {
            TimeSpan startTime = TimeSpan.Parse("10:00");
            TimeSpan endTime = TimeSpan.Parse("10:30");
            bool result = presenter.endTimeBeforeStartTime(startTime,endTime);
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void TestEndTimeNotBeforeStartTimeValidationFail()
        {
            TimeSpan startTime = TimeSpan.Parse("11:00");
            TimeSpan endTime = TimeSpan.Parse("10:30");
            bool result = presenter.endTimeBeforeStartTime(startTime, endTime);
            Assert.AreEqual(false, result);
        }
       

        [TestMethod]
        public void TestAppIsInWorkingHoursValidation()
        {
            TimeSpan startTime = TimeSpan.Parse("10:00");
            TimeSpan endTime = TimeSpan.Parse("10:30");
            bool result = presenter.checkInWorkingHours(startTime, endTime);
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void TestAppIsInWorkingHoursValidationFail()
        {
            TimeSpan startTime = TimeSpan.Parse("08:00");
            TimeSpan endTime = TimeSpan.Parse("08:30");
            bool result = presenter.checkInWorkingHours(startTime, endTime);
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void TestCheckEmergencyAppointmentAllowedValidation()
        {
            DateTime date = DateTime.Today.Date;
            TimeSpan startTime = TimeSpan.Parse("11:00");
            TimeSpan endTime = TimeSpan.Parse("11:30");
            bool result = presenter.checkEmergency(date, startTime, endTime);
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void TestCheckEmergencyAppointmentAllowedValidationFail()
        {
            DateTime date = DateTime.Today.Date.AddDays(1);
            TimeSpan startTime = TimeSpan.Parse("12:00");
            TimeSpan endTime = TimeSpan.Parse("12:30");
            bool result = presenter.checkEmergency(date, startTime, endTime);
            Assert.AreEqual(false, result);
        }
    }
}
