using Person.FrontEnd.Interfaces;
using Person.FrontEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person.FrontEnd.Interfaces
{
    public interface IPersonRepository : IRepository<PersonModel, int>
    {
    }
}
