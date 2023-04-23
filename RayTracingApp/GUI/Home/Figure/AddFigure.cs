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

        private void txtInputName_Enter(object sender, EventArgs e)
        {
            RemovePlaceHolder(txtInputName, "Name");
        }

        private void txtInputName_Leave(object sender, EventArgs e)
        {
            SetPlaceHolder(txtInputName, "Name");
        }

        private void txtInputRadius_Enter(object sender, EventArgs e)
        {
            RemovePlaceHolder(txtInputRadius, "Radius");
        }

        private void txtInputRadius_Leave(object sender, EventArgs e)
        {
            SetPlaceHolder(txtInputRadius, "Radius");
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
