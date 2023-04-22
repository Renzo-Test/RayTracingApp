using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class SignIn : UserControl
    {
        private MainForm _mainForm;
        public SignIn(MainForm mainForm)
        {
            _mainForm = mainForm;
            InitializeComponent();
        }

        private void lblSignUpRef_Click(object sender, EventArgs e)
        {
            _mainForm.GoToSignUp();
        }

        private void txtUsernameSignIn_Enter(object sender, EventArgs e)
        {
            if (txtUsernameSignIn.Text == "Username")
                txtUsernameSignIn.Text = "";
        }

        private void txtUsernameSignIn_Leave(object sender, EventArgs e)
        {
            if (txtUsernameSignIn.Text == "")
                txtUsernameSignIn.Text = "Username";
        }

        private void txtPasswordSignIn_Enter(object sender, EventArgs e)
        {
            if (txtPasswordSignIn.Text == "Password")
                txtPasswordSignIn.Text = "";
        }

        private void txtPasswordSignIn_Leave(object sender, EventArgs e)
        {
            if (txtPasswordSignIn.Text == "")
                txtPasswordSignIn.Text = "Password";
        }
    }
}
