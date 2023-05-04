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
using Color = Models.Color;

namespace GUI
{
    public partial class ModelListItem : UserControl
    {
        private ModelController _modelController;
        private ModelList _modelList;
        private string _currentClient;

        public ModelListItem(ModelList modelList, ModelController modelController, Model model)
        {
            InitializeComponent();
            InitializePanelAtributes(model);
            InitializeControllers(modelList, modelController, model);
        }

        private void InitializeControllers(ModelList modelList, ModelController modelController, Model model)
        {
            _modelList = modelList;
            _modelController = modelController;
            _currentClient = model.Owner;
        }

        private void InitializePanelAtributes(Model model)
        {
            string FigureName = model.Figure.Name;
            string MaterialName = model.Material.Name;
            Color materialColor = model.Material.Color;
            
            lblModelName.Text = model.Name;
            lblFigureName.Text = $"Figure: {FigureName}";
            lblMaterialName.Text = $"Material: {MaterialName}";

            picMaterialColor.BackColor = System.Drawing.Color.FromArgb(materialColor.Red, materialColor.Green, materialColor.Blue);
        }

        private void picIconX_Click(object sender, EventArgs e)
        {
            _modelController.RemoveModel(lblModelName.Text, _currentClient);
            _modelList.PopulateItems();
        }
    }
}

    