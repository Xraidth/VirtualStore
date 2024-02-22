using System;
using System.Collections.Generic;

namespace EF.Models
{
    public partial class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; } = null!;

        public int ProductStock { get; set; }
        public decimal ProductPrice { get; set; }

        public Product()
        {
            
        }

        public Product(string product_name, int product_stock, decimal product_price)
        {
            
            ProductName = product_name;
            ProductStock = product_stock;
            ProductPrice = product_price;
        }


        public void setStock(int amount) {
            ProductStock = ProductStock - amount;
        }

        public int getStock()
        {
            return ProductStock;
        }

    }

   

}
