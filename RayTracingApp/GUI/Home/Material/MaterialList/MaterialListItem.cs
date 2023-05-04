using Controller;
using Controller.MaterialExceptions;
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
    public partial class MaterialListItem : UserControl
    {
        private MaterialController _materialController;
        private ModelController _modelController;

        private string _currentClient;
        private MaterialList _materialList;

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
        }

        private void InitializeAtributes(Material material)
        {
            InitializeColorAtributes(material);

            lblMaterialName.Text = material.Name;

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
            List<Model> models = _modelController.ListModels(_currentClient);
            
            try
            {
                _materialController.RemoveMaterial(lblMaterialName.Text, _currentClient, models);
                _materialList.PopulateItems();
            }
            catch (MaterialUsedByModelException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
