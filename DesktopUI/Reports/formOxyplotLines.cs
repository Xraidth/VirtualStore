using DB.Reports;
using OxyPlot.Axes;
using OxyPlot.Series;
using OxyPlot;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataHandle.Reports;
using System.Globalization;

namespace DesktopUI.Reports
{
    public partial class formOxyplotLines : Form
    {
        private Type? tipoDato;
        public formOxyplotLines(Type tipo_dato)
        {
            InitializeComponent();
            this.KeyPreview = true;
            tipoDato = tipo_dato;

        }

        private void formOxyplotLines_Load(object sender, EventArgs e)
        {
            if (tipoDato == typeof(TotalSale))
            {
                var model = new PlotModel { Title = "TotalSale" };

                var sale_totals = Totals.CalculateTotalSale();



                var points = sale_totals.Select(s => new DataPoint(DateTimeAxis.ToDouble(s.SaleDate.Date), Convert.ToDouble(s.Total)));

                var lineSeries = new LineSeries
                {
                    ItemsSource = points,
                    LabelFormatString = "{1}",
                    Color = OxyColor.FromRgb(255, 0, 0)
                };

                model.Series.Add(lineSeries);

                model.Axes.Add(new DateTimeAxis
                {
                    Position = AxisPosition.Bottom,
                    Title = "Date",
                    StringFormat = "dd/MM/yyyy",
                    IntervalType = DateTimeIntervalType.Days,
                    MinorIntervalType = DateTimeIntervalType.Days,
                    MinorStep = 1,
                    MajorStep = 1
                });

                plotView1.Model = model;
            }
            else if (tipoDato == typeof(TotalMonth))
            {
                var model = new PlotModel { Title = "TotalMonth" };

                var sale_totals = Totals.CalculateTotalMonth();
                var points = sale_totals.Select(s =>
                {
                    DateTime firstDayOfMonth = new DateTime(s.Year, s.Month, 1);
                    return new DataPoint(DateTimeAxis.ToDouble(firstDayOfMonth), Convert.ToDouble(s.Total));
                });

                var lineSeries = new LineSeries
                {
                    ItemsSource = points,
                    LabelFormatString = "{1}",
                    Color = OxyColor.FromRgb(255, 0, 0)
                };

                model.Series.Add(lineSeries);

                model.Axes.Add(new DateTimeAxis
                {
                    Position = AxisPosition.Bottom,
                    Title = "Month",
                    StringFormat = "MMMM yyyy",
                    IntervalLength = 50,
                    MinorIntervalType = DateTimeIntervalType.Months,
                    IntervalType = DateTimeIntervalType.Months
                });

                plotView1.Model = model;
            }
            else if (tipoDato == typeof(TotalYear))
            {
                var model = new PlotModel { Title = "TotalYear" };

                var sale_totals = Totals.CalculateTotalYear();
                var points = sale_totals.Select(s =>
                {
                    DateTime firstDayOfYear = new DateTime(s.Year, 1, 1);
                    return new DataPoint(DateTimeAxis.ToDouble(firstDayOfYear), Convert.ToDouble(s.Total));
                });

                var lineSeries = new LineSeries
                {
                    ItemsSource = points,
                    LabelFormatString = "{1}",
                    Color = OxyColor.FromRgb(255, 0, 0)
                };

                model.Series.Add(lineSeries);

                model.Axes.Add(new DateTimeAxis
                {
                    Position = AxisPosition.Bottom,
                    Title = "Years",
                    StringFormat = "yyyy",
                    IntervalLength = 50,
                    MinorIntervalType = DateTimeIntervalType.Years,
                    IntervalType = DateTimeIntervalType.Years
                });

                plotView1.Model = model;
            }
        }

        private void formOxyplotLines_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.D0:
                case Keys.NumPad0:
                    this.Close();
                    break;
                case Keys.Escape:
                    this.Close();
                    break;

            }
        }
    }
}
