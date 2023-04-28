using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public static class Utils
    {
        public static void RemovePlaceHolder(ref TextBox txtField, string placeHolder)
        {
            if (txtField.Text == placeHolder)
            {
                txtField.Text = string.Empty;
                txtField.ForeColor = System.Drawing.Color.Black;

            }
        }
        public static void SetPlaceHolder(ref TextBox txtField, string placeHolder)
        {
            if (txtField.Text == string.Empty)
            {
                txtField.Text = placeHolder;
                txtField.ForeColor = System.Drawing.Color.DimGray;

            }

        }
    }
}
