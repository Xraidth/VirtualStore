
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
using DB.Models;

namespace DesktopUI
{
    public partial class formMenu : Form
    {
        public DB.Models.User UserLogued;
        public formMenu(DB.Models.User user_logued)
        {
            InitializeComponent();
            UserLogued = user_logued;
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formListar formListar = new formListar(typeof(User));
            formListar.Show();
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formListar formListar = new formListar(typeof(DB.Models.Product));
            formListar.Show();
        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formListar formListar = new formListar(typeof(Sale));
            formListar.Show();
        }

        private void salesLinesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formListar formListar = new formListar(typeof(SalesLine));
            formListar.Show();
        }

        private void tlpAdm_Click(object sender, EventArgs e)
        {
            formListar formListar = new formListar(typeof(User));
            formListar.Show();
        }

        private void tlpSales_Click(object sender, EventArgs e)
        {
            formListar formListar = new formListar(typeof(Sale), UserLogued);
            formListar.Show();
        }

        private void tlpDepo_Click(object sender, EventArgs e)
        {
            formListar formListar = new formListar(typeof(DB.Models.Product));
            formListar.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            formListar formListar = new formListar(typeof(User));
            formListar.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            formListar formListar = new formListar(typeof(Sale), UserLogued);
            formListar.Show();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            formListar formListar = new formListar(typeof(DB.Models.Product));
            formListar.Show();
        }

        private void formMenu_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.D1:
                case Keys.NumPad1:
                    usersToolStripMenuItem.PerformClick();
                    break;
                case Keys.D2:
                case Keys.NumPad2:
                    salesToolStripMenuItem.PerformClick();
                    break;
                case Keys.D3:
                case Keys.NumPad3:
                    productsToolStripMenuItem.PerformClick();
                    break;
                case Keys.Escape:
                    this.Close();
                    break;

            }
        }

        private void formMenu_Load(object sender, EventArgs e)
        {
            lblUserLogued.Text = UserLogued.UserName;  
        }
    }
}
