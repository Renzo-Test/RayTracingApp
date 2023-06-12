using Controller;
using Domain;
using Domain.Exceptions;
using System;
using System.Windows.Forms;

namespace GUI
{
	public partial class SignIn : UserControl
	{
		private const string UsernamePlaceHolder = "Username";
		private const string PasswordPlaceHolder = "Password";

		private MainForm _mainForm;

		private ClientController _clientController;

		public SignIn(MainForm mainForm, ClientController clientController)
		{
			_clientController = clientController;
			_mainForm = mainForm;
			InitializeComponent();
			txtPasswordSignIn.KeyPress += new KeyPressEventHandler(CheckEnter);
			txtUsernameSignIn.KeyPress += new KeyPressEventHandler(CheckEnter);
		}

		private void SignInUser()
		{
			string username = txtUsernameSignIn.Text;
			string password = txtPasswordSignIn.Text;

			try
			{
				Client currentClient = _clientController.SignIn(username, password);
				_mainForm.GoToHome(currentClient);

				ResetPlaceholders();
			}
			catch (InvalidCredentialsException ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void lblSignUpRef_Click(object sender, EventArgs e)
		{
			_mainForm.GoToSignUp();
			ResetPlaceholders();
		}


		private void lblSignIn_Click(object sender, EventArgs e)
		{
			SignInUser();
		}

		private void picSignInButton_Click(object sender, EventArgs e)
		{
			SignInUser();
		}

		private void ResetPlaceholders()
		{
			InputUtils.ResetPlaceholder(ref txtUsernameSignIn, UsernamePlaceHolder);
			InputUtils.ResetPasswordPlaceholder(ref txtPasswordSignIn, PasswordPlaceHolder);
		}


		private void txtUsernameSignIn_Enter(object sender, EventArgs e)
		{
			InputUtils.RemovePlaceHolder(ref txtUsernameSignIn, UsernamePlaceHolder);
		}

		private void txtUsernameSignIn_Leave(object sender, EventArgs e)
		{
			InputUtils.SetPlaceHolder(ref txtUsernameSignIn, UsernamePlaceHolder);
		}

		private void txtPasswordSignIn_Enter(object sender, EventArgs e)
		{
			InputUtils.RemovePlaceHolder(ref txtPasswordSignIn, PasswordPlaceHolder);
			InputUtils.HidePassword(ref txtPasswordSignIn);
		}

		private void txtPasswordSignIn_Leave(object sender, EventArgs e)
		{
			InputUtils.SetPlaceHolder(ref txtPasswordSignIn, PasswordPlaceHolder);
			InputUtils.ShowPassword(ref txtPasswordSignIn);

		}

		private void CheckEnter(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == Convert.ToChar(Keys.Enter))
			{
				SignInUser();

				e.Handled = true;
			}
		}
	}
}
