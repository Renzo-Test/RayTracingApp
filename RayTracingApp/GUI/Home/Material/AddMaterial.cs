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
    public partial class AddMaterial : UserControl
    {
        private const string NamePlaceholder = "Name";
        private const string RedPlaceholder = "Red";
        private const string GreenPlaceholder = "Green";
        private const string BluePlaceholder = "Blue";

        private MaterialHome _materialHome;
        
        public AddMaterial(MaterialHome materialHome)
        {
            _materialHome = materialHome;
            InitializeComponent();
        }

        private void picRectangleFieldCancel_Click(object sender, EventArgs e)
        {
            _materialHome.GoToMaterialList();
        }

        private void lblCancel_Click(object sender, EventArgs e)
        {
            _materialHome.GoToMaterialList();
        }

        private void txtInputName_Enter(object sender, EventArgs e)
        {
            RemovePlaceHolder(txtInputName, NamePlaceholder);
        }

        private void txtInputName_Leave(object sender, EventArgs e)
        {
            SetPlaceHolder(txtInputName, NamePlaceholder);
        }

        private void txtInputRed_Enter(object sender, EventArgs e)
        {
            RemovePlaceHolder(txtInputRed, RedPlaceholder);
        }

    private void txtInputRed_Leave(object sender, EventArgs e)
        {
            SetPlaceHolder(txtInputRed, RedPlaceholder);
        }

        private void txtInputGreen_Enter(object sender, EventArgs e)
        {
            RemovePlaceHolder(txtInputGreen, GreenPlaceholder);
        }

        private void txtInputGreen_Leave(object sender, EventArgs e)
        {
            SetPlaceHolder(txtInputGreen, GreenPlaceholder);
        }

        private void txtInputBlue_Enter(object sender, EventArgs e)
        {
            RemovePlaceHolder(txtInputBlue, BluePlaceholder);
        }

        private void txtInputBlue_Leave(object sender, EventArgs e)
        {
            SetPlaceHolder(txtInputBlue, BluePlaceholder);
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
