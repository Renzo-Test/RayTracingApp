using Controller;
using Models;
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
                SceneListItem item = new SceneListItem(this, _sceneController, scene);
                flySceneList.Controls.Add(item);
            }

        }

        private void SceneList_Paint(object sender, PaintEventArgs e)
        {
            PopulateItems();
        }

        private void picAddScene_Click(object sender, EventArgs e)
        {
            _sceneHome.GoToAddScene();
        }

        private void lblAddScene_Click(object sender, EventArgs e)
        {
            _sceneHome.GoToAddScene();
        }

        private void picIconPlus_Click(object sender, EventArgs e)
        {
            _sceneHome.GoToAddScene();
        }

        private void picCamDefaultValues_Click(object sender, EventArgs e)
        {
            _sceneHome.GoToDefaultCam();
        }
    }
}
