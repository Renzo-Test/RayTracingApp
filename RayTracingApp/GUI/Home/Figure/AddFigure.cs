using Controller;
using Models.FigureExceptions;
using Models.SphereExceptions;
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
    public partial class AddFigure : UserControl
    {
        private const string NamelaceHolder = "Name";
        private const string RadiusPlaceHolder = "Radius";
        private const string RadiusInputErrorMessage = "Input for radius must be a number";

        private FigureHome _figureHome;
        private FigureController _figureController;
        private Client _currentClient;

        public AddFigure(FigureHome figureHome, FigureController figureController, Client currentClient)
        {
            _figureHome = figureHome;
            _figureController = figureController;
            _currentClient = currentClient;
            InitializeComponent();
        }

        private void picRectangleFieldCancel_Click(object sender, EventArgs e)
        {
            _figureHome.GoToFigureList();
        }

        private void lblCancel_Click(object sender, EventArgs e)
        {
            _figureHome.GoToFigureList();
        }

        private void lblCancel_TextChanged(object sender, EventArgs e)
        {
            _figureHome.GoToFigureList();
        }

        private void picRectangleFieldSave_Click(object sender, EventArgs e)
        {
            AddNewFigure();
        }

        private void lblSave_Click(object sender, EventArgs e)
        {
            AddNewFigure();
        }

        private void AddNewFigure()
        {
            double radius = 0;

            try
            {
                radius = GetParsedRadius();
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            Figure newFigure = CreateFigure(radius);

            try
            {
                _figureController.AddFigure(newFigure, _currentClient.Username);
                _figureHome.GoToFigureList();
            }
            catch (Controller.FigureExceptions.InvalidFigureInputException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Models.FigureExceptions.InvalidFigureInputException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private Figure CreateFigure(double radius)
        {
            return new Sphere()
            {
                Name = txtInputName.Text,
                Radius = radius,
            };
        }

        private double GetParsedRadius()
        {
            try
            {
                return Double.Parse(txtInputRadius.Text);
            }
            catch(FormatException)
            {
                throw new FormatException(RadiusInputErrorMessage);
            }
           
        }

        private void txtInputName_Enter(object sender, EventArgs e)
        {
            RemovePlaceHolder(txtInputName, NamelaceHolder);
        }

        private void txtInputName_Leave(object sender, EventArgs e)
        {
            SetPlaceHolder(txtInputName, NamelaceHolder);
        }

        private void txtInputRadius_Enter(object sender, EventArgs e)
        {
            RemovePlaceHolder(txtInputRadius, RadiusPlaceHolder);
        }

        private void txtInputRadius_Leave(object sender, EventArgs e)
        {
            SetPlaceHolder(txtInputRadius, RadiusPlaceHolder);
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
    }
}
