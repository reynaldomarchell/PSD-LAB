//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Session4.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Transaction
    {
        public string Id { get; set; }
        public string User_Id { get; set; }
        public string Book_Id { get; set; }
        public System.DateTime TransactionDate { get; set; }
    
        public virtual Book Book { get; set; }
        public virtual User User { get; set; }
    }
}