using Controller;
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
    public partial class MainForm : Form
    {
        private UserControl _signInPanel;
        private UserControl _signUpPanel;
        private UserControl _homePanel;

        private ClientController _clientController = new ClientController();
        private FigureController _figureController;
        private MaterialController _materialController;

        public MainForm()
        {
            InitializeComponent();
            
            _signInPanel = new SignIn(this, _clientController);
            _signUpPanel = new SignUp(this, _clientController);

            InitializeControllers();
            flyMain.Controls.Add(_signInPanel);
        }
        private void InitializeControllers()
        {
            _figureController = new FigureController();
            _materialController = new MaterialController();
        }

        public void GoToSignIn()
        {
            flyMain.Controls.Clear();
            flyMain.Controls.Add(_signInPanel);
        }

        public void GoToSignUp()
        {
            flyMain.Controls.Clear();
            flyMain.Controls.Add(_signUpPanel);
        }

        public void GoToHome(Client currentClient)
        {
            flyMain.Controls.Clear();
            _homePanel = new Home(this, _figureController, _materialController, currentClient);
            flyMain.Controls.Add(_homePanel);
        }
    }
}
