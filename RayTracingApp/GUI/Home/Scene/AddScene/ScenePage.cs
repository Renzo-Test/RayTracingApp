using Controller;
using Domain;
using Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
        private SceneController _sceneController;
        private Client _currentClient;
        private List<PosisionatedModel> _posisionatedModels;

        public ScenePage(SceneHome sceneHome, MainController mainController, Client currentClient)
        {
            _sceneHome = sceneHome;
            _mainController = mainController;
            _modelController = mainController.ModelController;
            _currentClient = currentClient;
            _posisionatedModels = new List<PosisionatedModel>();

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
                AvailableModelItem item = new AvailableModelItem(this, model, _posisionatedModels);
                flyModels.Controls.Add(item);
            }

        }

        public void PopulateUsedItems()
        {
            flyUsedModels.Controls.Clear();

            foreach (PosisionatedModel model in _posisionatedModels)
            {
                flyUsedModels.BackColor = System.Drawing.Color.FromArgb(45, 45, 65);
                UsedModelItem item = new UsedModelItem(this, model, _posisionatedModels);
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

        private void picRender_Click(object sender, EventArgs e)
        {
            int fov = int.Parse(txtFov.Text);

            string[] txtLookFromValues = txtLookFrom.Text.Trim().Split(',');

            Vector lookFrom = new Vector()
            {
                X = Double.Parse(txtLookFromValues[0]),
                Y = Double.Parse(txtLookFromValues[1]),
                Z = Double.Parse(txtLookFromValues[2])
            };

            string[] txtLookAtValues = txtLookAt.Text.Trim().Split(',');

            Vector lookAt = new Vector()
            {
                X = Double.Parse(txtLookAtValues[0]),
                Y = Double.Parse(txtLookAtValues[1]),
                Z = Double.Parse(txtLookAtValues[2])
            };

            Scene scene = _sceneController.CreateBlankScene(_currentClient);
            
            RenderProperties rprops = new RenderProperties();
            
            Renderer r = new Renderer()
            {
                Properties = rprops,
                Scene = scene,
            };

            Scanner scanner = new Scanner();

            string image = r.Render();
            
            Bitmap img = scanner.ScanImage(image);

            picScene.Image = img;

        }
    }
}
