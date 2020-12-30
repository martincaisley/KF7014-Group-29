using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Team29_Group_Project;
using Moq;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace Team29TestProject
{
    [TestClass]
    public class RepositoryTest
    {
        [TestMethod]
        public void TestAddToRepository()
        {
            /*
             * code to test the repository object creation from:
             * https://rubikscode.net/2018/04/16/implementing-and-testing-repository-pattern-using-entity-framework/
             */

            var testObject = new Appointment();

            var context = new Mock<MyDBEntities>();
            var dbSetMock = new Mock<DbSet<Appointment>>();

            context.Setup(x => x.Set<Appointment>()).Returns(dbSetMock.Object);
            dbSetMock.Setup(x => x.Add(It.IsAny<Appointment>())).Returns(testObject);

            var repository = new Repository<Appointment>(context.Object);
            repository.Add(testObject);

            context.Verify(x => x.Set<Appointment>());
            dbSetMock.Verify(x => x.Add(It.Is<Appointment>(y => y == testObject)));
        }
    }
}
