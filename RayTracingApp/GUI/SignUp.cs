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

        private MainForm _mainForm;

        private ClientController _clientController;

        public SignUp(MainForm mainForm, ClientController clientController)
        {
            _clientController = clientController;
            _mainForm = mainForm;
            InitializeComponent();
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

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            Utils.RemovePlaceHolder(ref txtUsername, UsernamePlaceHolder);
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            Utils.SetPlaceHolder(ref txtUsername, UsernamePlaceHolder);
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            Utils.RemovePlaceHolder(ref txtPassword, PasswordPlaceHolder);
            Utils.HidePassword(ref txtPassword);
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            Utils.SetPlaceHolder(ref txtPassword, PasswordPlaceHolder);
            Utils.ShowPassword(ref txtPassword);
        }

        private void txtConfirmPassword_Enter(object sender, EventArgs e)
        {
            Utils.RemovePlaceHolder(ref txtConfirmPassword, ConfirmPasswordPlaceholder);
            Utils.HidePassword(ref txtConfirmPassword);
        }

        private void txtConfirmPassword_Leave(object sender, EventArgs e)
        {
            Utils.SetPlaceHolder(ref txtConfirmPassword, ConfirmPasswordPlaceholder);
            Utils.ShowPassword(ref txtConfirmPassword);
        }

    }
}
