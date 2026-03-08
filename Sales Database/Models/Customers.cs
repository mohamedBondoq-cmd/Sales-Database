using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Sales_Database.Models
{
    internal class Customers
    {
        [Key]
        public int CustomerId { get; set; }
        [MaxLength(100)]
        public string? C_Name { get; set; }
        [MaxLength(80)]
        [Unicode(false)]
        public string? Email { get; set; }
        
        public string? CraditCardNumber { get; set; }
        public ICollection<Sales> Sales { get; set; } = new List<Sales>();

    }
}
