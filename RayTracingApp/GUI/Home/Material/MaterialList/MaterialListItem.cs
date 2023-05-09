using Controller;
using Controller.Exceptions;
using Domain;
using Domain.Exceptions;
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
    public partial class MaterialListItem : UserControl
    {
        private MaterialController _materialController;
        private ModelController _modelController;

        private MaterialList _materialList;
        private Material _material;

        private string _currentClient;
        private bool isEditing;

        public MaterialListItem(MaterialList materialList, MainController mainController, Material material)
        {
            InitializeComponent();
            InitializeAtributes(material);
            InitializeControllers(materialList, mainController, material);
        }

        private void InitializeControllers(MaterialList materialList, MainController mainController, Material material)
        {
            _materialList = materialList;
            _modelController = mainController.ModelController;
            _materialController = mainController.MaterialController;
            _currentClient = material.Owner;
            _material = material;
            isEditing = false;
        }

        private void InitializeAtributes(Material material)
        {
            InitializeColorAtributes(material);

            txtMaterialName.Text = material.Name;

        }

        private void InitializeColorAtributes(Material material)
        {
            int red = material.Color.Red;
            int green = material.Color.Green;
            int blue = material.Color.Blue;

            lblRGB.Text = $"Red: {red} - Green: {green} - Blue: {blue}";

            picMaterialColor.BackColor = System.Drawing.Color.FromArgb(red, green, blue);
        }

        private void picIconX_Click(object sender, EventArgs e)
        {
            RemoveMaterial(txtMaterialName.Text);
        }

        private void RemoveMaterial(string name)
        {
            List<Model> models = _modelController.ListModels(_currentClient);

            try
            {
                _materialController.RemoveMaterial(name, _currentClient, models);
                _materialList.PopulateItems();
            }
            catch (MaterialUsedByModelException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void picXIcon_Click(object sender, EventArgs e)
        {
            isEditing = false;
            picIconPencilTick.Image = GUI.Properties.Resources.pencil;

            txtMaterialName.Enabled = false;
            picXIcon.Visible = false;

            _materialList.PopulateItems();
        }

        private void picIconPencilTick_Click(object sender, EventArgs e)
        {
            isEditing = !isEditing;

            if (isEditing)
            {
                picIconPencilTick.Image = GUI.Properties.Resources.tick;
                txtMaterialName.Enabled = true;
                picXIcon.Visible = true;
            }
            else
            {
                picIconPencilTick.Image = GUI.Properties.Resources.pencil;
                txtMaterialName.Enabled = false;
                picXIcon.Visible = false;
                ChangeMaterialName(txtMaterialName.Text, _material);
            }
        }

        private void ChangeMaterialName(string newName, Material material)
        {
            try
            {
                _materialController.UpdateMaterialName(material, _currentClient, newName);
                _materialList.PopulateItems();

            }
            catch (InvalidMaterialInputException ex)
            {
                _materialList.PopulateItems();
                MessageBox.Show(ex.Message);
            }
        }

    }
}
