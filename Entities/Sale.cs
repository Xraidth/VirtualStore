using System;
using System.Collections.Generic;

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

        
        public Sale(User usu, decimal total)
        {
            User = usu;
            Total = total;
            SaleDay = DateTime.Now;
            UserId = usu.UserId;
            SalesLines = new HashSet<SalesLine>();

        }
    }
}
