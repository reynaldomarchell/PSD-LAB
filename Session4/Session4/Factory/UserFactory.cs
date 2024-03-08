using Session4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Session4.Factory
{
    public class UserFactory
    {
        public static User Create (String id, String name)
        {
            User user = new User()
            {
                Id = id,
                Name = name
            };
            return user;
        }
    }
}