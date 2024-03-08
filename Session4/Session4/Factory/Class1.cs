using Session4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Session4.Factory
{
    public class Class1
    {
        Book book = BookFactory.Create("BO001", "The Hobbit", "J.R.R. Tolkien", 20000);
    }
}