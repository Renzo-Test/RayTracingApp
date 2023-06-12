using Controller;
using Controller.Exceptions;
using Domain;
using Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GUI
{
	public partial class FigureListItem : UserControl
	{
		private FigureController _figureController;
		private ModelController _modelController;

		private FigureList _figureList;
		private Sphere _sphere;

		private string _currentClient;
		private bool isEditing;

		public FigureListItem(FigureList figureList, MainController mainController, Sphere sphere)
		{
			InitializeComponent();
			InitializePanelAtributes(sphere);
			InitializeControllerAtributes(figureList, mainController, sphere);
		}

		private void InitializeControllerAtributes(FigureList figureList, MainController mainController, Sphere sphere)
		{
			_figureList = figureList;
			_modelController = mainController.ModelController;
			_figureController = mainController.FigureController;
			_currentClient = sphere.Owner;
			_sphere = sphere;

			isEditing = false;
		}

		private void InitializePanelAtributes(Sphere sphere)
		{
			txtFigureName.Text = sphere.Name;
			lblRadius.Text = $"Radius: {sphere.Radius}";
		}

		private void picIconX_Click(object sender, EventArgs e)
		{
			RemoveFigure(txtFigureName.Text);
		}

		private void RemoveFigure(string figureName)
		{
			List<Model> models = _modelController.ListModels(_currentClient);

			try
			{
				_figureController.RemoveFigure(figureName, _currentClient, models);
				_figureList.PopulateItems();
			}
			catch (FigureUsedByModelException ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void picIconPencilTick_Click(object sender, EventArgs e)
		{
			isEditing = !isEditing;

			if (isEditing)
			{
				picIconPencilTick.Image = GUI.Properties.Resources.tick;
				txtFigureName.Enabled = true;
				picXIcon.Visible = true;
			}
			else
			{
				picIconPencilTick.Image = GUI.Properties.Resources.pencil;
				txtFigureName.Enabled = false;
				picXIcon.Visible = false;
				ChangeFigureName(txtFigureName.Text, _sphere);
			}

		}

		private void ChangeFigureName(string newName, Sphere sphere)
		{
			try
			{
				_figureController.UpdateFigureName(sphere, _currentClient, newName);
				_figureList.PopulateItems();

			}
			catch (InvalidFigureInputException ex)
			{
				_figureList.PopulateItems();
				MessageBox.Show(ex.Message);
			}
		}

		private void picXIcon_Click(object sender, EventArgs e)
		{
			isEditing = false;
			picIconPencilTick.Image = GUI.Properties.Resources.pencil;

			txtFigureName.Enabled = false;
			picXIcon.Visible = false;

			_figureList.PopulateItems();
		}
	}
}
