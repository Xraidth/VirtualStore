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
namespace DesktopUI.Product
{
    public delegate void ListarEventHandler(object sender, EventArgs e);


    public partial class formProductAdd : Form
    {
        private EF.Models.Product? productUp;


        public formProductAdd()
        {
            InitializeComponent();
        }

        public formProductAdd(EF.Models.Product product_up)
        {
            InitializeComponent();
            productUp = product_up;
            setCargaUpdate();
        }

        private void setCargaUpdate()
        {
            if (productUp != null)
            {
                btnAdd.Text = "Update";
                txtName.Text = productUp.ProductName;
                nudStock.Value = productUp.ProductStock;
                nudPrice.Value = productUp.ProductPrice;
            }
            else { MessageBox.Show("Error de intento de actualizacion"); }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public event ListarEventHandler ListarClicked;

        private void btnAdd_Click(object sender, EventArgs e)
        {


            if (txtName.Text != "" && txtName.Text != null && nudStock.Value >= 0 && nudStock.Value >= 0)
            {
                string txt_name = Convert.ToString(txtName.Text);
                int num_stock = Convert.ToInt32(nudStock.Value);
                decimal num_price = Convert.ToDecimal(nudPrice.Value);

                if (btnAdd.Text.ToString().Contains("Add"))
                {
                    var new_product = new EF.Models.Product(txt_name, num_stock, num_price);
                    DataProduct.Insert(new_product);
                }
                else
                {

                    DataProduct.Update(productUp, txt_name, num_stock, num_price);
                }

                OnListarClicked(EventArgs.Empty);

            }
            else
            {
                MessageBox.Show("Datos incorrectos");
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

        private void formProductAdd_KeyDown(object sender, KeyEventArgs e)
        {
            if (!txtName.Focused && !nudStock.Focused && !nudPrice.Focused)
            {
                switch (e.KeyCode)
                {
                    case Keys.D0:
                    case Keys.NumPad0:
                        this.Close();
                        break;
                    case Keys.D1:
                    case Keys.NumPad1:
                        btnCancel.PerformClick();
                        break;
                    case Keys.D2:
                    case Keys.NumPad2:
                        btnAdd.PerformClick();
                        break;
                    case Keys.D3:
                    case Keys.NumPad3:
                        btnApply.PerformClick();
                        break;
                    case Keys.Escape:
                        this.Close();
                        break;

                }
            }
        }

        private void formProductAdd_Load(object sender, EventArgs e)
        {

            this.KeyPreview = true;
        }

        private void formProductAdd_Shown(object sender, EventArgs e)
        {
            txtName.Focus();
        }
    }
}
