using System;
using System.Collections.Generic;
using DB.ToGrid;

namespace DB.Models
{
    public partial class Sale
    {
        public Sale()
        {
           SalesLines = new HashSet<SalesLine>();
        }

        public int SaleId { get; set; }
        public int UserId  { get; set; } 
        public decimal Total { get; set; }
        public DateTime SaleDay { get; set; }
        public virtual ICollection<SalesLine>? SalesLines { get; set; }
        public virtual User User { get; set; } = null!;

        
        public Sale(User usu)
        {
            User = usu;
            Total = 0;
            SaleDay = DateTime.Now;
            UserId = usu.UserId;
            SalesLines = new HashSet<SalesLine>();

        }
        public void setTotal(decimal st) {
            Total = Math.Truncate(Convert.ToDecimal(Total + st) * 1000) / 1000;
        }

        public SaleGrid ToSaleGrid()
        {
           return new SaleGrid(SaleId, SaleDay, User.UserName, Total);
        }

    }
}
