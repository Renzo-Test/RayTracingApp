using Domain;
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
        private Scene _scene;
        public RenderProperties RenderProperties;

        public DefaultRenderSettings(SceneHome sceneHome)
        {
            _sceneHome = sceneHome;
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
				resolutionX = int.Parse(txtResX.Text);
				resolutionY = int.Parse(txtResY.Text);
				samplesPerPixel = int.Parse(txtSamplesPerPixel.Text);
				maxDepth = int.Parse(txtMaxDepth.Text);
			}
			catch (FormatException)
			{
				MessageBox.Show("Only integer values accepted");
				return;
			}

			try
			{
				RenderProperties.ResolutionX = resolutionX;
				RenderProperties.ResolutionY = resolutionY;
				RenderProperties.SamplesPerPixel = samplesPerPixel;
				RenderProperties.MaxDepth = maxDepth;

				_sceneHome.GoToSceneList();
			}
			catch (InvalidRenderPropertiesInputException ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}
