using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Sales_Database.Models
{
    internal class Products
    {
        [Key]
        public int ProductId { get; set; }
        [MaxLength(50)]
        public string? P_Name { get; set; }
        public double Quantity { get; set; }    
        public decimal Price { get; set; }
        [MaxLength(250)]
        public string? Description { get; set; } = "No Description";

        public ICollection<Sales> Sales { get; set; } = new List<Sales>();
            
    }
}
