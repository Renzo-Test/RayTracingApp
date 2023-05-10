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
    public partial class SceneHome : UserControl
    {
        private UserControl _addScenePanel;
        private UserControl _listScenePanel;
        private UserControl _defaultCamPanel;
        private UserControl _defaultRenderSettings;

        private MainController _mainController;
        
        private Client _currentClient;

        public SceneHome(MainController mainController, Client currentClient)
        {
            _currentClient = currentClient;
            _mainController = mainController;
            
            InitializeComponent();

            _defaultRenderSettings = new DefaultRenderSettings();
            _listScenePanel = new SceneList(this, mainController.SceneController, currentClient);
            _defaultCamPanel = new DefaultCam(this, mainController, currentClient);
            flySceneHome.Controls.Add(_listScenePanel);
        }

        public void GoToAddScene(Scene scene)
        {
            flySceneHome.Controls.Clear();
            _addScenePanel = new ScenePage(scene, this, _mainController, _currentClient);
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
    }
}
