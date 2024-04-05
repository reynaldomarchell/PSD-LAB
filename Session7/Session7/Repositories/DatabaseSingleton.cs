using Session7.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Session7.Repositories
{
    public class DatabaseSingleton
    {
        public static Database1Entities1 instance;

        public static Database1Entities1 GetInstance()
        {
            if (instance == null)
            {
                instance = new Database1Entities1();
            }
            return instance;
        }
    }
}