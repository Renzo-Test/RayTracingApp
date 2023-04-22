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
        public Home(MainForm mainForm)
        {
            _mainForm = mainForm;
            InitializeComponent();
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
