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

        private FigureHome _figureHome;

        public AddFigure(FigureHome figureHome)
        {
            _figureHome = figureHome;
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
                txtField.ForeColor = Color.Black;

            }
        }
        private void SetPlaceHolder(TextBox txtField, string placeHolder)
        {
            if (txtField.Text == string.Empty)
            {
                txtField.Text = placeHolder;
                txtField.ForeColor = Color.DimGray;

            }
        }


    }
}
