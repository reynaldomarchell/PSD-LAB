using Session4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Session4.Factory
{
    public class TransactionFactory
    {
        public static Transaction Create(String id, String user_Id, String book_Id)
        {
            Transaction transaction = new Transaction()
            {
                Id = id,
                User_Id = user_Id,
                Book_Id = book_Id,
                TransactionDate = DateTime.Now
            };
            return transaction;
        }
    }
}