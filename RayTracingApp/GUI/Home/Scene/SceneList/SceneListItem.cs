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
    public partial class SceneListItem : UserControl
    {
        private SceneController _sceneController;
        private SceneList _sceneList;
        private Scene _scene;
        private SceneHome _sceneHome;

        public SceneListItem(SceneHome sceneHome, SceneList sceneList, SceneController sceneController, Scene scene)
        {
            _sceneList = sceneList;
            _sceneController = sceneController;
            _scene = scene;
            _sceneHome = sceneHome;

            InitializeComponent();

            lblSceneName.Text = _scene.Name;
            if(_scene.Preview is object)
            {
                picIconScene.Image = _scene.Preview;
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
