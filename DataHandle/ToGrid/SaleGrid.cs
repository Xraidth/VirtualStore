using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB.ToGrid
{
    public class SaleGrid
    {
        public int SaleId { get; set; }
        public DateTime SaleDay { get; set; }
        public string UserName { get; set; }
        public decimal Total { get; set; }


        public SaleGrid(int sale_id, DateTime sale_day, string user_name, decimal total)
        {
            SaleId = sale_id;
            SaleDay = sale_day;
            UserName = user_name;
            Total = total;
        }
    }
    
}
