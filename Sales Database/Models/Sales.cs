using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Sales_Database.Models
{
    internal class Sales
    {
        [Key]
        public int SaleId {  get; set; } 
        public DateTime Date {  get; set; }
        public int CustomerId { get; set; }
        public Customers? Customers { get; set; }
        public int ProductId { get; set; }
        public Products? products { get; set; }
        public int StoreId { get; set; }
        public Stores? stores { get; set; }




    }
}
