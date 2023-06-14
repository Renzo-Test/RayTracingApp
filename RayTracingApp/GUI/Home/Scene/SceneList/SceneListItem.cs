using Controller;
using Domain;
using System;
using System.Windows.Forms;

namespace GUI
{
	public partial class SceneListItem : UserControl
	{
		private SceneController _sceneController;
		private SceneList _sceneList;
		private Scene _scene;
		private SceneHome _sceneHome;

		public SceneListItem(SceneHome sceneHome, SceneList sceneList, SceneController sceneController, Scene scene)
		{
			_sceneList = sceneList;
			_sceneHome = sceneHome;

			_sceneController = sceneController;
			_scene = scene;

			InitializeComponent();
			InitializePanelAttributes();
			InitializePreview();
		}

		private void InitializePanelAttributes()
		{
			lblSceneName.Text = _scene.Name;
			lblLastModified.Text = $"Last modified: {_scene.LastModificationDate}";
		}

		private void InitializePreview()
		{
			if (_scene.Preview is object)
			{
				picIconScene.Image = _scene.GetPreview();
			}
		}

		private void picIconX_Click(object sender, EventArgs e)
		{
			_sceneController.RemoveScene(_scene.Name, _scene.Owner);
			_sceneList.PopulateItems();
		}

		private void SceneListItem_Click(object sender, EventArgs e)
		{
			_sceneHome.GoToAddScene(_scene);
		}

		private void picIconScene_Click(object sender, EventArgs e)
		{
			_sceneHome.GoToAddScene(_scene);
		}

		private void lblSceneName_Click(object sender, EventArgs e)
		{
			_sceneHome.GoToAddScene(_scene);
		}

		private void lblLastModified_Click(object sender, EventArgs e)
		{
			_sceneHome.GoToAddScene(_scene);
		}
	}
}
