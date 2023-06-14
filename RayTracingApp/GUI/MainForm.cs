using Controller;
using Domain;
using System.Windows.Forms;

namespace GUI
{
	public partial class MainForm : Form
	{
		private UserControl _signInPanel;
		private UserControl _signUpPanel;
		private UserControl _homePanel;
		private UserControl _logsPanel;

		private MainController _mainController;

		private Client _currentClient;

		public MainForm()
		{
			InitializeComponent();
			_mainController = new MainController();

			_signInPanel = new SignIn(this, _mainController.ClientController);
			_signUpPanel = new SignUp(this, _mainController.ClientController);

			flyMain.Controls.Add(_signInPanel);
		}

		public void GoToSignIn()
		{
			flyMain.Controls.Clear();
			flyMain.Controls.Add(_signInPanel);

			_currentClient = null;
		}

		public void GoToSignUp()
		{
			flyMain.Controls.Clear();
			flyMain.Controls.Add(_signUpPanel);
		}

		public void GoToHome(Client currentClient)
		{
			_homePanel = new Home(this, _mainController, currentClient);

			flyMain.Controls.Clear();
			flyMain.Controls.Add(_homePanel);

			_currentClient = currentClient;
		}

		public void GoToLogs()
		{
			flyMain.Controls.Clear();
			
			_logsPanel = new LogList(this, _mainController.LogController, _currentClient);
			flyMain.Controls.Add(_logsPanel);
		}
	}
}
