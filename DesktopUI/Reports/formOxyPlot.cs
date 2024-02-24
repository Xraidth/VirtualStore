
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
            /*
            var model = new PlotModel { Title = "Cake Type Popularity" };
            var rand = new Random();
            double[] cakePopularity = new double[5];
            for (int i = 0; i < 5; ++i)
            {
                cakePopularity[i] = rand.NextDouble();
            }
            var sum = cakePopularity.Sum();

            var barSeries = new BarSeries
            {
                ItemsSource = new List<BarItem>(new[]
                    {
                new BarItem{ Value = (cakePopularity[0] / sum * 100) },
                new BarItem{ Value = (cakePopularity[1] / sum * 100) },
                new BarItem{ Value = (cakePopularity[2] / sum * 100) },
                new BarItem{ Value = (cakePopularity[3] / sum * 100) },
                new BarItem{ Value = (cakePopularity[4] / sum * 100) }
        }),
                LabelPlacement = LabelPlacement.Inside,
                LabelFormatString = "{0:.00}%"
            };
            model.Series.Add(barSeries);

            model.Axes.Add(new CategoryAxis
            {
                Position = AxisPosition.Left,
                Key = "CakeAxis",
                ItemsSource = new[]
                    {
                "Apple cake",
                "Baumkuchen",
                "Bundt Cake",
                "Chocolate cake",
                "Carrot cake"
        }
            });
            plotView1.Model = model;
            */

            /* var modelP1 = new PlotModel { Title = "Pie Sample1" };

              dynamic seriesP1 = new PieSeries { StrokeThickness = 2.0, InsideLabelPosition = 0.8, AngleSpan = 360, StartAngle = 0 };

              seriesP1.Slices.Add(new PieSlice("Africa", 1030) { IsExploded = false, Fill = OxyColors.PaleVioletRed });
              seriesP1.Slices.Add(new PieSlice("Americas", 929) { IsExploded = true });
              seriesP1.Slices.Add(new PieSlice("Asia", 4157) { IsExploded = true });
              seriesP1.Slices.Add(new PieSlice("Europe", 739) { IsExploded = true });
              seriesP1.Slices.Add(new PieSlice("Oceania", 35) { IsExploded = true });

              modelP1.Series.Add(seriesP1);
              plotView1.Model = modelP1;*/








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
                Key = "CakeAxis",
                ItemsSource = barNamelist});
            plotView1.Model = model;
            }



        }
    }
}
