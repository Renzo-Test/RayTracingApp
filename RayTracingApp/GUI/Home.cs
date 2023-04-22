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
        public Home(MainForm mainForm)
        {
            _mainForm = mainForm;
            _figureHome = new FigureHome();
            InitializeComponent();
            flyHome.Controls.Add(_figureHome);

        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            _mainForm.GoToSignIn();
        }

        private void btnScenes_Click(object sender, EventArgs e)
        {

        }

        private void btnModel_Click(object sender, EventArgs e)
        {

        }

        private void btnMaterial_Click(object sender, EventArgs e)
        {

        }

        private void btnFigure_Click(object sender, EventArgs e)
        {

        }
    }
}
