/*
 * Martin Caisley:17015608
 * Drummond Heckles:17005997
 * Mark Burns:16016013
 */
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Team29_Group_Project;
using Moq;

namespace Team29TestProject
{
    [TestClass]
    public class PatientRegistrationPresenterTest
    {
        Mock<IPatientRegistrationGUI> view;
        PatientRegistrationPresenter presenter;
        Mock<IPatientRegistrationModel> model;

        [TestInitialize]
        public void TestInitialiser()
        {
            view = new Mock<IPatientRegistrationGUI>();
            model = new Mock<IPatientRegistrationModel>();
            presenter = new PatientRegistrationPresenter(view.Object, model.Object);
        }

        [TestMethod]
        public void TestIsFirstNameOnlyLetters()
        {
            string input = "Eduardo";
            bool result = presenter.IsFirstNameOnlyLetters(input);
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void TestIsFirstNameOnlyLettersFail()
        {
            string input = "Eduar7";
            bool result = presenter.IsFirstNameOnlyLetters(input);
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void TestIsLastNameOnlyLetters()
        {
            string input = "Dixon";
            bool result = presenter.IsSurnameOnlyLetters(input);
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void TestIsLastNameOnlyLettersFail()
        {
            string input = "D1x0n";
            bool result = presenter.IsSurnameOnlyLetters(input);
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void TestPhoneNumberOnlyNumber()
        {
            string input = "01234567891";
            bool result = presenter.IsPhoneNumberOnlyNumbers(input);
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void TestPhoneNumberOnlyNumberFalse()
        {
            string input = "phoneNumber";
            bool result = presenter.IsPhoneNumberOnlyNumbers(input);
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void TestGPNameText()
        {
            string input = "Dr Brown";
            bool result = presenter.IsGPNameText(input);
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void TestGPNameTextFail()
        {
            string input = "Dr Br0wn123";
            bool result = presenter.IsGPNameText(input);
            Assert.AreEqual(false, result);
        }
    }
}
