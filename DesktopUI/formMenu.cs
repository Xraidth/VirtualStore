
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
using EF.Models;
using DesktopUI.Reports;

namespace DesktopUI
{
    public partial class formMenu : Form
    {
        public EF.Models.User UserLogued;
        public formMenu(EF.Models.User user_logued)
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
            formListar formListar = new formListar(typeof(EF.Models.Product));
            formListar.Show();
        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formListar formListar = new formListar(typeof(Sale), UserLogued);
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
            formListar formListar = new formListar(typeof(EF.Models.Product));
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
            formListar formListar = new formListar(typeof(EF.Models.Product));
            formListar.Show();
        }

        private void formMenu_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.D0:
                case Keys.NumPad0:
                    this.Close();
                    break;
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
                case Keys.D4:
                case Keys.NumPad4:
                    lblReports_Click(sender, e);
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

        private void pbxReports_Click(object sender, EventArgs e)
        {
            formMenuReports formMenuReports = new formMenuReports();
            formMenuReports.Show();
        }

        private void tlpReports_Click(object sender, EventArgs e)
        {
            formMenuReports formMenuReports = new formMenuReports();
            formMenuReports.Show();
        }

        private void lblReports_Click(object sender, EventArgs e)
        {
            formMenuReports formMenuReports = new formMenuReports();
            formMenuReports.Show();

        }
    }
}
