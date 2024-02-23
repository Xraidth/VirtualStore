using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataHandle.Reports
{
    public class TotalYear
    {
        public int TotalYearId { get; set; }

        public int Year { get; set; }

        public decimal Total { get; set; }

        public TotalYear( int year) {
            Year = year;
        }
    }
}
