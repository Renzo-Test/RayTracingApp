using Controller;
using Domain;
using Domain.Exceptions;
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
        private const string FovNumericErrorMessage = "Fov values must be numeric only";
        private const string VectorNumericErrorMessage = "Vector values must be numeric only";

        private SceneHome _sceneHome;

        private MainController _mainController;
        private ModelController _modelController;
        private SceneController _sceneController;

        private Scene _scene;
        private Client _currentClient;
        private List<PosisionatedModel> _posisionatedModels;
        private PosisionatedModel _model;


		public ScenePage(Scene scene, SceneHome sceneHome, MainController mainController, Client currentClient)
        {
            _sceneHome = sceneHome;

            _mainController = mainController;
            _modelController = mainController.ModelController;
            _sceneController = mainController.SceneController;

            _currentClient = currentClient;
            _posisionatedModels = scene.PosisionatedModels;


			InitializeComponent();

            _scene = scene;
            SetSceneTextAtributes();
            txtSceneName.KeyPress += new KeyPressEventHandler(CheckNameChange);

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

        private void picRender_Click(object sender, EventArgs e)
        {
            Render();
        }

        private void Render()
        {
			int fov;
            Vector lookFrom;
            Vector lookAt;

            try
            {
                (fov, lookFrom, lookAt) = SceneUtils.GetCameraAtributes(txtFov, txtLookAt, txtLookFrom);
            }
            catch (InvalidSceneInputException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            try
            {
                SetSceneAtributes(fov, lookFrom, lookAt);
            }
            catch (InvalidSceneInputException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

			RenderProperties properties = new RenderProperties();
            Renderer renderer = new Renderer()
            {
                Properties = properties,
                Scene = _scene,
            };

            string image = renderer.Render();

            Scanner scanner = new Scanner();
            Bitmap img = scanner.ScanImage(image);

            picScene.Image = img;

			_sceneController.UpdateLastRenderDate(_scene);
        }

        private void SetSceneAtributes(int fov, Vector lookFrom, Vector lookAt)
        {
            try
            {
                _scene.Fov = fov;
                _scene.CameraPosition = lookFrom;
                _scene.ObjectivePosition = lookAt;
                _scene.PosisionatedModels = _posisionatedModels;
            }
            catch(InvalidSceneInputException ex)
            {
                throw new InvalidSceneInputException(ex.Message);
            }
        }

        private static Vector CreateCameraVector(double[] vectorLookFromValues)
        {
            return new Vector()
            {
                X = vectorLookFromValues[0],
                Y = vectorLookFromValues[1],
                Z = vectorLookFromValues[2]
            };
        }

        private void picIconBack_Click(object sender, EventArgs e)
        {
            _sceneController.UpdateLastModificationDate(_scene);
            
            int fov;
            Vector lookFrom;
            Vector lookAt;

            try
            {
                (fov, lookFrom, lookAt) = SceneUtils.GetCameraAtributes(txtFov, txtLookAt, txtLookFrom);
            }
            catch (InvalidSceneInputException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            try
            {
                SetSceneAtributes(fov, lookFrom, lookAt);
            }
            catch (InvalidSceneInputException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            _sceneHome.GoToSceneList();
        }

        private void ScenePage_Paint(object sender, PaintEventArgs e)
        {
            PopulateAvailableItems();
            PopulateUsedItems();
        }

        private void SetSceneTextAtributes()
        {

            txtSceneName.Text = _scene.Name;

            Vector lookFrom = _scene.CameraPosition;
            Vector lookAt = _scene.ObjectivePosition;

            int fov = _scene.Fov;
            
            txtLookFrom.Text = StringUtils.ConstructVectorFormat(lookFrom);
            txtLookAt.Text = StringUtils.ConstructVectorFormat(lookAt);

            txtFov.Text = $"{fov}";
            
            lblLastModified.Text = $"Last Modified: {_scene.LastModificationDate}";

        }
        private void CheckNameChange(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                try
                {
                    _sceneController.UpdateSceneName(_scene, _currentClient.Username, txtSceneName.Text);
                }
                catch(InvalidSceneInputException ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }


                ActiveControl = txtLookFrom;

                e.Handled = true;
            }
        }
	}
}
