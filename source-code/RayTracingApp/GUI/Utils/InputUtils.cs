using System.Windows.Forms;

namespace GUI
{
	public static class InputUtils
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

		public static void ShowComboBox(ref ComboBox cmb)
		{
			if (cmb.Items.Count > 0)
			{
				cmb.DroppedDown = true;
			}
		}

		public static void ResetPlaceholder(ref TextBox txtField, string placeHolder)
		{
			txtField.Text = placeHolder;
			txtField.ForeColor = System.Drawing.Color.DimGray;
		}

		public static void ResetPasswordPlaceholder(ref TextBox txtField, string placeHolder)
		{
			txtField.Text = placeHolder;
			ShowPassword(ref txtField);
			txtField.ForeColor = System.Drawing.Color.DimGray;
		}

		public static void ResetPlaceholder(ref Label lblField, string placeHolder)
		{
			lblField.Text = placeHolder;
			lblField.ForeColor = System.Drawing.Color.DimGray;
		}
	}
}
