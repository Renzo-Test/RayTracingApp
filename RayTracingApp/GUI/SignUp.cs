using Controller;
using Controller.ClientExceptions;
using Models;
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
        private const string PasswordConfirmationErrorMessage = "Password and password confirmation do not match";
        private const char PasswordCharacter = '*';
        private const char PlainTextCharacter = '\0';

        private MainForm _mainForm;

        private ClientController _clientController;

        public SignUp(MainForm mainForm, ClientController clientController)
        {
            _clientController = clientController;
            _mainForm = mainForm;
            InitializeComponent();
        }
        
        private void lblSignIn_Click(object sender, EventArgs e)
        {
            _mainForm.GoToSignIn();
        }

        private void lblSignUp_Click(object sender, EventArgs e)
        {
            SignUpUser();
        }
        
        private void picSignUpBackground_Click(object sender, EventArgs e)
        {
            SignUpUser();

        }

        private void SignUpUser()
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string passwordConfirmation = txtConfirmPassword.Text;
            
            if(!PasswordMatch(password, passwordConfirmation))
            {
                MessageBox.Show(PasswordConfirmationErrorMessage);
                return;
            }

            try
            {
                _clientController.SignUp(username, password);
                _mainForm.GoToSignIn();
            }
            catch (InvalidCredentialsException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private static bool PasswordMatch(string password, string passwordConfirmation)
        {
            return password.Equals(passwordConfirmation);
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
            HidePassword(txtPassword);
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            SetPlaceHolder(txtPassword, PasswordPlaceHolder);
            ShowPassword(txtPassword);
        }

        private void txtConfirmPassword_Enter(object sender, EventArgs e)
        {
            RemovePlaceHolder(txtConfirmPassword, ConfirmPasswordPlaceholder);
            HidePassword(txtConfirmPassword);
        }

        private void txtConfirmPassword_Leave(object sender, EventArgs e)
        {
            SetPlaceHolder(txtConfirmPassword, ConfirmPasswordPlaceholder);
            ShowPassword(txtConfirmPassword);
        }

        private void RemovePlaceHolder(TextBox txtField, string placeHolder)
        {
            if (txtField.Text == placeHolder)
            {
                txtField.Text = string.Empty;
                txtField.ForeColor = System.Drawing.Color.Black;
            }
        }
        private void SetPlaceHolder(TextBox txtField, string placeHolder)
        {
            if (txtField.Text == string.Empty)
            {
                txtField.Text = placeHolder;
                txtField.ForeColor = System.Drawing.Color.DimGray;
            }
        }
        private void ShowPassword(TextBox txtField)
        {
            if (txtField.Text == PasswordPlaceHolder)
            {
                txtField.PasswordChar = PlainTextCharacter;
            }
        }
        private void HidePassword(TextBox txtField)
        {
            txtField.PasswordChar = PasswordCharacter;
        }
    }
}
