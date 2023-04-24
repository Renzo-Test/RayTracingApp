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
        private const string UsernamePlaceHolder = "Username";
        private const string PasswordPlaceHolder = "Password";
        private const string ConfirmPasswordPlaceholder = "Confirm Password";

        private MainForm _mainForm;

        public SignUp(MainForm mainForm)
        {
            _mainForm = mainForm;
            InitializeComponent();
        }
        
        private void lblSignIn_Click(object sender, EventArgs e)
        {
            _mainForm.GoToSignIn();
        }

        private void lblSignUp_Click(object sender, EventArgs e)
        {
            _mainForm.GoToSignIn();

        }
        
        private void picSignUpBackground_Click(object sender, EventArgs e)
        {
            _mainForm.GoToSignIn();

        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            RemovePlaceHolder(txtUsername, UsernamePlaceHolder);
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            SetPlaceHolder(txtUsername, UsernamePlaceHolder);
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            RemovePlaceHolder(txtPassword, PasswordPlaceHolder);
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            SetPlaceHolder(txtPassword, PasswordPlaceHolder);
        }

        private void txtConfirmPassword_Enter(object sender, EventArgs e)
        {
            RemovePlaceHolder(txtConfirmPassword, ConfirmPasswordPlaceholder);
        }

        private void txtConfirmPassword_Leave(object sender, EventArgs e)
        {
            SetPlaceHolder(txtConfirmPassword, ConfirmPasswordPlaceholder);
        }

        private void RemovePlaceHolder(TextBox txtField, string placeHolder)
        {
            if (txtField.Text == placeHolder)
            {
                txtField.Text = string.Empty;
                txtField.ForeColor = Color.Black;
            }
        }
        private void SetPlaceHolder(TextBox txtField, string placeHolder)
        {
            if (txtField.Text == string.Empty)
            {
                txtField.Text = placeHolder;
                txtField.ForeColor = Color.DimGray;
            }
        }


    }
}
