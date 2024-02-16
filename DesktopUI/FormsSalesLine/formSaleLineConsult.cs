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

namespace DesktopUI.FormsSalesLine
{
    public partial class formSaleLineConsult : Form
    {
        public SalesLine sale_line;
        public formSaleLineConsult(SalesLine sale_show)
        {
            InitializeComponent();
            sale_line = sale_show;
        }


        private void formSaleLineConsult_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            LoadShowSaleLine();
        }


        public void LoadShowSaleLine()
        {
            var product = DataProduct.GetOne(sale_line.ProductId);
            lblProductName.Text = product.ProductName;
            lblProductId.Text = sale_line.ProductId.ToString();
            lblProductAmount.Text = sale_line.Amount.ToString();
        }

        private void formSaleLineConsult_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    this.Close();
                    break;

            }
        }
    }
}
