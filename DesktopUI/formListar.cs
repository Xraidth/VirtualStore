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

namespace Escritorio.Generalizado
{
    public partial class formListar : Form
    {
        private Type? tipoDato;
        private List<Object> ListaGeneral = new List<Object>();
        private int? IDsale;
        public formListar(Type tipo_dato)
        {
            InitializeComponent();
            tipoDato = tipo_dato;
        }

        public formListar(Type tipo_dato, int id_sale)
        {
            IDsale = id_sale;
            InitializeComponent();
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
                List<SalesLine> sales_lines = (IDsale != null) ? DataSalesLines.saleslineSearcher(Convert.ToInt32(IDsale)) : DataSalesLines.GetAll();
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
                List<SalesLine> sales_lines = (IDsale != null) ? DataSalesLines.saleslineSearcher(Convert.ToInt32(IDsale)) : DataSalesLines.GetAll();
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
            /*  else if (tipoDato == typeof(TPI.Entidades.Cursado))
              {
                  formAgregarCursado formAgregarCursado = new formAgregarCursado();
                  formAgregarCursado.Show();
                  formAgregarCursado.FormClosed += (s, args) => btnListar_Click(sender, e);
              }
              else if (tipoDato == typeof(TPI.Entidades.Materia))
              {
                  formCrearMateria formCrearMateria = new formCrearMateria();
                  formCrearMateria.Show();
                  formCrearMateria.FormClosed += (s, args) => btnListar_Click(sender, e);

              }
              else if (tipoDato == typeof(TPI.Entidades.Persona))
              {
                  formNuevaPersona formNuevaPersona = new formNuevaPersona();
                  formNuevaPersona.Show();
                  formNuevaPersona.FormClosed += (s, args) => btnListar_Click(sender, e);

              }
              else if (tipoDato == typeof(TPI.Entidades.Plan))
              {
                  MessageBox.Show("No implementado");

              }
              else if (tipoDato == typeof(TPI.Entidades.Usuario))
              {
                  formNuevoUsuario formNuevoUsuario = new formNuevoUsuario();
                  formNuevoUsuario.Show();
                  formNuevoUsuario.FormClosed += (s, args) => btnListar_Click(sender, e);
              }
              else if (tipoDato == typeof(TPI.Entidades.Comision))
              {
                  formCrearComision formCrearComision = new formCrearComision();
                  formCrearComision.Show();
                  formCrearComision.FormClosed += (s, args) => btnListar_Click(sender, e);
              }
              else if (tipoDato == typeof(TPI.Entidades.Especialidad))
              {
                  formCrearEspecialidad formCrearEspecialidad = new formCrearEspecialidad();
                  formCrearEspecialidad.Show();
                  formCrearEspecialidad.FormClosed += (s, args) => btnListar_Click(sender, e);
              }
              else if (tipoDato == typeof(TPI.Entidades.TipoDeUsuario))
              {
                  //No implementado
              }
            */

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
                /* else if (tipoDato == typeof(TPI.Entidades.Cursado))
                 {
                     List<TPI.Entidades.Cursado> lpc = (List<TPI.Entidades.Cursado>)ListaGeneral[0];
                     TPI.Negocio.Cursado.Eliminar(lpc[filaSeleccionada]);

                 }
                 else if (tipoDato == typeof(TPI.Entidades.Materia))
                 {
                     //List<TPI.Entidades.Materia> lpc =  (List<TPI.Entidades.Materia>)ListaGeneral[0];
                     //TPI.Negocio.Materia.Eliminar(lpc[filaSeleccionada]);
                     //.FormClosed += (s, args) => btnListar_Click(sender, e);
                     MessageBox.Show("NO IMPLEMENTADO");
                 }
                 else if (tipoDato == typeof(TPI.Entidades.Persona))
                 {
                     MessageBox.Show("No implementado");


                 }
                 else if (tipoDato == typeof(TPI.Entidades.Plan))
                 {
                     //List<TPI.Entidades.Plan> lpc = (List<TPI.Entidades.Plan>)ListaGeneral[0];
                     //TPI.Negocio.Plan.Eliminar(lpc[filaSeleccionada]);
                     MessageBox.Show("NO IMPLEMENTADO");
                 }
                 else if (tipoDato == typeof(TPI.Entidades.Usuario))
                 {
                     //List<TPI.Entidades.Usuario> lpc = (List<TPI.Entidades.Usuario>)ListaGeneral[0];
                     // TPI.Negocio.Usuario.Eliminar(lpc[filaSeleccionada]); 
                     MessageBox.Show("NO IMPLEMENTADO");
                 }
                 else if (tipoDato == typeof(TPI.Entidades.Comision))
                 {
                     List<TPI.Entidades.Comision> lpc = (List<TPI.Entidades.Comision>)ListaGeneral[0];
                     TPI.Negocio.Comision.Eliminar(lpc[filaSeleccionada]);


                 }
                 else if (tipoDato == typeof(TPI.Entidades.Especialidad))
                 {
                     //List<TPI.Entidades.Especialidad> lpc = (List<TPI.Entidades.Especialidad>)ListaGeneral[0];
                     //TPI.Negocio.Especialidad.Eliminar(lpc[filaSeleccionada]);
                     MessageBox.Show("NO IMPLEMENTADO");
                 }
                 else if (tipoDato == typeof(TPI.Entidades.TipoDeUsuario))
                 {
                     //List<TPI.Entidades.TipoDeUsuario> lpc = (List<TPI.Entidades.TipoDeUsuario>)ListaGeneral[0];
                     //TPI.Negocio.TipoDeUsuario.Eliminar(lpc[filaSeleccionada]);
                     MessageBox.Show("NO IMPLEMENTADO");
                 }*/

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
            /* else if (tipoDato == typeof(TPI.Entidades.Cursado))
             {
                 List<TPI.Entidades.Cursado> lpc = (List<TPI.Entidades.Cursado>)ListaGeneral[0];
                 formModificarCursado formModificarCursado = new formModificarCursado(lpc[filaSeleccionada]);
                 formModificarCursado.Show();
                 formModificarCursado.FormClosed += (s, args) => btnListar_Click(sender, e);

             }
             else if (tipoDato == typeof(TPI.Entidades.Materia))
             {
                 MessageBox.Show("NO IMPLEMENTADO");
             }
             else if (tipoDato == typeof(TPI.Entidades.Persona))
             {
                 MessageBox.Show("NO IMPLEMENTADO");

             }
             else if (tipoDato == typeof(TPI.Entidades.Plan))
             {
                 MessageBox.Show("NO IMPLEMENTADO");
             }
             else if (tipoDato == typeof(TPI.Entidades.Usuario))
             {
                 MessageBox.Show("NO IMPLEMENTADO");
             }
             else if (tipoDato == typeof(TPI.Entidades.Comision))
             {
                 List<TPI.Entidades.Comision> lpc = (List<TPI.Entidades.Comision>)ListaGeneral[0];
                 formModificarComision formModificarComision = new formModificarComision(lpc[filaSeleccionada]);
                 formModificarComision.Show();
                 formModificarComision.FormClosed += (s, args) => btnListar_Click(sender, e);

             }
             else if (tipoDato == typeof(TPI.Entidades.Especialidad))
             {
                 formModificarEspecialidad formModificarEspecialidad = new formModificarEspecialidad();
                 formModificarEspecialidad.Show();
                 formModificarEspecialidad.FormClosed += (s, args) => btnListar_Click(sender, e);

             }
             else if (tipoDato == typeof(TPI.Entidades.TipoDeUsuario))
             {
                 MessageBox.Show("NO IMPLEMENTADO");
             }
            */


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
            /*  else if (tipoDato == typeof(TPI.Entidades.Cursado))
              {
                  List<TPI.Entidades.Cursado> lpc = (List<TPI.Entidades.Cursado>)ListaGeneral[0];
                  FormMostrarCursado formMostrarCursado = new FormMostrarCursado(lpc[filaSeleccionada]);
                  formMostrarCursado.Show();
                  formMostrarCursado.FormClosed += (s, args) => btnListar_Click(sender, e);
              }
              else if (tipoDato == typeof(TPI.Entidades.Materia))
              {
                  List<TPI.Entidades.Materia> lpc = (List<TPI.Entidades.Materia>)ListaGeneral[0];
                  formMostrarMateria formMostrarMateria = new formMostrarMateria(lpc[filaSeleccionada]);
                  formMostrarMateria.Show();
                  formMostrarMateria.FormClosed += (s, args) => btnListar_Click(sender, e);
              }
              else if (tipoDato == typeof(TPI.Entidades.Persona))
              {
                  List<TPI.Entidades.Persona> lpc = (List<TPI.Entidades.Persona>)ListaGeneral[0];
                  formMostrarPersona formMostrarPersona = new formMostrarPersona(lpc[filaSeleccionada]);
                  formMostrarPersona.Show();
                  formMostrarPersona.FormClosed += (s, args) => btnListar_Click(sender, e);
              }
              else if (tipoDato == typeof(TPI.Entidades.Plan))
              {
                  MessageBox.Show("NO IMPLEMENTADO");
              }
              else if (tipoDato == typeof(TPI.Entidades.Usuario))
              {
                  List<TPI.Entidades.Usuario> lpc = (List<TPI.Entidades.Usuario>)ListaGeneral[0];
                  formConsultarDatosUsuario formConsultarDatosUsuario = new formConsultarDatosUsuario(lpc[filaSeleccionada]);
                  formConsultarDatosUsuario.Show();
                  formConsultarDatosUsuario.FormClosed += (s, args) => btnListar_Click(sender, e);
              }
              else if (tipoDato == typeof(TPI.Entidades.Comision))
              {
                  List<TPI.Entidades.Comision> lpc = (List<TPI.Entidades.Comision>)ListaGeneral[0];
                  formMostrarComision formMostrarComision = new formMostrarComision(lpc[filaSeleccionada]);
                  formMostrarComision.Show();
                  formMostrarComision.FormClosed += (s, args) => btnListar_Click(sender, e);
              }
              else if (tipoDato == typeof(TPI.Entidades.Especialidad))
              {
                  List<TPI.Entidades.Especialidad> lpc = (List<TPI.Entidades.Especialidad>)ListaGeneral[0];
                  formMostrarEspecialidad formMostrarEspecialidad = new formMostrarEspecialidad(lpc[filaSeleccionada]);
                  formMostrarEspecialidad.Show();
                  formMostrarEspecialidad.FormClosed += (s, args) => btnListar_Click(sender, e);
              }
              else if (tipoDato == typeof(TPI.Entidades.TipoDeUsuario))
              {
                  MessageBox.Show("NO IMPLEMENTADO");
              }
            */
        }




    }
}

