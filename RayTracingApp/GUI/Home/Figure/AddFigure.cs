using Controller;
using Domain;
using Domain.Exceptions;
using System;
using System.Windows.Forms;

namespace GUI
{
	public partial class AddFigure : UserControl
	{
		private const string NamePlaceHolder = "Name";
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

		private void AddNewFigure()
		{
			double radius;

			try
			{
				radius = GetParsedRadius();
			}
			catch (FormatException ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}

			try
			{
				Figure newFigure = CreateFigure(radius);
				_figureController.AddFigure(newFigure, _currentClient.Username);
				_figureHome.GoToFigureList();

				ResetPlaceholders();
			}
			catch (InvalidFigureInputException ex)
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
			catch (FormatException)
			{
				throw new FormatException(RadiusInputErrorMessage);
			}

		}

		private void Cancel()
		{
			ResetPlaceholders();
			_figureHome.GoToFigureList();
		}

		private void ResetPlaceholders()
		{
			InputUtils.ResetPlaceholder(ref txtInputName, NamePlaceHolder);
			InputUtils.ResetPlaceholder(ref txtInputRadius, RadiusPlaceHolder);
		}

		private void picRectangleFieldCancel_Click(object sender, EventArgs e)
		{
			Cancel();
		}

		private void lblCancel_Click(object sender, EventArgs e)
		{
			Cancel();
		}

		private void lblCancel_TextChanged(object sender, EventArgs e)
		{
			Cancel();
		}

		private void picRectangleFieldSave_Click(object sender, EventArgs e)
		{
			AddNewFigure();
		}

		private void lblSave_Click(object sender, EventArgs e)
		{
			AddNewFigure();
		}

		private void txtInputName_Enter(object sender, EventArgs e)
		{
			InputUtils.RemovePlaceHolder(ref txtInputName, NamePlaceHolder);
		}

		private void txtInputName_Leave(object sender, EventArgs e)
		{
			InputUtils.SetPlaceHolder(ref txtInputName, NamePlaceHolder);
		}

		private void txtInputRadius_Enter(object sender, EventArgs e)
		{
			InputUtils.RemovePlaceHolder(ref txtInputRadius, RadiusPlaceHolder);
		}

		private void txtInputRadius_Leave(object sender, EventArgs e)
		{
			InputUtils.SetPlaceHolder(ref txtInputRadius, RadiusPlaceHolder);
		}

	}
}
