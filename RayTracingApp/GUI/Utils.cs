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
        private const string PasswordPlaceHolder = "Password";
        private const char PasswordCharacter = '*';
        private const char PlainTextCharacter = '\0';

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

        public static void ShowPassword(ref TextBox txtField)
        {
            if (txtField.Text == PasswordPlaceHolder)
            {
                txtField.PasswordChar = PlainTextCharacter;
            }
        }
        public static void HidePassword(ref TextBox txtField)
        {
            txtField.PasswordChar = PasswordCharacter;
        }
    }
}
