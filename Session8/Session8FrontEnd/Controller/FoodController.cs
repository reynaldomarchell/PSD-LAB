using Session8.Utility;
using Session8FrontEnd.localhost;
using Session8FrontEnd.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Session8.Controller
{
    public class FoodController
    {
        public static List<Food> GetAllFood()
        {
            WebService1 service = new WebService1();
            return JsonUtil.Decode<List<Food>>(service.GetAllFood());
        }

        public static Boolean InsertFood(string id, string name, int price)
        {
            // 1 < name < 20
            if (name.Length >= 20 || name.Length <= 1)
            {
                return false;
            }
            // price > 1000
            if (price <= 1000)
            {
                return false;
            }
            WebService1 service = new WebService1();
            return service.InsertFood(id, name, price);
        }
    }
}