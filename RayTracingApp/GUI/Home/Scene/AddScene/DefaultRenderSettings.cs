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
    public partial class DefaultRenderSettings : UserControl
    {
        private SceneHome _sceneHome;
        private Scene _scene;

        public DefaultRenderSettings(SceneHome sceneHome, Scene scene)
        {
            _scene = scene;
            _sceneHome = sceneHome;
            InitializeComponent();
        }

        private void picRectangleFieldCancel_Click(object sender, EventArgs e)
        {
            _sceneHome.GoToAddScene(_scene);
        }

        private void lblCancel_Click(object sender, EventArgs e)
        {
            _sceneHome.GoToAddScene(_scene);
        }
    }
}
