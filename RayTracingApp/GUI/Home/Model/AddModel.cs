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
using Controller.ModelExceptions;

namespace GUI
{
    public partial class AddModel : UserControl
    {
        private const string NamePlaceholder = "Name";

        private ModelHome _modelHome;

        private MaterialController _materialController;
        private FigureController _figureController;
        private ModelController _modelController;
        
        private Client _currentClient;

        public AddModel(ModelHome modelHome, MainController mainController, Client currentClient)
        {
            _modelHome = modelHome;
            _currentClient = currentClient;

            InitializeControllers(mainController);
            InitializeComponent();
        }

        private void InitializeControllers(MainController mainController)
        {
            _modelController = mainController.ModelController;
            _materialController = mainController.MaterialController;
            _figureController = mainController.FigureController;
        }

        private void picCard_Paint(object sender, PaintEventArgs e)
        {
            PopulateComboBoxes();
        }

        private void PopulateComboBoxes()
        {
            List<Figure> figures = _figureController.ListFigures(_currentClient.Username);
            List<Material> materials = _materialController.ListMaterials(_currentClient.Username);

            cmbFigures.Items.Clear();
            cmbMaterials.Items.Clear();

            foreach (Figure figure in figures)
            {
                cmbFigures.Items.Add(figure.Name);
            }

            foreach (Material material in materials)
            {
                cmbMaterials.Items.Add(material.Name);
            }

        }

        private void SaveModel()
        {
            Model newModel = CreateModel();

            try
            {
                _modelController.AddModel(newModel, _currentClient.Username);
                _modelHome.GoToModelList();
            }
            catch (InvalidModelInputException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private Model CreateModel()
        {
            return new Model()
            {
                Material = _materialController.GetMaterial(_currentClient.Username, cmbMaterials.Text),
                Figure = _figureController.GetFigure(_currentClient.Username, cmbFigures.Text),
                Name = txtInputName.Text,
            };
        }

        private void picRectangleFieldSave_Click(object sender, EventArgs e)
        {
            SaveModel();
        }

        private void picRectangleFieldCancel_Click(object sender, EventArgs e)
        {
            _modelHome.GoToModelList();
        }

        private void picDropDownFigures_Click(object sender, EventArgs e)
        {
            if (cmbFigures.Items.Count > 0)
            {
                cmbFigures.DroppedDown = true;
            }
        }

        private void picDropDownMaterial_Click(object sender, EventArgs e)
        {
            if (cmbMaterials.Items.Count > 0)
            {
                cmbMaterials.DroppedDown = true;
            }

        }

        private void txtInputName_Enter(object sender, EventArgs e)
        {
            Utils.RemovePlaceHolder(ref txtInputName, NamePlaceholder);
        }

        private void txtInputName_Leave(object sender, EventArgs e)
        {
            Utils.SetPlaceHolder(ref txtInputName, NamePlaceholder);
        }


        private void cmbFigures_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblFiguresList.Text = cmbFigures.Text;
        }

        private void cmbMaterials_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblMaterialsList.Text = cmbMaterials.Text;
        }
    }
}
