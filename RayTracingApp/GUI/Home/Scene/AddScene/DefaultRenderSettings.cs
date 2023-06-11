using Controller;
using Domain;
using Domain.Exceptions;
using Engine;
using Engine.Exceptions;
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
        private Client _currentClient;
        private MainController _mainController;
        public RenderProperties RenderProperties;

        public DefaultRenderSettings(SceneHome sceneHome, MainController mainController,Client currentClient)
        {
            _sceneHome = sceneHome;
            _currentClient = currentClient;
            _mainController = mainController;
            RenderProperties = new RenderProperties();
            InitializeComponent();

        }

        private void picRectangleFieldCancel_Click(object sender, EventArgs e)
        {
            _sceneHome.GoToSceneList();
        }

        private void lblCancel_Click(object sender, EventArgs e)
        {
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

		private void Save()
		{
			int resolutionX;
			int resolutionY;
			int samplesPerPixel;
			int maxDepth;

			try
            {
                ParseProperties();
            }
            catch (FormatException)
			{
				MessageBox.Show("Only integer values accepted");
				return;
			}

			try
            {
                SetRenderProperties(resolutionX, resolutionY, samplesPerPixel, maxDepth);
                _sceneHome.GoToSceneList();
            }
            catch (InvalidRenderPropertiesInputException ex)
			{
				MessageBox.Show(ex.Message);
			}

            void ParseProperties()
            {
                maxDepth = int.Parse(txtMaxDepth.Text);
                resolutionX = int.Parse(txtResX.Text);
                resolutionY = int.Parse(txtResY.Text);
                samplesPerPixel = int.Parse(txtSamplesPerPixel.Text);
            }

            _mainController.ClientController.SaveDefaultRenderProperties(_currentClient, RenderProperties);
        }

        private void SetRenderProperties(int resolutionX, int resolutionY, int samplesPerPixel, int maxDepth)
        {
            RenderProperties.ResolutionX = resolutionX;
            RenderProperties.ResolutionY = resolutionY;
            RenderProperties.SamplesPerPixel = samplesPerPixel;
            RenderProperties.MaxDepth = maxDepth;
        }

        private void txtResX_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                int resX = int.Parse(txtResX.Text);
                int newYResolution = RenderProperties.PreCalculateYResolution(resX);

                txtResY.Text = $"{newYResolution}";
            }
            catch (FormatException)
            {
                return;
            }
        }

        private void txtResY_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                int resY = int.Parse(txtResY.Text);
                int newXResolution = RenderProperties.PreCalculateXResolution(resY);

                txtResX.Text = $"{newXResolution}";
            }
            catch (FormatException)
            {
                return;
            }
        }
    }
}
