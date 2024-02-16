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
using DB.Models;

namespace DesktopUI.FormsSalesLine
{
    public delegate void ListarEventHandler(object sender, EventArgs e);
    public partial class formSaleLineAdd : Form
    {
        private DB.Models.Product? product_adder;

        private List<DB.Models.Product> products;

        private SalesLine saleLine_updater;

        private Sale sale_adder;

        public formSaleLineAdd(Sale sale_add)
        {
            InitializeComponent();
            sale_adder = sale_add;
        }

        public formSaleLineAdd(Sale sale_add, SalesLine sale_line_up)
        {
            InitializeComponent();
            sale_adder = sale_add;
            saleLine_updater = sale_line_up;
            LoadUpdateSaleline();
        }

        private void LoadUpdateSaleline()
        {
            btnAdd.Text = "Update";
            cbxProductName.SelectedValue = saleLine_updater.Product.ProductId;
            txtProductID.Text = saleLine_updater.Product.ProductId.ToString();
            nudAmount.Value = Convert.ToDecimal(saleLine_updater.Amount);
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public event ListarEventHandler ListarClicked;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int amu = Convert.ToInt32(nudAmount.Value);
            if (product_adder != null || amu >= 0)
            {


                if (product_adder.ProductStock >= amu)
                {
                    if (btnAdd.Text.Contains("Add"))
                    {
                        int salelineLastId = DataSalesLines.saleslineSearcher(sale_adder.SaleId).Count; 
                        SalesLine new_sale_line = new SalesLine(sale_adder, product_adder, amu, salelineLastId+1);
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

        }

        private void formSaleLineAdd_Load(object sender, EventArgs e)
        {
            loadSelectProduct();
        }
        private void loadSelectProduct()
        {
            cbxProductName.DisplayMember = "ProductName";
            cbxProductName.ValueMember = "ProductId";
            cbxProductName.Enabled = true;
            cbxProductName.SelectedIndex = -1;
            products = DataProduct.GetAll();
            cbxProductName.DataSource = products;
        }

        private void cbxProductName_SelectedIndexChanged(object sender, EventArgs e)
        {
            var proID = Convert.ToInt32(cbxProductName.SelectedValue);

            product_adder = DataProduct.GetOne(proID);
        }

        private void txtProductID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(txtProductID.Text, out int filter))
                {
                    var filteredProducts = products.Where(pro => pro.ProductId == filter).ToList();
                    cbxProductName.DataSource = filteredProducts;
                    cbxProductName.DisplayMember = "ProductName";
                    cbxProductName.ValueMember = "ProductId";
                }
                else
                {
                    cbxProductName.DataSource = products;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }

        }

        public virtual void OnListarClicked(EventArgs e)
        {
            ListarClicked?.Invoke(this, e);
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            btnAdd.PerformClick();
            this.Close();
        }
    }
}
