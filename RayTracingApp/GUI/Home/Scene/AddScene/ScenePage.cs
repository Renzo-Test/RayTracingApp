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
    public partial class ScenePage : UserControl
    {
        private const string LookFromPlaceholder = "x, y, z";
        private const string LookAtPlaceholder = "x, y, z";
        private const string FovPlaceholder = "Fov";

        private SceneHome _sceneHome;
        private MainController _mainController;
        private ModelController _modelController;
        private Client _currentClient;

        public ScenePage(SceneHome sceneHome, MainController mainController, Client currentClient)
        {
            _sceneHome = sceneHome;
            _mainController = mainController;
            _modelController = mainController.ModelController;
            _currentClient = currentClient;

            InitializeComponent();
        }
        public void PopulateAvailableItems()
        {

            List<Model> models = _modelController.ListModels(_currentClient.Username);

            if (models.Any())
            {
                flyModels.BackColor = System.Drawing.Color.FromArgb(45, 45, 65);
            }

            flyModels.Controls.Clear();

            foreach (Model model in models)
            {
                AvailableModelItem item = new AvailableModelItem(model);
                flyModels.Controls.Add(item);
            }

        }

        public void PopulateUsedItems()
        {
            flyUsedModels.Controls.Clear();

            for (int i = 0; i < 3; i++)
            {
                flyUsedModels.BackColor = System.Drawing.Color.FromArgb(45, 45, 65);
                UsedModelItem item = new UsedModelItem();
                flyUsedModels.Controls.Add(item);
            }   

        }

        private void picIconBack_Click(object sender, EventArgs e)
        {
            _sceneHome.GoToSceneList();
        }

        private void ScenePage_Paint(object sender, PaintEventArgs e)
        {
            PopulateAvailableItems();
            PopulateUsedItems();
        }

        private void txtLookFrom_Enter(object sender, EventArgs e)
        {
            Utils.RemovePlaceHolder(ref txtLookFrom, LookFromPlaceholder);
        }

        private void txtLookFrom_Leave(object sender, EventArgs e)
        {
            Utils.SetPlaceHolder(ref txtLookFrom, LookFromPlaceholder);
        }

        private void txtLookAt_Enter(object sender, EventArgs e)
        {
            Utils.RemovePlaceHolder(ref txtLookAt, LookAtPlaceholder);
        }

        private void txtLookAt_Leave(object sender, EventArgs e)
        {
            Utils.SetPlaceHolder(ref txtLookAt, LookAtPlaceholder);
        }

        private void txtFov_Enter(object sender, EventArgs e)
        {
            Utils.RemovePlaceHolder(ref txtFov, FovPlaceholder);
        }

        private void txtFov_Leave(object sender, EventArgs e)
        {
            Utils.SetPlaceHolder(ref txtFov, FovPlaceholder);
        }

    }
}
