using Controller;
using Controller.FigureExceptions;
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
    public partial class FigureListItem : UserControl
    {
        private FigureController _figureController;
        private ModelController _modelController;

        private string _currentClient;

        public FigureListItem(MainController mainController, Sphere sphere)
        {
            InitializeComponent();
            InitializePanelAtributes(sphere);
            InitializeControllerAtributes(mainController, sphere);

        }

        private void InitializeControllerAtributes(MainController mainController, Sphere sphere)
        {
            _modelController = mainController.ModelController;
            _figureController = mainController.FigureController;
            _currentClient = sphere.Owner;
        }

        private void InitializePanelAtributes(Sphere sphere)
        {
            lblFigureName.Text = sphere.Name;
            lblRadius.Text = $"Radius: {sphere.Radius}";
        }

        private void picIconX_Click(object sender, EventArgs e)
        {
            List<Model> models = _modelController.ListModels(_currentClient);
            try
            {
                _figureController.RemoveFigure(lblFigureName.Text, _currentClient, models); 
            }
            catch(FigureUsedByModelException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
