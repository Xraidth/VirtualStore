using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopUI.FormsProduct
{
    public partial class formProductConsult : Form
    {
        public EF.Models.Product? ProductConsult { get; set; }
        public formProductConsult(EF.Models.Product product_consult)
        {
            InitializeComponent();
            ProductConsult = product_consult;
        }

        private void formProductConsult_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            lblID.Text = Convert.ToString(ProductConsult.ProductId);
            lblName.Text = ProductConsult.ProductName;
            lblStock.Text = Convert.ToString(ProductConsult.ProductStock); ;
            lblPrice.Text = Convert.ToString(ProductConsult.ProductPrice);
        }

        private void formProductConsult_KeyDown(object sender, KeyEventArgs e)
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
