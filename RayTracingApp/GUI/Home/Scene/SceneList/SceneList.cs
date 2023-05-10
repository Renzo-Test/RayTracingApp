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
    public partial class SceneList : UserControl
    {
        private SceneHome _sceneHome;

        private SceneController _sceneController;
        private Client _currentClient;

        public SceneList(SceneHome sceneHome, SceneController sceneController, Client currentClient)
        {
            _sceneHome = sceneHome;
            _sceneController = sceneController;
            _currentClient = currentClient;

            InitializeComponent();

        }

        public void PopulateItems()
        {

            List<Scene> scenes = _sceneController.ListScenes(_currentClient.Username);

            flySceneList.Controls.Clear();

            foreach (Scene scene in scenes)
            {
                SceneListItem item = new SceneListItem(_sceneHome, this, _sceneController, scene);
                flySceneList.Controls.Add(item);
            }

        }

        private void SceneList_Paint(object sender, PaintEventArgs e)
        {
            PopulateItems();
        }

        private void picAddScene_Click(object sender, EventArgs e)
        {
            GoToNewScene();
        }

        private void lblAddScene_Click(object sender, EventArgs e)
        {
            GoToNewScene();
        }

        private void picIconPlus_Click(object sender, EventArgs e)
        {
            GoToNewScene();
        }

        private void GoToNewScene()
        {
            Scene scene = _sceneController.CreateBlankScene(_currentClient);
            scene.PosisionatedModels = new List<PosisionatedModel>();

            _sceneController.AddScene(scene, _currentClient.Username);
            _sceneHome.GoToAddScene(scene);
        }

        private void picCamDefaultValues_Click(object sender, EventArgs e)
        {
            _sceneHome.GoToDefaultCam();
        }

    }
}
