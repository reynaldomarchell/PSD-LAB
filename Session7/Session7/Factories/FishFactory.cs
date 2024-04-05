using Session7.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Session7.Factories
{
    public class FishFactory
    {
        public static Fish Create(String id, String name, int price)
        {
            Fish fish = new Fish()
            {
                Id = id,
                Name = name,
                Price = price,
            };
            return fish;
        }
    }
}