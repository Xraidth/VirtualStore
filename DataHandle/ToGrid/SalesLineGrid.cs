using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace GR.ToGrid
{
    public class SalesLineGrid
    {
        public int LineId { get; set;}
        public int SaleId { get; set; }
        public decimal SubTotal { get; set; }

        public int Amount { get; set; }

        public int ProductId { get; set; }
        
        public string ProductName { get; set; }

        public SalesLineGrid(int line_id, int sale_id, decimal sub_total, int amount, int product_id)
        {
            LineId = line_id;
            SaleId = sale_id;
            SubTotal = sub_total;
            Amount = amount;
            ProductId = product_id;
        }
    }
}
