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
        public string UserName { get; set; } = null!;
        public decimal Total { get; set; }

        public virtual ICollection<SalesLine> SalesLines { get; set; }
    }
}
