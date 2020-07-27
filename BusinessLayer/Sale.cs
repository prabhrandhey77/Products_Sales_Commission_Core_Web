using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Products_Sales_Commission_Core_Web.BusinessLayer
{
    //Sales including the quqntity and the total commsion 
    public class Sale
    {
        public int Id { get; set; }

        public int SalesAgentId { get; set; }

        public SalesAgent SalesAgent { get; set; }

        public int ProductId { get; set; }

        public Product Product { get; set; }

        public int Quantity { get; set; }

        
        [NotMapped]
        public decimal  TotalSalesCommision { get {

                return (this.Product.SalesCommission / 100) * this.Product.Price * this.Quantity;
            
            } }


    }
}
