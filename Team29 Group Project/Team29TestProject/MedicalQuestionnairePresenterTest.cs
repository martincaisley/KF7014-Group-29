using System;
using Team29_Group_Project;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Team29TestProject
{
    [TestClass]
    public class MedicalQuestionnairePresenterTest
    {
        Mock<IMedicalQuestionnaireGUI> view;
        MedicalQuestionnairePresenter presenter;
        Mock<IMedicalQuestionnaireModel> model;

        [TestInitialize]
        public void TestInitialiser()
        {
            view = new Mock<IMedicalQuestionnaireGUI>();
            model = new Mock<IMedicalQuestionnaireModel>();
            presenter = new MedicalQuestionnairePresenter(view.Object, model.Object);
        }
        /*[TestMethod]
         Does not work
        public void TestGetMessageResponse()
        {
            string messageToSend = "Hello";
            model.Object.setMessage(messageToSend);
            string response  = presenter.GetMessage();
            Assert.AreEqual("Hello", response);
        }*/
    }
}
