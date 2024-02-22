﻿using DataHandle.Reports;
using Escritorio.Generalizado;
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
    public partial class formMenuReports : Form
    {
        public formMenuReports()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalePerDay_Click(object sender, EventArgs e)
        {
            formListar formListar = new formListar(typeof(TotalSale));
            formListar.Show();
        }

        private void btnStockPorce_Click(object sender, EventArgs e)
        {
            formListar formListar = new formListar(typeof(StockPorce));
            formListar.Show();
        }

        private void btnSalesProductPorce_Click(object sender, EventArgs e)
        {
            formListar formListar = new formListar(typeof(ProductSalePorce));
            formListar.Show();
        }
    }
}
