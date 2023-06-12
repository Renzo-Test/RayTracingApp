using Controller;
using Domain;
using System.Drawing;
using System.Windows.Forms;

namespace GUI
{
	public partial class SceneHome : UserControl
	{
		private ScenePage _addScenePanel;
		private SceneList _listScenePanel;
		private DefaultCam _defaultCamPanel;
		private DefaultRenderSettings _defaultRenderSettings;

		private MainController _mainController;

		private RenderProperties _renderProperties;

		private Client _currentClient;

		public SceneHome(MainController mainController, Client currentClient)
		{
			_currentClient = currentClient;
			_mainController = mainController;

			InitializeComponent();

			_defaultRenderSettings = new DefaultRenderSettings(this, mainController, currentClient);
			_renderProperties = _defaultRenderSettings.RenderProperties;
			_listScenePanel = new SceneList(this, mainController.SceneController, currentClient);
			_defaultCamPanel = new DefaultCam(this, mainController, currentClient);
			flySceneHome.Controls.Add(_listScenePanel);
		}

		public void GoToAddScene(Scene scene)
		{
			flySceneHome.Controls.Clear();
			_addScenePanel = new ScenePage(scene, this, _mainController, _currentClient, _renderProperties);
			flySceneHome.Controls.Add(_addScenePanel);
		}

		public void GoToSceneList()
		{
			flySceneHome.Controls.Clear();
			flySceneHome.Controls.Add(_listScenePanel);
		}

		public void GoToDefaultCam()
		{
			flySceneHome.Controls.Clear();
			flySceneHome.Controls.Add(_defaultCamPanel);
		}

		public void GoToDefaultRenderSettings()
		{
			flySceneHome.Controls.Clear();
			flySceneHome.Controls.Add(_defaultRenderSettings);
		}

		public void GoToExportPage(Image img, string imgName)
		{
			flySceneHome.Controls.Clear();
			ExportPage exportPage = new ExportPage(this, img, imgName);
			flySceneHome.Controls.Add(exportPage);
		}
	}
}
