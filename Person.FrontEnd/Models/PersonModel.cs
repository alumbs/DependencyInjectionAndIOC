using System;
using System.Collections.Generic;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Web;

namespace Person.FrontEnd.Models
{
    public class PersonModel : EntityObject
    {
        public int Id { get; set;  }
        public String PersonName { get; set; }
    }
}