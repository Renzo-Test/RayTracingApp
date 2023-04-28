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
using System.Collections.Generic;

namespace GUI
{
    public partial class AddModel : UserControl
    {
        private ModelHome _modelHome;
        private Client _currentClient;
        private MaterialController _materialController;
        private FigureController _figureController;
        private ModelController _modelController;

        public AddModel(ModelHome modelHome, ModelController modelController, FigureController figureController, MaterialController materialController, Client currentClient)
        {
            _modelHome = modelHome;
            _modelController = modelController;
            _materialController = materialController;
            _figureController = figureController;
            _currentClient = currentClient;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void picCard_Paint(object sender, PaintEventArgs e)
        {
            PopulateComboBoxes();
        }

        private void PopulateComboBoxes()
        {
            List<Figure> figures;
            List<Material> materials;

            try
            {
                figures = _figureController.ListFigures(_currentClient.Username);
            }
            catch (Exception ex)
            {
                figures = new List<Figure>();
            }

            try
            {
                materials = _materialController.ListMaterials(_currentClient.Username);
            }
            catch (Exception ex)
            {
                materials = new List<Material>();
            }

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

        private void picRectangleFieldCancel_Click(object sender, EventArgs e)
        {
            _modelHome.GoToModelList();
        }

        private void picCard_Click(object sender, EventArgs e)
        {

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

        private void RemovePlaceHolder(TextBox txtField, string placeHolder)
        {
            if (txtField.Text == placeHolder)
            {
                txtField.Text = string.Empty;
                txtField.ForeColor = System.Drawing.Color.Black;

            }
        }
        private void SetPlaceHolder(TextBox txtField, string placeHolder)
        {
            if (txtField.Text == string.Empty)
            {
                txtField.Text = placeHolder;
                txtField.ForeColor = System.Drawing.Color.DimGray;

            }

        }

        private void txtInputName_Enter(object sender, EventArgs e)
        {
            RemovePlaceHolder(txtInputName, "Name");
        }

        private void txtInputName_Leave(object sender, EventArgs e)
        {
            SetPlaceHolder(txtInputName, "Name");
        }

        private void picRectangleFieldSave_Click(object sender, EventArgs e)
        {
            Model newModel = new Model()
            {
                Material = _materialController.ListMaterials(_currentClient.Username).Find(mat => mat.Name.Equals(cmbMaterials.Text)),
                Figure = _figureController.ListFigures(_currentClient.Username).Find(Figure => Figure.Name.Equals(cmbFigures.Text)),
                Name = txtInputName.Text,
            };

            try
            {
                _modelController.AddModel(newModel, _currentClient.Username);
                _modelHome.GoToModelList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
