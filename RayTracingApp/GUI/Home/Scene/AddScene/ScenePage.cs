using Controller;
using Domain;
using Domain.Exceptions;
using Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace GUI
{
	public partial class ScenePage : UserControl
	{
		private const string UnrenderedImageErrorMessage = "Can not export unrendered image";
		private const string DateFormat = "HH:mm:ss - dd/MM/yyyy";
		private const string Culture = "en-US";
		private SceneHome _sceneHome;

		private ModelController _modelController;
		private SceneController _sceneController;
		private LogController _logController;

		private Scene _scene;
		private Client _currentClient;
		private List<PosisionatedModel> _posisionatedModels;

		private double blurOff = 0.1;

		RenderProperties _renderProperties;

		public ScenePage(Scene scene, SceneHome sceneHome, MainController mainController, Client currentClient)
		{
			_renderProperties = currentClient.DefaultRenderProperties;

			InitializeControllers(mainController);
			SetAtributes(scene, currentClient, _renderProperties, sceneHome);
			InitializeComponent();
			SetSceneTextAtributes();

			CheckOutdatedScene();

			PopulateAvailableItems();
			PopulateUsedItems();
		}

		private void CheckOutdatedScene()
		{
			if (_scene.Preview is object && (_scene.LastModificationDate != "unmodified" && _scene.LastRenderDate != "unrendered") && DateTime.ParseExact(_scene.LastModificationDate, DateFormat, CultureInfo.GetCultureInfo(Culture)) > DateTime.ParseExact(_scene.LastRenderDate, DateFormat, CultureInfo.GetCultureInfo(Culture)))
			{
				ShowWarning();
			}
		}

		private void SetAtributes(Scene scene, Client currentClient, RenderProperties renderProperties, SceneHome sceneHome)
		{
			_scene = scene;
			_sceneHome = sceneHome;
			_currentClient = currentClient;
			_posisionatedModels = _sceneController.GetPosisionatedModels(_scene);
			_renderProperties = renderProperties;
		}

		private void InitializeControllers(MainController mainController)
		{
			_logController = mainController.LogController;
			_modelController = mainController.ModelController;
			_sceneController = mainController.SceneController;
		}

		public void PopulateAvailableItems()
		{

			List<Model> models = _modelController.ListModels(_currentClient);

			if (models.Any())
			{
				flyModels.BackColor = System.Drawing.Color.FromArgb(45, 45, 65);
			}

			flyModels.Controls.Clear();

			foreach (Model model in models)
			{
				AvailableModelItem item = new AvailableModelItem(this, model, _posisionatedModels, _sceneController, _scene);
				flyModels.Controls.Add(item);
			}

			if (_scene.Preview is object)
			{
				picScene.Image = _scene.GetPreview();
			}

		}

		public void PopulateUsedItems()
		{
			flyUsedModels.Controls.Clear();

			foreach (PosisionatedModel model in _posisionatedModels)
			{
				flyUsedModels.BackColor = System.Drawing.Color.FromArgb(45, 45, 65);
				UsedModelItem item = new UsedModelItem(_scene, this, model, _posisionatedModels, _sceneController);
				flyUsedModels.Controls.Add(item);
			}

		}

		public void ShowWarning()
		{
			lblImageOutdated.Visible = true;
			picIconWarning.Visible = true;
		}

		private void HideWarning()
		{
			lblImageOutdated.Visible = false;
			picIconWarning.Visible = false;
		}

		private void Render()
        {
            int fov;
            Vector lookFrom;
            Vector lookAt;
            double lensAperture;

            try
            {
                (fov, lookFrom, lookAt) = SceneUtils.GetCameraAtributes(txtFov, txtLookAt, txtLookFrom);
                lensAperture = SceneUtils.GetLensAperture(txtLensAperture);
            }
            catch (InvalidSceneInputException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            try
            {
                if (rbtnBlur.Checked)
                {
                    SetSceneAtributes(fov, lookFrom, lookAt, lensAperture);
                }
                else
                {
                    SetSceneAtributes(fov, lookFrom, lookAt, blurOff);
                }
            }
            catch (InvalidSceneInputException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            UpdateRenderingUI();
			_sceneController.UpdateLastRenderDate(_scene);

			Thread RenderingThread = new Thread(new ThreadStart(RenderImage));
			RenderingThread.Start();
		}

		private void UpdateRenderingUI()
		{
			pbrRender.Visible = true;
			HideWarning();
		}

		private void RenderImage()
		{
			Renderer renderer = new Renderer();

			RenderOutput renderOutput = renderer.Render(_scene, _renderProperties, pbrRender);

			long renderTime = renderOutput.RenderTime;
			string image = renderOutput.RenderedImage;

			Scanner scanner = new Scanner();
			Bitmap img = scanner.ScanImage(image);

			SetRenderedImage(img);
			CreateNewLog(renderTime);
			ReInitialazeUI();
		}
		private void ExportImage()
		{
			try
			{
				Save();
			}
			catch (InvalidSceneInputException ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}

			if (_scene.Preview is null)
			{
				MessageBox.Show(UnrenderedImageErrorMessage);
				return;
			}
			_sceneHome.GoToExportPage(_scene.GetPreview(), _scene.Name);
		}

		private void SetRenderedImage(Bitmap img)
		{
			_sceneController.UpdatePreview(_scene, img);
			picScene.Image = img;
		}

		private void CreateNewLog(long renderTime)
        {
			Log newLog = new Log()
			{
				SceneName = _scene.Name,
				Owner = _scene.Owner,
				RenderTime = ConvertToSeconds(renderTime),
				RenderDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
				TimeSpan = _logController.GetRenderTimeWindow(_scene.Name, _logController.ListLogs()),
				RenderedElements = _scene.PosisionatedModels.Count()
            };

            _logController.AddLog(newLog, _currentClient);
        }

        private static int ConvertToSeconds(long renderTime)
        {
            return (int)renderTime/1000;
        }

        private void ReInitialazeUI()
		{
			if (!RunningOnUiThread())
			{
				BeginInvoke(new Action(ReInitialazeUI));

				return;
			}

			pbrRender.Visible = false;
		}


		private void SetSceneAtributes(int fov, Vector lookFrom, Vector lookAt, double lensAperture)
		{
			try
			{
				setAtributesToRender(fov, lookFrom, lookAt, lensAperture);
			}
			catch (InvalidSceneInputException ex)
			{
				throw new InvalidSceneInputException(ex.Message);
			}
		}

		private void setAtributesToRender(int fov, Vector lookFrom, Vector lookAt, double lensAperture)
		{
			_scene.Fov = fov;
			_scene.LookFrom = lookFrom;
			_scene.LookAt = lookAt;
			_scene.PosisionatedModels = _posisionatedModels;
			_scene.LensAperture = lensAperture;
		}

		private void picIconBack_Click(object sender, EventArgs e)
		{
			try
			{
				Save();
			}
			catch (InvalidSceneInputException ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}

			_sceneHome.GoToSceneList();
		}

		private void Save()
		{
			int fov;
			Vector lookFrom;
			Vector lookAt;
			double lensAperture;

			(fov, lookFrom, lookAt) = SceneUtils.GetCameraAtributes(txtFov, txtLookAt, txtLookFrom);
			lensAperture = SceneUtils.GetLensAperture(txtLensAperture);

			bool wasModified = SceneWasModified(fov, lookFrom, lookAt, lensAperture);

			NameChange();
			SetSceneAtributes(fov, lookFrom, lookAt, lensAperture);

			if (wasModified)
			{
				_sceneController.UpdateLastModificationDate(_scene);
			}
			_sceneController.SaveSceneCameraAtributes(_scene);
		}

		private void NameChange()
		{
			if (_scene.Name != txtSceneName.Text)
			{
				_sceneController.UpdateSceneName(_scene, _currentClient, txtSceneName.Text);
			}
		}

		private bool SceneWasModified(int fov, Vector lookFrom, Vector lookAt, double lensAperture)
		{
			return _scene.Name != txtSceneName.Text
				|| _scene.Fov != fov
				|| _scene.LookFrom.ToString() != lookFrom.ToString()
				|| _scene.LookAt.ToString() != lookAt.ToString()
				|| _scene.LensAperture != lensAperture
				|| PosisionatedModelsWasModified();
		}

		private void CameraHasChanged(object sender, EventArgs e)
		{
			try
			{
				int fov;
				Vector lookFrom;
				Vector lookAt;

				(fov, lookFrom, lookAt) = SceneUtils.GetCameraAtributes(txtFov, txtLookAt, txtLookFrom);

				if (_scene.Preview is object
					&& (_scene.Fov != int.Parse(txtFov.Text)
					|| _scene.LookFrom.ToString() != lookFrom.ToString()
					|| _scene.LookAt.ToString() != lookAt.ToString()
					|| _scene.LensAperture != double.Parse(txtLensAperture.Text) && rbtnBlur.Checked))
				{
					ShowWarning();
				}
				else
				{
					HideWarning();
				}
			}
			catch (InvalidSceneInputException)
			{
				return;
			}
		}

		private bool PosisionatedModelsWasModified()
		{
			if (_posisionatedModels.Count != _scene.PosisionatedModels.Count)
			{
				return true;
			}

			for (int i = 0; i < _posisionatedModels.Count; i++)
			{
				if (_posisionatedModels[i].Id != _scene.PosisionatedModels[i].Id)
				{
					return true;
				}
			}

			return false;
		}

		private void ScenePage_Paint(object sender, PaintEventArgs e)
		{
			PopulateAvailableItems();
			PopulateUsedItems();
		}

		private bool RunningOnUiThread()
		{
			return !this.InvokeRequired;
		}

		private void SetSceneTextAtributes()
		{
			txtSceneName.Text = _scene.Name;

			Vector lookFrom = _scene.LookFrom;
			Vector lookAt = _scene.LookAt;

			int fov = _scene.Fov;
			double lensAperture = _scene.LensAperture;

			txtLookFrom.Text = StringUtils.ConstructVectorFormat(lookFrom);
			txtLookAt.Text = StringUtils.ConstructVectorFormat(lookAt);

			txtFov.Text = $"{fov}";
			txtLensAperture.Text = $"{lensAperture}";

			lblLastModified.Text = $"Last Modified: {_scene.LastModificationDate}";
		}

		private void LooseFocus()
		{
			ActiveControl = txtLookFrom;
		}

		private void picRender_Click(object sender, EventArgs e)
		{
			Render();
		}
		private void lblRender_Click(object sender, EventArgs e)
		{
			Render();
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			Render();
		}

		private void picIconExport_Click(object sender, EventArgs e)
		{
			ExportImage();
		}
		private void label2_Click(object sender, EventArgs e)
		{
			ExportImage();
		}

		private void pictureBox3_Click(object sender, EventArgs e)
		{
			ExportImage();
		}

		private void rbtnBlur_CheckedChanged(object sender, EventArgs e)
		{
			if(rbtnBlur.Checked && _scene.LensAperture == double.Parse(txtLensAperture.Text))
			{
				ShowWarning();
			}
		}
	}
}
