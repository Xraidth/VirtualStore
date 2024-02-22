using DataHandle.Reports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB.Reports
{
    public class Totals
    {
        public static List<TotalSale> CalculateTotalSale()
        {
            var sales = DataSale.GetAll();


            List<TotalSale> sale_totals = new List<TotalSale>();


            var salesPerDay = from s in sales
                              group s by s.SaleDay into salesGroup
                              select new
                              {
                                  SaleDay = salesGroup.Key,
                                  Total = salesGroup.Sum(s => s.Total)
                              };



            foreach (var (s, indice) in salesPerDay.Select((value, index) => (value, index)))
            {
                
                var cal_ts = Math.Truncate(Convert.ToDecimal(s.Total) * 1000) / 1000;
                var ts = new TotalSale(indice, s.SaleDay, cal_ts);
                sale_totals.Add(ts);
            }

            return sale_totals;
        }
    }
}
