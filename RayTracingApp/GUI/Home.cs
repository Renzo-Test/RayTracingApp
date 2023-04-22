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
        private FigureHome _figureHome;
        private MaterialHome _materialHome;
        private ModelHome _moedelHome;
        private SceneHome _sceneHome;


        public Home(MainForm mainForm)
        {
            _mainForm = mainForm;
            _sceneHome = new SceneHome();
            _moedelHome = new ModelHome();
            _figureHome = new FigureHome();
            _materialHome = new MaterialHome();

            InitializeComponent();
            flyHome.Controls.Add(_figureHome);

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
