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
    public partial class Home : UserControl
    {
        private MainForm _mainForm;
        private SceneHome _sceneHome;
        private ModelHome _moedelHome;
        private FigureHome _figureHome;
        private MaterialHome _materialHome;

        private FigureController _figureController;
        private MaterialController _materialController;

        private Client _currentClient;


        public Home(MainForm mainForm, Client currentClient)
        {
            _mainForm = mainForm;
            _currentClient = currentClient;

            InitializeControllers();
            InitializeHomeScenes();
            InitializeComponent();
            SetCurrentClientLabel();
            
            flyHome.Controls.Add(_figureHome);
        }

        private void InitializeControllers()
        {
            _figureController = new FigureController();
            _materialController = new MaterialController();
        }

        private void InitializeHomeScenes()
        {
            _sceneHome = new SceneHome();
            _moedelHome = new ModelHome();
            _figureHome = new FigureHome(_figureController, _currentClient);
            _materialHome = new MaterialHome(_materialController, _currentClient);
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
