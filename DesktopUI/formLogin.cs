using DB;

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
            if (DataUser.SignIn(txtUserName.Text, txtPass.Text) != null)
            {
                this.Hide();
                var formMenu = new formMenu();
                formMenu.FormClosed += (s, args) => this.Close();
                formMenu.ShowDialog();

            }
            else
            {
                MessageBox.Show("Error in user authentication");
            }
        }
    }
}