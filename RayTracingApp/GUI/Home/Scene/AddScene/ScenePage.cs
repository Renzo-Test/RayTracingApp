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

        private const string LookFromPlaceholder = "x, y, z";
        private const string LookAtPlaceholder = "x, y, z";
        private const string FovPlaceholder = "Fov";

        private SceneHome _sceneHome;

        private MainController _mainController;
        private ModelController _modelController;
        private SceneController _sceneController;

        private Scene _scene;
        private Client _currentClient;
        private List<PosisionatedModel> _posisionatedModels;

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
                (fov, lookFrom, lookAt) = GetCameraAtributes();
            }
            catch (InvalidSceneInputException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            SetSceneAtributes(fov, lookFrom, lookAt);

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
            _scene.Fov = fov;
            _scene.CameraPosition = lookFrom;
            _scene.ObjectivePosition = lookAt;
            _scene.PosisionatedModels = _posisionatedModels;
        }

        private (int, Vector, Vector) GetCameraAtributes()
        {
            int fov = GetFov();

            var (txtLookFromValues, txtLookAtValues) = GetStringVectorValues();

            double[] vectorLookFromValues = ParseDoubleValues(txtLookFromValues);
            double[] vectorLookAtValues = ParseDoubleValues(txtLookAtValues);

            Vector lookFrom = CreateCameraVector(vectorLookFromValues);
            Vector lookAt = CreateCameraVector(vectorLookAtValues);

            return (fov, lookFrom, lookAt);
        }

        private (string[], string[]) GetStringVectorValues()
        {
            try
            {
                string[] txtLookFromValues = StringUtils.DestructureVectorFromat(txtLookFrom.Text);
                string[] txtLookAtValues = StringUtils.DestructureVectorFromat(txtLookAt.Text);

                return (txtLookFromValues, txtLookAtValues);
            }
            catch (InvalidSceneInputException ex)
            {
                throw new InvalidSceneInputException(ex.Message);
            }
        }

        private int GetFov()
        {
            try
            {
                return int.Parse(txtFov.Text);
            }
            catch (FormatException)
            {
                throw new InvalidSceneInputException(FovNumericErrorMessage);
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

        private double[] ParseDoubleValues(string[] values)
        {
            double[] result = new double[values.Length];

            for (int i = 0; i < values.Length; i++)
            {
                try
                {
                    result[i] = double.Parse(values[i]);
                }
                catch (FormatException)
                {
                    throw new InvalidSceneInputException(VectorNumericErrorMessage);
                }
            }
            
            return result;
        }

        private void picIconBack_Click(object sender, EventArgs e)
        {
            _sceneController.UpdateLastModificationDate(_scene);
            
            int fov;
            Vector lookFrom;
            Vector lookAt;

            try
            {
                (fov, lookFrom, lookAt) = GetCameraAtributes();
            }
            catch (InvalidSceneInputException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            SetSceneAtributes(fov, lookFrom, lookAt);

            _sceneHome.GoToSceneList();
        }

        private void ScenePage_Paint(object sender, PaintEventArgs e)
        {
            PopulateAvailableItems();
            PopulateUsedItems();
        }

            Scene scene = _sceneController.CreateBlankScene(_currentClient);
            
            RenderProperties rprops = new RenderProperties();
            
            Renderer r = new Renderer()
            {
                Properties = rprops,
                Scene = scene,
            };
        private void SetSceneTextAtributes()
        {
            Vector lookFrom = _scene.CameraPosition;
            Vector lookAt = _scene.ObjectivePosition;

            int fov = _scene.Fov;
            
            txtLookFrom.Text = StringUtils.ConstructVectorFormat(lookFrom);
            txtLookAt.Text = StringUtils.ConstructVectorFormat(lookAt);

            txtFov.Text = $"{fov}";
            
            lblLastModified.Text = "LastModified: " + _scene.LastModificationDate;

        }

        private void txtLookFrom_Enter(object sender, EventArgs e)
        {
            InputUtils.RemovePlaceHolder(ref txtLookFrom, LookFromPlaceholder);
        }

        private void txtLookFrom_Leave(object sender, EventArgs e)
        {
            InputUtils.SetPlaceHolder(ref txtLookFrom, LookFromPlaceholder);
        }

        private void txtLookAt_Enter(object sender, EventArgs e)
        {
            InputUtils.RemovePlaceHolder(ref txtLookAt, LookAtPlaceholder);
        }

        private void txtLookAt_Leave(object sender, EventArgs e)
        {
            InputUtils.SetPlaceHolder(ref txtLookAt, LookAtPlaceholder);
        }

        private void txtFov_Enter(object sender, EventArgs e)
        {
            InputUtils.RemovePlaceHolder(ref txtFov, FovPlaceholder);
        }

        private void txtFov_Leave(object sender, EventArgs e)
        {
            InputUtils.SetPlaceHolder(ref txtFov, FovPlaceholder);
        }

    }
}
