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
    public partial class SceneHome : UserControl
    {
        private UserControl _addScenePanel;
        private UserControl _listScenePanel;
        private UserControl _defaultCamPanel;
        public SceneHome(MainController mainController, Client currentClient)
        {
            InitializeComponent();
            _addScenePanel = new ScenePage(this, mainController, currentClient);
            _listScenePanel = new SceneList(this, mainController.SceneController, currentClient);
            _defaultCamPanel = new DefaultCam(this, mainController, currentClient);
            flySceneHome.Controls.Add(_listScenePanel);
        }

        public void GoToAddScene()
        {
            flySceneHome.Controls.Clear();
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
    }
}
