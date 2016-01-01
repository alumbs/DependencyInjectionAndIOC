using System;
using System.Collections.Generic;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person.FrontEnd.Interfaces
{
    public interface IRepository<TEntity, TId> where TEntity : EntityObject
    {
        TEntity GetRandom();
    }
}
