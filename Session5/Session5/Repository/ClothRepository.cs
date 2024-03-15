using Session5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Session5.Repository
{
    public class ClothRepository
    {
        Database1Entities db = new Database1Entities();

        // Get all data

        // public IQueryable<Cloth> GetAllCloth()
        // {
        //     return (from x in db.Clothes select x);
        // }        
        public List<Cloth> GetAllCloth()
        {
            return (from x in db.Clothes select x).ToList();
        }

        // Find data
        public Cloth FindById(string id)
        {
            return (from x in db.Clothes where x.Id == id select x).FirstOrDefault();
        }

        // Aggregate
        public int GetClothCount()
        {
            return (from x in db.Clothes select x).Count();
        }
        public int GetClothTotalPrice()
        {
            return (from x in db.Clothes select x).Sum( x => x.Price );
        }

    }
}