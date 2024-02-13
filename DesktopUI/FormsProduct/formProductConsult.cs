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
        public DB.Models.Product? ProductConsult { get; set; }
        public formProductConsult(DB.Models.Product product_consult)
        {
            InitializeComponent();
            ProductConsult = product_consult;
        }

        private void formProductConsult_Load(object sender, EventArgs e)
        {
            lblID.Text = Convert.ToString(ProductConsult.ProductId);
            lblName.Text = ProductConsult.ProductName;
            lblStock.Text = Convert.ToString(ProductConsult.ProductStock); ;
            lblPrice.Text = Convert.ToString(ProductConsult.ProductPrice);
        }
    }
}
