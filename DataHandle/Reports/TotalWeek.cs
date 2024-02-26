using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataHandle.Reports
{
    public class TotalWeek
    {
        public int WeekDayId { get; set; }
        public string WeekDay { get; set; }
        public decimal Total { get; set; }


        public TotalWeek(int id, DateTime saleDate, decimal total)
        {
            WeekDayId = id;
            WeekDay = saleDate.ToString("dddd", CultureInfo.InvariantCulture);
            Total = total;
        }

        public static List<DateTime> GetDaysOfCurrentWeek()
        {
            List<DateTime> daysOfWeek = new List<DateTime>();
            DateTime currentDate = DateTime.Today;
            int delta = DayOfWeek.Monday - currentDate.DayOfWeek;
            DateTime monday = currentDate.AddDays(delta);
            for (int i = 0; i < 7; i++)
            {
                daysOfWeek.Add(monday.AddDays(i));
            }
            return daysOfWeek;
        }
        public static DateTime GenerateDay(string week_day)
        {
            var daysofcurrentweek = GetDaysOfCurrentWeek();

            return daysofcurrentweek.FirstOrDefault(x=> x.ToString("dddd", CultureInfo.InvariantCulture) == week_day);
        }


    }
}
