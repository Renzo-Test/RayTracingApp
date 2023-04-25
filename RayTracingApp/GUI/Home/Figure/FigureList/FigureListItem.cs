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

namespace GUI
{
    public partial class FigureListItem : UserControl
    {
        private FigureController _figureController;
        private string _currentClient;

        public FigureListItem(FigureController figureController, Sphere sphere)
        {
            InitializeComponent();
            InitializePanelAtributes(sphere);
            InitializeControllerAtributes(figureController, sphere);

        }

        private void InitializeControllerAtributes(FigureController figureController, Sphere sphere)
        {
            _figureController = figureController;
            _currentClient = sphere.Owner;
        }

        private void InitializePanelAtributes(Sphere sphere)
        {
            lblFigureName.Text = sphere.Name;
            lblRadius.Text = $"Radius: {sphere.Radius}";
        }

        private void picIconX_Click(object sender, EventArgs e)
        {
            /*TODO CORRECTLY USE MODELS*/
            _figureController.RemoveFigure(lblFigureName.Text, _currentClient, new List<Model>()); 
        }
    }
}
