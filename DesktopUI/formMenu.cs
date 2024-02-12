﻿
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
        public formMenu()
        {
            InitializeComponent();
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
            formListar formListar = new formListar(typeof(Sale));
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
            formListar formListar = new formListar(typeof(Sale));
            formListar.Show();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            formListar formListar = new formListar(typeof(DB.Models.Product));
            formListar.Show();
        }
    }
}
