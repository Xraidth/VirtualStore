using System;
using System.Collections.Generic;

namespace DB.Models
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
    }
}
