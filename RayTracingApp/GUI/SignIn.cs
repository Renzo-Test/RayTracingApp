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
        private const string UsernamePlaceHolder = "Username";
        private const string PasswordPlaceHolder = "Password";
        private const char PasswordCharacter = '*';
        private const char PlainTextCharacter = '\0';

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

        private void lblSignIn_Click(object sender, EventArgs e)
        {
            _mainForm.GoToHome();
        }

        private void picSignInButton_Click(object sender, EventArgs e)
        {
            _mainForm.GoToHome();
        }

        private void txtUsernameSignIn_Enter(object sender, EventArgs e)
        {
            RemovePlaceHolder(txtUsernameSignIn, UsernamePlaceHolder);
        }

        private void txtUsernameSignIn_Leave(object sender, EventArgs e)
        {
            SetPlaceHolder(txtUsernameSignIn, UsernamePlaceHolder);
        }

        private void txtPasswordSignIn_Enter(object sender, EventArgs e)
        {
            RemovePlaceHolder(txtPasswordSignIn, PasswordPlaceHolder);
            HidePassword(txtPasswordSignIn);
        }

        private void HidePassword(TextBox txtField)
        {
            txtField.PasswordChar = PasswordCharacter;
        }

        private void txtPasswordSignIn_Leave(object sender, EventArgs e)
        {
            SetPlaceHolder(txtPasswordSignIn, PasswordPlaceHolder);
            ShowPassword(txtPasswordSignIn);

        }

        private void ShowPassword(TextBox txtField)
        {
            if (txtField.Text == PasswordPlaceHolder)
            {
                txtField.PasswordChar = PlainTextCharacter;
            }
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
