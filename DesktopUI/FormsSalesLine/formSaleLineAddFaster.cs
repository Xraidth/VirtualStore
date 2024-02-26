using DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EF.Models;

namespace DesktopUI.FormsSalesLine
{

    public partial class formSaleLineAddFaster : Form
    {

        private EF.Models.Product? product_adder;

        private List<EF.Models.Product> products;

        private SalesLine saleLine_updater;

        private Sale sale_adder;
        public formSaleLineAddFaster(Sale sale_add)
        {
            InitializeComponent();
            sale_adder = sale_add;
        }

        public formSaleLineAddFaster(Sale sale_add, SalesLine sale_line_up)
        {
            InitializeComponent();
            sale_adder = sale_add;
            saleLine_updater = sale_line_up;
            LoadUpdateSaleline();
        }

        private void LoadUpdateSaleline()
        {
            btnAdd.Text = "Update";
            txtProductID.Text = saleLine_updater.Product.ProductId.ToString();
            nudAmount.Value = Convert.ToDecimal(saleLine_updater.Amount);
        }

        public event ListarEventHandler ListarClicked;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtProductID.Text == ""|| nudAmount.Value <=0)
            {
                MessageBox.Show("Complete all the fields correctly");
            }
            

            int amu = Convert.ToInt32(nudAmount.Value);
            if (product_adder != null && amu >= 0)
            {


                if (product_adder.ProductStock >= amu)
                {
                    if (btnAdd.Text.Contains("Add"))
                    {
                        int salelineLastId = DataSalesLines.saleslineSearcher(sale_adder.SaleId).Count;
                        SalesLine new_sale_line = new SalesLine(sale_adder, product_adder, amu, salelineLastId + 1);
                        DataSalesLines.Insert(new_sale_line);
                    }
                    else
                    {
                        DataSalesLines.Update(sale_adder, saleLine_updater, product_adder, amu);
                    }
                }
                else
                {
                    MessageBox.Show("There is no stock");
                }




            }
            else { MessageBox.Show("Data Error"); }

            OnListarClicked(EventArgs.Empty);

            this.Close();
        }

        private void formSaleLineAddFaster_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;


        }

        public virtual void OnListarClicked(EventArgs e)
        {
            ListarClicked?.Invoke(this, e);
        }

        private void formSaleLineAddFaster_KeyDown(object sender, KeyEventArgs e)
        {
            if (!txtProductID.Focused && !nudAmount.Focused)
            {
                switch (e.KeyCode)
                {
                    case Keys.D0:
                    case Keys.NumPad0:
                        this.Close();
                        break;
                    case Keys.D1:
                    case Keys.NumPad1:
                        btnAdd.PerformClick();
                        break;
                    case Keys.Escape:
                        this.Close();
                        break;

                }

            }
        }

        private void txtProductID_TextChanged(object sender, EventArgs e)
        {
            if (txtProductID.Text != "")
            {
                int pa_id = Convert.ToInt32(txtProductID.Text);
                product_adder = DataProduct.GetOne(pa_id);
                lblProductName.Text = (product_adder != null) ? product_adder.ProductName : "No found";
                lblProductName.ForeColor = (product_adder != null) ? Color.Green : Color.Red;
            }
        }
    }
}
