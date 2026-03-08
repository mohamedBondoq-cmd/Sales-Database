using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Sales_Database.Models
{
    internal class Stores
    {
        [Key]
        public int StoreId { get; set; }
        [MaxLength(80)]
        public String? S_Name { get; set; }
        public ICollection<Sales> Sales { get; set; } = new List<Sales>();

    }
}
