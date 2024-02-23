﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataHandle.Reports
{
    public class TotalMonth
    {
        public int TotalMonthId { get; set; }

        public int Year { get; set; }

        public int Month { get; set; }

        public string MonthName { get; set; }
        public decimal Total { get; set; }

        public TotalMonth(int year, int month, string month_name)
        {
            Year = year;
            Month = month;
            MonthName = month_name;
            
        }
    }
}
