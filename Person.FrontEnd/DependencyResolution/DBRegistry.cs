using Person.FrontEnd.Implementation;
using Person.FrontEnd.Interfaces;
using Person.FrontEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Person.FrontEnd.DependencyResolution
{
    public class DBRegistry : StructureMap.Configuration.DSL.Registry
    {
        public DBRegistry()
        {
            For<IPersonRepository>().Singleton().Use<PersonRepository>();
            For<IMessage>().Singleton().Use<Message>();
            //For<IViewPageActivator>().Singleton().Use<StructureMapViewActivator>();
        }
    }
}