using DB;
using DB.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopUI.FormsUser
{
    public delegate void ListarEventHandler(object sender, EventArgs e);
    public partial class formUserAdd : Form
    {
        public DB.Models.User? userUp;
        public formUserAdd()
        {
            InitializeComponent();
        }
        public formUserAdd(DB.Models.User user_update)
        {
            InitializeComponent();
            userUp = user_update;
            setCargarUpdate();
        }

        private void setCargarUpdate()
        {
            if (userUp != null)
            {
                btnAdd.Text = "Update";
                txtUserName.Text = userUp.UserName;
                txtPass.Text = userUp.UserPassword;
                txtConPass.Text = userUp.UserPassword;
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
            if (txtUserName.Text != "" && txtPass.Text != "" && txtConPass.Text != "")
            {

                if (txtConPass.Text == txtPass.Text)
                {

                    string txt_name_user = txtUserName.Text;
                    string txt_pass = txtPass.Text;

                    if (btnAdd.Text.ToString().Contains("Add"))
                    {

                        var new_usu = new User(txt_name_user, txt_pass);
                        DataUser.Insert(new_usu);
                    }
                    else
                    {
                        DataUser.Update(userUp, txt_name_user, txt_pass);
                    }

                    OnListarClicked(EventArgs.Empty);

                }
                else { MessageBox.Show(""); }



            }
            else
            {
                MessageBox.Show("Debe completar todos los campos");
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

        private void formUserAdd_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;

        }

        private void formUserAdd_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
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
}
