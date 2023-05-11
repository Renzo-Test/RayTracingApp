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
        private SceneHome _sceneHome;
        private Client _currentClient;

        public DefaultCam(SceneHome sceneHome, MainController mainController, Client currentClient)
        {
            InitializeComponent();

            _sceneHome = sceneHome;
            _currentClient = currentClient;
            InitializePanelAttributes(currentClient);
        }

        private void InitializePanelAttributes(Client currentClient)
        {
            txtInputFov.Text = $"{currentClient.DefaultFov}";
            txtInputLookAt.Text = StringUtils.ConstructVectorFormat(currentClient.DefaultLookAt);
            txtInputLookFrom.Text = StringUtils.ConstructVectorFormat(currentClient.DefaultLookFrom);
        }

		private void Save()
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

			try
			{
				_currentClient.DefaultFov = fov;
			}
			catch (NotInExpectedRangeClientException ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}

			SetClientDefaultSceneValues(fov, lookFrom, lookAt);

			_sceneHome.GoToSceneList();
		}

		private void picRectangleFieldSave_Click(object sender, EventArgs e)
        {
			Save();
		}

		private void lblSave_Click(object sender, EventArgs e)
		{
			Save();
		}

		private void SetClientDefaultSceneValues(int fov, Vector lookFrom, Vector lookAt)
        {
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
