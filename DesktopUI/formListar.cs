using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using DB.Models;
using DB;
using DB.ToGrid;
using DesktopUI.Product;
using DesktopUI.FormsProduct;
using DesktopUI.FormsUser;
using DesktopUI.FormsSalesLine;

namespace Escritorio.Generalizado
{
    public partial class formListar : Form
    {
        private Type? tipoDato;
        private List<Object> ListaGeneral = new List<Object>();
        private Sale? saleAdder;
        private User? UserLogued;
        public formListar(Type tipo_dato)
        {
            InitializeComponent();
            tipoDato = tipo_dato;
        }

        public formListar(Type tipo_dato, User user_logued)
        {
            InitializeComponent();
            tipoDato = tipo_dato;
            UserLogued = user_logued;
        }

        public formListar(Type tipo_dato, Sale sale_adder_lt)
        {
            InitializeComponent();
            saleAdder = sale_adder_lt;
            tipoDato = tipo_dato;
        }


        private void formListar_Load(object sender, EventArgs e)
        {
            CargarNombreDeVentana();
            CargarDGV();
            ActualizarGrilla();
        }

        private void ActualizarGrilla()
        {
            dgvGrilla.DataSource = null;
            dgvGrilla.Refresh();
            dgvGrilla.DataSource = ListaGeneral[0];
        }

