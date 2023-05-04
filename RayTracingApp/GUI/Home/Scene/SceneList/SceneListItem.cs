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
    public partial class SceneListItem : UserControl
    {
        private SceneController _sceneController;
        private SceneList _sceneList;
        private Scene _scene;

        public SceneListItem()
        {
            InitializeComponent();
        }

        public SceneListItem(SceneList sceneList, SceneController sceneController, Scene scene)
        {
            _sceneList = sceneList;
            _sceneController = sceneController;
            _scene = scene;
        }
    }
}
