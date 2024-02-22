using DB;
using EF.Models;

namespace DesktopUI
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }



        private void btnSignin_Click(object sender, EventArgs e)
        {
            var userloged = DataUser.SignIn(txtUserName.Text, txtPass.Text);

            if (userloged != null)
            {
                this.Hide();
                var formMenu = new formMenu(userloged);
                formMenu.FormClosed += (s, args) => this.Close();
                formMenu.ShowDialog();

            }
            else
            {
                MessageBox.Show("Error in user authentication");
            }
        }

        private void formLogin_Load(object sender, EventArgs e)
        {
            
            try
            {
                DataUser.createAdmin();
            }
            catch (Exception ex)
            {                
                MessageBox.Show("Error al crear la base de datos: " + ex.Message);
            }
        }
    }
}