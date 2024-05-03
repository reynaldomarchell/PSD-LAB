using Session8.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Session8.Repository
{
    public class FoodRepo
    {
        static Database1Entities db = new Database1Entities();

        public static List<Food> GetAllFood()
        {
            return db.Foods.ToList();
        }

        public static void InsertFood(string id, string name, int price)
        {
            Food food = new Food();

            food.Id = id;
            food.Name = name;
            food.Price = price;
            db.Foods.Add(food);
            db.SaveChanges();
        }

        public static Food FindById(string id)
        {
            return (from x in db.Foods where x.Id.Equals(id) select x).FirstOrDefault();
        }
    }
}