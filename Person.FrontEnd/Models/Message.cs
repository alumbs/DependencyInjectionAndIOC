using Person.FrontEnd.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Person.FrontEnd.Models
{
    public class Message : IMessage
    {
        String IMessage.Message()
        {
            return "Hi there, Property dependency injection works";
        }
    }
}