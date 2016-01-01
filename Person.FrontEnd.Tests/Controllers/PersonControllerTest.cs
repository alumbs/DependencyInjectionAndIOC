using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Person.FrontEnd.Models;
using Person.FrontEnd.Interfaces;
using System.Collections.Generic;
using System.Data.Objects.DataClasses;
using Moq;
using Person.FrontEnd.Controllers;
using System.Web.Mvc;

namespace Person.FrontEnd.Tests.Controllers
{
    [TestClass]
    public class PersonControllerTest
    {        
        [TestMethod]
        public void TestGetRandomPerson()
        {
            var people = SetupPeopleList();
            var personRepo = SetupRepository<PersonModel, IPersonRepository>(people);

            //personRepo
            PersonController ctrl = new PersonController(personRepo.Object);
            var result = ctrl.Index() as ViewResult;
            Assert.AreEqual(people[0], result.Model as PersonModel);
            personRepo.Verify(x => x.GetRandom(), Times.Once());
        }

        private Mock<TRepo> SetupRepository<TModel, TRepo>(List<TModel> people)
            where TModel : EntityObject, new()
            where TRepo : class, IRepository<TModel, int>
        {
            Mock<TRepo> repository = new Mock<TRepo>();
            repository.Setup(x => x.GetRandom()).Returns(() => people[0]);

            return repository;
        }

        private List<PersonModel> SetupPeopleList()
        {
            PersonModel person1 = new PersonModel { Id = 1, PersonName = "Person1" };
            PersonModel person2 = new PersonModel { Id = 2, PersonName = "Person3" };
            PersonModel person3 = new PersonModel { Id = 3, PersonName = "Person2" };

            var people = new List<PersonModel> { person1, person2, person3 };

            return people;
        }
    }
}
