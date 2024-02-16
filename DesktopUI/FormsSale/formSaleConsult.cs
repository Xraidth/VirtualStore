using DB;
using DB.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopUI.FormsSale
{
    public partial class formSaleConsult : Form
    {
        public Sale sale_sale;
        public formSaleConsult(Sale sale_show)
        {
            InitializeComponent();
            sale_sale = sale_show;
            loadSaleShow();
        }
        public void loadSaleShow()
        {
            lblSaleId.Text = sale_sale.SaleId.ToString();
            lblSaleDay.Text = sale_sale.SaleDay.ToString();
            lblUserName.Text = DataUser.GetOne(sale_sale.UserId).UserName.ToString();
            lblTotal.Text = sale_sale.Total.ToString();
        }

        private void formSaleConsult_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    this.Close();
                    break;

            }
        }

        private void formSaleConsult_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }
    }
}