        private void CargarNombreDeVentana()
        {
            string nom_clase = "";
            if (tipoDato == typeof(Product))
            {
                nom_clase = "Products";
            }
            else if (tipoDato == typeof(Sale))
            {
                nom_clase = "Sales";
            }
            else if (tipoDato == typeof(SalesLine))
            {
                nom_clase = "SalesLines";
            }
            else if (tipoDato == typeof(User))
            {
                nom_clase = "Users";
            }

            this.Text = $"List-{nom_clase}";
            lblClase.Text = nom_clase;
        }
        private void CargarDGV()
        {
            if (ListaGeneral.Count != 0) { ListaGeneral.Clear(); }

            if (tipoDato == typeof(Product))
            {
                ListaGeneral.Add(DataProduct.GetAll());
            }
            else if (tipoDato == typeof(Sale))
            {
                List<Sale> sales = DataSale.GetAll();
                var salesGrid = sales.Select(s => s.ToSaleGrid()).ToList();
                ListaGeneral.Add(salesGrid);
            }
            else if (tipoDato == typeof(SalesLine))
            {
                List<SalesLine> sales_lines = (saleAdder != null) ? DataSalesLines.saleslineSearcher(Convert.ToInt32(saleAdder.SaleId)) : DataSalesLines.GetAll();
                var sales_linesGrid = sales_lines.Select(s => s.ToSalesLineGrid()).ToList();
                ListaGeneral.Add(sales_linesGrid);
            }
            else if (tipoDato == typeof(User))
            {
                ListaGeneral.Add(DataUser.GetAll());
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            string consulta = txtConsulta.Text;

            if (consulta == "")
            {
                btnListar_Click(sender, e);
            }

            if (ListaGeneral.Count != 0) { ListaGeneral.Clear(); }

            if (tipoDato == typeof(Product))
            {
                List<Product> products = DataProduct.GetAll();
                ListaGeneral.Add(products.Where(x => x.ProductId.ToString().Contains(consulta) || x.ProductName.ToString().Contains(consulta)).ToList());
            }
            else if (tipoDato == typeof(Sale))
            {
                List<Sale> sales = DataSale.GetAll();
                var salesGrid = sales.Select(s => s.ToSaleGrid()).ToList();
                ListaGeneral.Add(salesGrid.Where(x => x.SaleId.ToString().Contains(consulta) || x.SaleDay.ToString().Contains(consulta)).ToList());
            }
            else if (tipoDato == typeof(SalesLine))
            {
                List<SalesLine> sales_lines = (saleAdder.SaleId != null) ? DataSalesLines.saleslineSearcher(Convert.ToInt32(saleAdder.SaleId)) : DataSalesLines.GetAll();
                var sales_linesGrid = sales_lines.Select(s => s.ToSalesLineGrid()).ToList();
                ListaGeneral.Add(sales_linesGrid.Where(x => x.SaleId.ToString().Contains(consulta)).ToList());
            }
            else if (tipoDato == typeof(User))
            {
                List<User> users = DataUser.GetAll();
                ListaGeneral.Add(users.Where(x => x.UserId.ToString().Contains(consulta) || x.UserName.Contains(consulta)).ToList());
            }
            else { }
            ActualizarGrilla();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {

            CargarDGV();
            ActualizarGrilla();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
              if (tipoDato == typeof(Product))
              {
                  formProductAdd formProductAdd = new formProductAdd();
                formProductAdd.Show();
                formProductAdd.ListarClicked += (s, args) => btnListar_Click(sender, e);
            }
            else if (tipoDato == typeof(User))
              {
                  formUserAdd formUserAdd = new formUserAdd();
                  formUserAdd.Show();
                formUserAdd.ListarClicked += (s, args) => btnListar_Click(sender, e);


            }
            else if (tipoDato == typeof(Sale))
           {
                var new_sale = new Sale(UserLogued);
                DataSale.Insert(new_sale);
                var saleyetadder = DataSale.GetOne(new_sale.SaleId);
                formListar formListar = new formListar(typeof(SalesLine),saleyetadder);
                formListar.Show();
                formListar.FormClosed += (s, args) => btnListar_Click(sender, e);
            }
            else if (tipoDato == typeof(SalesLine))
             {
                 formSaleLineAdd formSaleLineAdd = new formSaleLineAdd(saleAdder);
                formSaleLineAdd.Show();
                formSaleLineAdd.ListarClicked += (s, args) => btnListar_Click(sender, e);

            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvGrilla.SelectedRows.Count == 0) { MessageBox.Show("Debe seleccionar algo para ser borrado"); return; }
            DialogResult conf = MessageBox.Show("¿Estas seguro que deseas eliminar?", "Confirmar Eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (conf == DialogResult.Yes)
            {
                int filaSeleccionada = dgvGrilla.SelectedRows[0].Index;
                 if (tipoDato == typeof(Product))
                 {
                     List<Product> lpc = (List<Product>)ListaGeneral[0];
                     DataProduct.DeleteOne(lpc[filaSeleccionada]);
                 }
                 else if (tipoDato == typeof(User))
                 {
                     List<User> lpc = (List<User>)ListaGeneral[0];
                     DataUser.DeleteOne(lpc[filaSeleccionada]);
                 }
                 else if (tipoDato == typeof(Sale))
                 {
                    List<SaleGrid> lpc = (List<SaleGrid>)ListaGeneral[0];
                    var sale_to_delete = DataSale.GetOne(lpc[filaSeleccionada].SaleId);

                    DataSale.DeleteOne(sale_to_delete);

                }
                 else if (tipoDato == typeof(SalesLine))
                 {
                     List<SalesLineGrid> lpc  =  (List<SalesLineGrid>)ListaGeneral[0];
                     var sale_to_delete = DataSalesLines.GetOne(saleAdder, lpc[filaSeleccionada].LineId);
                     DataSalesLines.DeleteOne(sale_to_delete);                
                 }
                btnListar_Click(sender, e);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvGrilla.SelectedRows.Count == 0) { MessageBox.Show("Debe seleccionar algo para ser Modificado"); return; }

            int filaSeleccionada = dgvGrilla.SelectedRows[0].Index;
             if (tipoDato == typeof(Product))
             {
                 List<Product> lpc = (List<Product>)ListaGeneral[0];
                 formProductAdd formProductAdd = new formProductAdd(lpc[filaSeleccionada]);
                 formProductAdd.Show();
                 formProductAdd.ListarClicked += (s, args) => btnListar_Click(sender, e);
            }
             else if (tipoDato == typeof(User))
             {
                 List<User> lpc = (List<User>)ListaGeneral[0];
                 formUserAdd formUserAdd = new formUserAdd(lpc[filaSeleccionada]);
                 formUserAdd.Show();
                 formUserAdd.ListarClicked += (s, args) => btnListar_Click(sender, e);

            }
             else if (tipoDato == typeof(Sale))
             {
                 List<SaleGrid> lpc = (List<SaleGrid>)ListaGeneral[0];
                var sale_to_update = DataSale.GetOne(lpc[filaSeleccionada].SaleId);
                     formListar formListar = new formListar(typeof(SalesLine), sale_to_update);
                     formListar.Show();

             }
             else if (tipoDato == typeof(SalesLine))
             {
                List<SalesLineGrid> lpc = (List<SalesLineGrid>)ListaGeneral[0];
                var sale_to_update = DataSalesLines.GetOne(saleAdder, lpc[filaSeleccionada].LineId);
                formSaleLineAdd formSaleLineAdd = new formSaleLineAdd(saleAdder);
                formSaleLineAdd.Show();
             }
        }
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (dgvGrilla.SelectedRows.Count == 0) { MessageBox.Show("Debe seleccionar algo para ser consultado"); return; }

            int filaSeleccionada = dgvGrilla.SelectedRows[0].Index;

              if (tipoDato == typeof(Product))
              {
                  List<Product> lpc = (List<Product>)ListaGeneral[0];
                  formProductConsult formProductConsult = new formProductConsult(lpc[filaSeleccionada]);
                  formProductConsult.Show();
                  


              }
              else if (tipoDato == typeof(User))
              {
                  List<User> lpc = (List<User>)ListaGeneral[0];
                  formUserConsult formUserConsult = new formUserConsult(lpc[filaSeleccionada]);
                  formUserConsult.Show();
                  
              }
        }
    }
}

