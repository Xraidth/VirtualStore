using DataHandle.Reports;
using DB.Reports;
using EF.Models;
using Syncfusion.Windows.Forms.Chart;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopUI.Reports
{
    public partial class formCharts : Form
    {
        private Type? tipoDato;
        public formCharts(Type tipo_dato)
        {
            InitializeComponent();
            tipoDato = tipo_dato;
            this.KeyPreview = true;
        }

        private void formCharts_Load(object sender, EventArgs e)
        {

            if (tipoDato == typeof(StockPorce))
            {
                chcChartControl.Text = "StockPorce";
                chcChartControl.Series.Add(new ChartSeries() { Type = ChartSeriesType.Pie });

                foreach (var item in Porcentage.CalculatePorceStock())
                {
                    chcChartControl.Series[0].Points.Add(item.ProductName, Convert.ToDouble(item.Porcentage.Replace("%", "")));

                }
            }
            else if (tipoDato == typeof(ProductSalePorce))
            {
                chcChartControl.Text = "ProductSalePorce";
                chcChartControl.Series.Add(new ChartSeries() { Type = ChartSeriesType.Pie });

                foreach (var item in Porcentage.CalculatePorceProductSales())
                {
                    chcChartControl.Series[0].Points.Add(item.ProductName, Convert.ToDouble(item.Porcentage.Replace("%", "")));

                }
            }
            else if (tipoDato == typeof(TotalSale))
            {

                chcChartControl.Text = "TotalSale";


                ChartSeries barSeries = new ChartSeries();

                barSeries.Type = ChartSeriesType.Column;

                chcChartControl.PrimaryXAxis.ValueType = ChartValueType.DateTime;
                chcChartControl.PrimaryYAxis.ValueType = ChartValueType.Double;


                chcChartControl.PrimaryXAxis.LabelRotate = true;


                var totalSales = Totals.CalculateTotalSale();



                foreach (var sale in totalSales)
                {
                    double total = Convert.ToDouble(sale.Total);



                    barSeries.Points.Add(sale.SaleDate.Date, total);

                }


                chcChartControl.Series.Add(barSeries);


                chcChartControl.PrimaryXAxis.Title = "Date";
                chcChartControl.PrimaryYAxis.Title = "Total";

                chcChartControl.PrimaryXAxis.DateTimeFormat = "dd/MM/yyyy";








            }




        }

        private void formCharts_KeyDown(object sender, KeyEventArgs e)
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
