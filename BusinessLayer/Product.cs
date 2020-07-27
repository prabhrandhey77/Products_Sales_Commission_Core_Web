using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Products_Sales_Commission_Core_Web.BusinessLayer
{
    //Product details including the commision and price
    public class Product
    {
        public int Id { get; set; }


        public int ManufacturerId { get; set; }

        public Manufacturer Manufacturer { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public decimal SalesCommission { get; set; }

    }
}
