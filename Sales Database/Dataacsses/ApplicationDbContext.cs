using Microsoft.EntityFrameworkCore;
using Sales_Database.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sales_Database.Dataacsses
{
    internal class ApplicationDbContext :DbContext
    {
        public DbSet<Sales> Sales { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<Products>  Products  { get; set; }
        public DbSet<Stores> Stores  { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=.;initial catalog=SalesData ;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False;Command Timeout=30");

        }

    }
}
