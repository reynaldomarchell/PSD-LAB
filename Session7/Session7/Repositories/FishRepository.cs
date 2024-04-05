using Session7.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Session7.Repositories
{
    public class FishRepository
    {
        public static List<Fish> GetAllFish()
        {
            Database1Entities1 db = DatabaseSingleton.GetInstance();
            List<Fish> fishes = db.Fishes.ToList();
            return fishes;
        }

        public static Fish GetFish(String id)
        {
            Database1Entities1 db = DatabaseSingleton.GetInstance();
            Fish fish = db.Fishes.Find(id);
            return fish;
        }

        public static Fish GetLastFish()
        {
            Database1Entities1 db = DatabaseSingleton.GetInstance();
            Fish fish = db.Fishes.ToList().LastOrDefault();
            return fish;
        }

        public static void CreateFish(Fish fish)
        {
            Database1Entities1 db = DatabaseSingleton.GetInstance();
            db.Fishes.Add(fish);
            db.SaveChanges();
        }

        public static Fish UpdateFish(Fish fish)
        {
            Database1Entities1 db = DatabaseSingleton.GetInstance();
            Fish updatedFish = db.Fishes.Find(fish.Id);

            updatedFish.Id = fish.Id;
            updatedFish.Price = fish.Price;
            updatedFish.Name = fish.Name;
            db.SaveChanges();   

            return updatedFish;
        }

        public static Boolean DeleteFish(String id)
        {
            Database1Entities1 db = DatabaseSingleton.GetInstance();
            Fish fish = db.Fishes.Find(id);
            db.Fishes.Remove(fish);
            db.SaveChanges();
            return true;
        }   
    }
}