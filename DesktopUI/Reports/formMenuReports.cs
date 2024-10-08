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
            this.KeyPreview = true;
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

        private void btnSalesPerMonth_Click(object sender, EventArgs e)
        {
            formListar formListar = new formListar(typeof(TotalMonth));
            formListar.Show();
        }

        private void btnSalesPerYear_Click(object sender, EventArgs e)
        {
            formListar formListar = new formListar(typeof(TotalYear));
            formListar.Show();
        }

        private void btnSalesOfWeek_Click(object sender, EventArgs e)
        {
            formListar formListar = new formListar(typeof(TotalWeek));
            formListar.Show();
        }



        private void formMenuReports_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.D0:
                case Keys.NumPad0:
                    this.Close();
                    break;
                case Keys.D1:
                case Keys.NumPad1:
                    btnStockPorce.PerformClick();
                    break;
                case Keys.D2:
                case Keys.NumPad2:
                    btnSalePerDay.PerformClick();
                    break;
                case Keys.D3:
                case Keys.NumPad3:
                    btnSalesProductPorce.PerformClick();
                    break;
                case Keys.D4:
                case Keys.NumPad4:
                    btnSalesPerMonth.PerformClick();
                    break;
                case Keys.D6:
                case Keys.NumPad6:
                    btnSalesPerYear.PerformClick();
                    break;
                case Keys.Escape:
                    this.Close();
                    break;

            }
        }

       
    }
}
