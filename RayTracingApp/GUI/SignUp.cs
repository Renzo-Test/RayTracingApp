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
    public partial class SignUp : UserControl
    {
        private MainForm _mainForm;

        public SignUp(MainForm mainForm)
        {
            _mainForm = mainForm;
            InitializeComponent();
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            RemovePlaceHolder(txtUsername, "Username");
        }


        private void txtUsername_Leave(object sender, EventArgs e)
        {
            SetPlaceHolder(txtUsername, "Username");
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            RemovePlaceHolder(txtPassword, "Password");
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            SetPlaceHolder(txtPassword, "Password");
        }

        private void txtConfirmPassword_Enter(object sender, EventArgs e)
        {
            RemovePlaceHolder(txtConfirmPassword, "Confirm Password");
        }

        private void txtConfirmPassword_Leave(object sender, EventArgs e)
        {
            SetPlaceHolder(txtConfirmPassword, "Confirm Password");
        }

        private void RemovePlaceHolder(TextBox txtField, string placeHolder)
        {
            if (txtField.Text == placeHolder)
            {
                txtField.Text = "";

            }
        }
        private void SetPlaceHolder(TextBox txtField, string placeHolder)
        {
            if (txtField.Text == "")
            {
                txtField.Text = placeHolder;

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            _mainForm.GoToSignIn();
        }
    }
}
