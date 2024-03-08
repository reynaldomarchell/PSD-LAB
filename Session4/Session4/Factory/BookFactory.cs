using Session4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Session4.Factory
{
    public class BookFactory
    {
        public static Book Create (String id, String title, String author, int price)
        {
            Book book = new Book()
            {
                Id = id,
                Title = title,
                Author = author,
                Price = price
            };
            return book;
        }

        public static Book Create(String id, String title, String author)
        {
            Book book = new Book()
            {
                Id = id,
                Title = title,
                Author = author,
                Price = 10000
            };
            return book;
        }
    }
}