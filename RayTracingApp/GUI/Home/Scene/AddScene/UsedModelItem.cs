using Controller;
using Domain;
using Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class UsedModelItem : UserControl
    {
		private List<PosisionatedModel> _posisionatedModels;
        private PosisionatedModel _posisionatedModel;
        private SceneController _sceneController; 
        private ScenePage _scenePage;
        private Scene _scene;

		private bool isEditing = false;

		public UsedModelItem(Scene scene, ScenePage scenePage, PosisionatedModel posisionatedModel, List<PosisionatedModel> posisionatedModels, SceneController sceneController)
        {
            SetModels(posisionatedModel, posisionatedModels);

            _sceneController = sceneController; 
            _scenePage = scenePage;
            _scene = scene;

            InitializeComponent();
            InitializePanelAttributes(posisionatedModel);
        }

        private void SetModels(PosisionatedModel posisionatedModel, List<PosisionatedModel> posisionatedModels)
        {
            _posisionatedModels = posisionatedModels;
            _posisionatedModel = posisionatedModel;
        }

        private void InitializePanelAttributes(PosisionatedModel posisionatedModel)
        {
            txtPosition.Text = GetPosisionatedModelString(posisionatedModel);
            lblName.Text = posisionatedModel.Model.Name;
        }

        private string GetPosisionatedModelString(PosisionatedModel posisionatedModel)
        {
            double X = posisionatedModel.Position.X;
            double Y = posisionatedModel.Position.Y;
            double Z = posisionatedModel.Position.Z;

            return X + "," + Y + "," + Z;
        }

        private void picIconX_Click(object sender, EventArgs e)
        {
            _sceneController.RemoveModel(_scene, _posisionatedModel);
            _posisionatedModels.Remove(_posisionatedModel);
            _scenePage.PopulateUsedItems();
            _scenePage.ShowWarning();
        }

        public void UpdatePosisionatedModel()
        {
            try
            {
                string[] positionValues = StringUtils.DestructureVectorFromat(txtPosition.Text);
                SetPosisionatedModel(positionValues);
            }
            catch (InvalidSceneInputException ex)
            {
				MessageBox.Show(ex.Message);
			}

            _scenePage.PopulateUsedItems();
        }

        private void SetPosisionatedModel(string[] positionValues)
        {
            Vector newCoords = new Vector()
            {
                X = double.Parse(positionValues[0]),
                Y = double.Parse(positionValues[1]),
                Z = double.Parse(positionValues[2])
            };

            _posisionatedModel.Position = newCoords;
            _sceneController.UpdateModelsCoordinate(_posisionatedModel, newCoords);
        }

        private void picIconPencilTick_Click(object sender, EventArgs e)
		{
			isEditing = !isEditing;

			if (isEditing)
			{
				picIconPencilTick.Image = GUI.Properties.Resources.tick;
				txtPosition.Enabled = true;
				picXIcon.Visible = true;
			}
			else
			{
				picIconPencilTick.Image = GUI.Properties.Resources.pencil;
				txtPosition.Enabled = true;
				picXIcon.Visible = false;
				UpdatePosisionatedModel();
                _scenePage.ShowWarning();
            }
		}

		private void picXIcon_Click(object sender, EventArgs e)
		{
			isEditing = false;
			picIconPencilTick.Image = GUI.Properties.Resources.pencil;

			txtPosition.Enabled = false;
			picXIcon.Visible = false;

			_scenePage.PopulateUsedItems();
		}
	}
}
