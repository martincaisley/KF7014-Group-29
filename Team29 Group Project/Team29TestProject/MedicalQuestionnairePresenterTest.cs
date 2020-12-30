/*
 * Martin Caisley:17015608
 * Drummond Heckles:17005997
 * Mark Burns:16016013
 */
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
      
    }
}
