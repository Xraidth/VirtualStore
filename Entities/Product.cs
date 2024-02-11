using System;
using System.Collections.Generic;

namespace DB.Models
{
    public partial class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; } = null!;
        public decimal ProductPrice { get; set; }

        public Product()
        {
            
        }

        public Product(string product_name, decimal product_price)
        {
            ProductName = product_name;
            ProductPrice = product_price;
        }
    }

   

}
