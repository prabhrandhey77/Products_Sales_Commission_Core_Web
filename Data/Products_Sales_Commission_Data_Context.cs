using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Products_Sales_Commission_Core_Web.BusinessLayer;

namespace Products_Sales_Commission_Core_Web.Models
{
    public class Products_Sales_Commission_Data_Context : DbContext
    {
        public Products_Sales_Commission_Data_Context (DbContextOptions<Products_Sales_Commission_Data_Context> options)
            : base(options)
        {
        }

        public DbSet<Products_Sales_Commission_Core_Web.BusinessLayer.Manufacturer> Manufacturer { get; set; }

        public DbSet<Products_Sales_Commission_Core_Web.BusinessLayer.Product> Product { get; set; }

        public DbSet<Products_Sales_Commission_Core_Web.BusinessLayer.Sale> Sale { get; set; }

        public DbSet<Products_Sales_Commission_Core_Web.BusinessLayer.SalesAgent> SalesAgent { get; set; }
    }
}
