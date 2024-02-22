using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataHandle.Reports
{
    public class TotalSale
    {
        public int SaleId { get; set; }
        public DateTime SaleDate { get; set; }
        
        public decimal Total { get; set; }


        public TotalSale(int saleId, DateTime saleDate, decimal total) {
                SaleId = saleId;
                SaleDate = saleDate;
                Total = total;
        }
        
    }
}
