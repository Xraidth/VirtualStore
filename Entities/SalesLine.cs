using GR.ToGrid;
using System;
using System.Collections.Generic;


namespace EF.Models
{
    public partial class SalesLine
    {
        public int LineId { get; set; }
        public int SaleId { get; set; }
        public int ProductId { get; set; }
        public decimal SubTotal { get; set; }
        public int Amount { get; set; }
        public virtual Product Product { get; set; } = null!;
        public virtual Sale Sale { get; set; } = null!;

        public SalesLine(Sale sale, Product pro, int amount, int saleLine_id)
        {
            LineId = saleLine_id;
            SaleId = sale.SaleId;
            ProductId = pro.ProductId;
            Amount = amount;
            SubTotal = Math.Truncate(Convert.ToDecimal(pro.ProductPrice * amount) * 1000) / 1000;
            Sale = sale;
            Product = pro;


        }

        public void setSubTotal(Product pro, int amount)
        {
            SubTotal = Math.Truncate(Convert.ToDecimal(pro.ProductPrice * amount) * 1000) / 1000;
        }
        public SalesLine() { }
        public SalesLineGrid ToSalesLineGrid()
        {
            return new SalesLineGrid(LineId, SaleId, SubTotal, Amount, ProductId);
        }

      
    }
}
