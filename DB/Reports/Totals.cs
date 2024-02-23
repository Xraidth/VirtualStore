using DataHandle.Reports;

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



            foreach (var s in salesPerDay)
            {

                var cal_ts = Math.Truncate(Convert.ToDecimal(s.Total) * 1000) / 1000;
                var ts = new TotalSale(s.SaleDay, cal_ts);
                sale_totals.Add(ts);
            }





            int saleId = 1;
            foreach (var item in sale_totals)
            {
                item.SaleId = saleId;
                saleId++;
            }



            return sale_totals;
        }

        public static List<TotalMonth> CalculateTotalMonth()
        {
            List<TotalMonth> sale_totals = new List<TotalMonth>();

            var salesPerDay = CalculateTotalSale();

            var maxSaleday = salesPerDay.Max(x => x.SaleDate.Date);
            var minSaleday = salesPerDay.Min(x => x.SaleDate.Date);

            for (DateTime date = minSaleday; date <= maxSaleday; date = date.AddMonths(1))
            {
                int year = date.Date.Year;
                int month = date.Date.Month;
                string month_name = date.Date.ToString("MMMM");
                var tm = new TotalMonth(year, month, month_name);
                sale_totals.Add(tm);
            }


            int Id = 1;
            foreach (var st in sale_totals)
            {
                st.Total = salesPerDay.Where(x => x.SaleDate.Date.Month == st.Month && x.SaleDate.Date.Year == st.Year)
                    .ToList()
                    .Sum(x => x.Total);
                st.TotalMonthId = Id;
             Id++;
            }

            return sale_totals;

        }
        public static List<TotalYear> CalculateTotalYear()
        {
            List<TotalYear> sale_totals = new List<TotalYear>();
            var salePerMonth = CalculateTotalMonth();

            var years = salePerMonth.Select(x => x.Year).Distinct().ToList();

            int id = 1;
            foreach (var y in years)
            {
                var sy = new TotalYear(y);
                sy.TotalYearId = id;
                sy.Total = salePerMonth.Where(x => x.Year == y).ToList().Sum(yy => yy.Total);
                sale_totals.Add(sy);
                id++;
            }

            return sale_totals;
        }

    }
}
