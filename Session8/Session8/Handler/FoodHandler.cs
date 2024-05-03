using Session8.Model;
using Session8.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Session8.Handler
{
    public class FoodHandler
    {
        public static List<Food> GetAllFood()
        {
            return FoodRepo.GetAllFood();
        }

        public static Boolean InsertFood(string id, string name, int price)
        {
            if(FoodRepo.FindById(id) == null)
            {
                FoodRepo.InsertFood(id, name, price);
                return true;
            }
            return false;
        }
    }
}