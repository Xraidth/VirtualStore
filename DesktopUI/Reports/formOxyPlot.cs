
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using OxyPlot.Axes;
using OxyPlot;
using OxyPlot.WindowsForms;
using OxyPlot.Series;
using OxyPlot.Legends;
using DB.Reports;
using DataHandle.Reports;

namespace DesktopUI.Reports
{
    public partial class formOxyPlot : Form
    {
        private Type? tipoDato;
        public formOxyPlot(Type tipo_dato)
        {
            InitializeComponent();
            tipoDato = tipo_dato;
        }

        private void formOxyPlot_Load(object sender, EventArgs e)
        {

            if(tipoDato == typeof(StockPorce)) { 
            var model = new PlotModel { Title = "StockPorce" };

            var stock_today = Porcentage.CalculatePorceStock();

            var baritemlist = new List<BarItem>();


            foreach (var st in stock_today)
            {
                var bi = new BarItem { Value = (Double.Parse(st.Porcentage.Replace("%", ""))) };
                baritemlist.Add(bi);
            }
            var barSeries = new BarSeries
            {
                ItemsSource = baritemlist,
                LabelPlacement = LabelPlacement.Inside,
                LabelFormatString = "{0:.00}%"
            };
            model.Series.Add(barSeries);
            List<String> barNamelist = stock_today.Select(x => x.ProductName).ToList();
                model.Axes.Add(new CategoryAxis
            {
                Position = AxisPosition.Left,
                Key = "Product",
                ItemsSource = barNamelist});
            plotView1.Model = model;
            }
            else if (tipoDato == typeof(ProductSalePorce))
            {
                var productSalePorces = Porcentage.CalculatePorceProductSales(); 

                var model = new PlotModel { Title = "ProductSalePorce" };

                dynamic series = new PieSeries { StrokeThickness = 2.0, InsideLabelPosition = 0.8, AngleSpan = 360, StartAngle = 0 };


                foreach (var psp in productSalePorces)
                {
                    series.Slices.Add(new PieSlice(psp.ProductName, Double.Parse(psp.Porcentage.Replace("%", ""))){ IsExploded = true });
                }

                model.Series.Add(series);
                plotView1.Model = model;

            }
            else if (tipoDato == typeof(TotalSale))
            {
                var model = new PlotModel { Title = "TotalSale" };

                var sale_totals = Totals.CalculateTotalSale();

                var baritemlist = new List<BarItem>();


                foreach (var st in sale_totals)
                {
                    var bi = new BarItem { Value = (Convert.ToDouble(st.Total)) };
                    baritemlist.Add(bi);
                }
                var barSeries = new BarSeries
                {
                    ItemsSource = baritemlist,
                    LabelPlacement = LabelPlacement.Inside,
                    LabelFormatString = "{0:,.00}"
                };
                model.Series.Add(barSeries);
                List<String> barNamelist = sale_totals.Select(x => x.SaleDate.ToString("dd/MM/yyyy")).ToList();
                model.Axes.Add(new CategoryAxis
                {
                    Position = AxisPosition.Left,
                    Key = "Date",
                    ItemsSource = barNamelist
                });
                plotView1.Model = model;
            }
            else if (tipoDato == typeof(TotalMonth))
            {
                var model = new PlotModel { Title = "TotalMonth" };

                var sale_totals = Totals.CalculateTotalMonth();

                var baritemlist = new List<BarItem>();


                foreach (var st in sale_totals)
                {
                    var bi = new BarItem { Value = (Convert.ToDouble(st.Total)) };
                    baritemlist.Add(bi);
                }
                var barSeries = new BarSeries
                {
                    ItemsSource = baritemlist,
                    LabelPlacement = LabelPlacement.Inside,
                    LabelFormatString = "{0:,.00}"
                };
                model.Series.Add(barSeries);
                List<String> barNamelist = sale_totals.Select(x => $"{x.MonthName} {x.Year}").ToList();
                model.Axes.Add(new CategoryAxis
                {
                    Position = AxisPosition.Left,
                    Key = "Month",
                    ItemsSource = barNamelist
                });
                plotView1.Model = model;
            }
            else if (tipoDato == typeof(TotalYear))
            {
                var model = new PlotModel { Title = "TotalYear" };

                var sale_totals = Totals.CalculateTotalYear();

                var baritemlist = new List<BarItem>();


                foreach (var st in sale_totals)
                {
                    var bi = new BarItem { Value = (Convert.ToDouble(st.Total)) };
                    baritemlist.Add(bi);
                }
                var barSeries = new BarSeries
                {
                    ItemsSource = baritemlist,
                    LabelPlacement = LabelPlacement.Inside,
                    LabelFormatString = "{0:,.00}"
                };
                model.Series.Add(barSeries);
                List<String> barNamelist = sale_totals.Select(x => $"{x.Year}").ToList();
                model.Axes.Add(new CategoryAxis
                {
                    Position = AxisPosition.Left,
                    Key = "Year",
                    ItemsSource = barNamelist
                });
                plotView1.Model = model;
            }
        }
    }
}
