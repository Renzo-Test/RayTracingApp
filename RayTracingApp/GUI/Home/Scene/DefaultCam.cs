using Controller;
using Domain;
using Domain.Exceptions;
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

        private const int MinFov = 1;
        private const int MaxFov = 160;

        private SceneHome _sceneHome;
        private MainController _mainController;
        private Client _currentClient;

        public DefaultCam(SceneHome sceneHome, MainController mainController, Client currentClient)
        {
            InitializeComponent();

            _sceneHome = sceneHome;
            _mainController = mainController;
            _currentClient = currentClient;

            txtInputFov.Text = $"{currentClient.DefaultFov}";
            txtInputLookAt.Text = StringUtils.ConstructVectorFormat(currentClient.DefaultLookAt);
            txtInputLookFrom.Text = StringUtils.ConstructVectorFormat(currentClient.DefaultLookFrom);
        }
        
        private void picRectangleFieldSave_Click(object sender, EventArgs e)
        {
            int fov;
            Vector lookFrom;
            Vector lookAt;

            try
            {
                (fov, lookFrom, lookAt) = SceneUtils.GetCameraAtributes(txtInputFov, txtInputLookAt, txtInputLookFrom);
            }
            catch (InvalidSceneInputException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            if (!InRangeFov(fov))
            {
                MessageBox.Show($"Scene's fov must be between {MinFov} and {MaxFov}");
                return;
            }

            SetClientDefaultSceneValues(fov, lookFrom, lookAt);

            _sceneHome.GoToSceneList();
        }

        private static bool InRangeFov(int fov)
        {
            return Enumerable.Range(MinFov, MaxFov).Contains(fov);
        }

        private void SetClientDefaultSceneValues(int fov, Vector lookFrom, Vector lookAt)
        {
            _currentClient.DefaultFov = fov;
            _currentClient.DefaultLookAt = lookAt;
            _currentClient.DefaultLookFrom = lookFrom;
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
