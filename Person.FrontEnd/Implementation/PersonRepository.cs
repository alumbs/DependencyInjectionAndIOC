using Person.FrontEnd.Interfaces;
using Person.FrontEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Person.FrontEnd.Implementation
{
    public class PersonRepository : IPersonRepository
    {
        public PersonModel GetRandom()
        {
            return new PersonModel { Id = 50, PersonName = "Injected Person" };
        }
    }
}