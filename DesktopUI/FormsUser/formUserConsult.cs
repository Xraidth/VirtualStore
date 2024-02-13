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
    public partial class formUserConsult : Form
    {
        public DB.Models.User? UserConsult { get; set; }
        public formUserConsult(DB.Models.User user_consult)
        {
            InitializeComponent();
            UserConsult = user_consult;
        }

        private void formUserConsult_Load(object sender, EventArgs e)
        {
            lblID.Text = Convert.ToString(UserConsult.UserId);
            lblUserName.Text = UserConsult.UserName;
            lblPass.Text = UserConsult.UserPassword;
        }
    }
}
