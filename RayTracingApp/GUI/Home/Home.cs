using Controller;
using Domain;
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
    public partial class Home : UserControl
    {
        private MainForm _mainForm;
        private SceneHome _sceneHome;
        private ModelHome _moedelHome;
        private FigureHome _figureHome;
        private MaterialHome _materialHome;

        private MainController _mainController;

        private Client _currentClient;

        public Home(MainForm mainForm, MainController mainController, Client currentClient)
        {
            _mainForm = mainForm;
            _currentClient = currentClient;
            _mainController = mainController;

            InitializeHomeScenes();
            InitializeComponent();
            SetCurrentClientLabel();
            
            flyHome.Controls.Add(_figureHome);
        }

        private void InitializeHomeScenes()
        {
            _sceneHome = new SceneHome(_mainController, _currentClient);
            _moedelHome = new ModelHome(_mainController, _currentClient);
            _figureHome = new FigureHome(_mainController, _currentClient);
            _materialHome = new MaterialHome(_mainController, _currentClient);
        }

        private void SetCurrentClientLabel()
        {
            lblCurrentClient.Text = _currentClient.Username;
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            _mainForm.GoToSignIn();
        }

        private void btnScenes_Click(object sender, EventArgs e)
        {
            flyHome.Controls.Clear();
            flyHome.Controls.Add(_sceneHome);
        }

        private void btnModel_Click(object sender, EventArgs e)
        {
            flyHome.Controls.Clear();
            flyHome.Controls.Add(_moedelHome);
        }

        private void btnMaterial_Click(object sender, EventArgs e)
        {
            flyHome.Controls.Clear();
            flyHome.Controls.Add(_materialHome);
        }

        private void btnFigure_Click(object sender, EventArgs e)
        {
            flyHome.Controls.Clear();
            flyHome.Controls.Add(_figureHome);
        }
    }
}
