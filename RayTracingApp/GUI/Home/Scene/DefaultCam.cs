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
    public partial class DefaultCam : UserControl
    {
        const string FovPlaceholder = "Fov";
        const string LookAtPlaceholder = "Look At";
        const string LookFromPlaceholder = "Look From";

        private SceneHome _sceneHome;
        private MainController _mainController;
        private Client _currentClient;

        public DefaultCam(SceneHome sceneHome, MainController mainController, Client currentClient)
        {
            InitializeComponent();

            _sceneHome = sceneHome;
            _mainController = mainController;
            _currentClient = currentClient;
        }

        private void txtInputLookAt_Enter(object sender, EventArgs e)
        {
            InputUtils.RemovePlaceHolder(ref txtInputLookAt, LookAtPlaceholder);
        }

        private void txtInputLookAt_Leave(object sender, EventArgs e)
        {
            InputUtils.SetPlaceHolder(ref txtInputLookAt, LookAtPlaceholder);

        }

        private void txtInputLookFrom_Enter(object sender, EventArgs e)
        {
            InputUtils.RemovePlaceHolder(ref txtInputLookFrom, LookFromPlaceholder);
        }

        private void txtInputLookFrom_Leave(object sender, EventArgs e)
        {
            InputUtils.SetPlaceHolder(ref txtInputLookFrom, LookFromPlaceholder);

        }

        private void txtInputFov_Enter(object sender, EventArgs e)
        {
            InputUtils.RemovePlaceHolder(ref txtInputFov, FovPlaceholder);
        }

        private void txtInputFov_Leave(object sender, EventArgs e)
        {
            InputUtils.SetPlaceHolder(ref txtInputFov, FovPlaceholder);
        }

        private void picRectangleFieldCancel_Click(object sender, EventArgs e)
        {
            _sceneHome.GoToSceneList();
        }

        private void lblCancel_Click(object sender, EventArgs e)
        {
            _sceneHome.GoToSceneList();
        }
    }
}
