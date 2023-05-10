using Controller;
using Controller.Exceptions;
using Domain;
using Domain.Exceptions;
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
			txtPassword.KeyPress += new KeyPressEventHandler(CheckEnter);
			txtUsername.KeyPress += new KeyPressEventHandler(CheckEnter);
            txtConfirmPassword.KeyPress += new KeyPressEventHandler(CheckEnter);
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
            InputUtils.RemovePlaceHolder(ref txtUsername, UsernamePlaceHolder);
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            InputUtils.SetPlaceHolder(ref txtUsername, UsernamePlaceHolder);
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            InputUtils.RemovePlaceHolder(ref txtPassword, PasswordPlaceHolder);
            InputUtils.HidePassword(ref txtPassword);
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            InputUtils.SetPlaceHolder(ref txtPassword, PasswordPlaceHolder);
            InputUtils.ShowPassword(ref txtPassword);
        }

        private void txtConfirmPassword_Enter(object sender, EventArgs e)
        {
            InputUtils.RemovePlaceHolder(ref txtConfirmPassword, ConfirmPasswordPlaceholder);
            InputUtils.HidePassword(ref txtConfirmPassword);
        }

        private void txtConfirmPassword_Leave(object sender, EventArgs e)
        {
            InputUtils.SetPlaceHolder(ref txtConfirmPassword, ConfirmPasswordPlaceholder);
            InputUtils.ShowPassword(ref txtConfirmPassword);
        }

		private void CheckEnter(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == Convert.ToChar(Keys.Enter))
			{
				SignUpUser();

				e.Handled = true;
			}
		}
	}
}
