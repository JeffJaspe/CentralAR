using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace CentralAR
{
    public partial class Login : KryptonForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void UserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserName_Enter(object sender, EventArgs e)
        {
            if (UserName.Text == "Username")
            {
                UserName.Text = " ";
            }
        }

        private void UserName_Leave(object sender, EventArgs e)
        {
            if (UserName.Text != "Username")
            {
                UserName.Text = "Username";
            }
        }

        private void Password_Enter(object sender, EventArgs e)
        {
            if (Password.Text == "Password")
            {
                Password.Text = "";
            }
        }

        private void Password_Leave(object sender, EventArgs e)
        {
            if (Password.Text != "Password")
            {
                Password.Text = "Password";
            }
        }
    }
}
