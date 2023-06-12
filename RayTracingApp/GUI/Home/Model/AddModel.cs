using Controller;
using Domain;
using Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GUI
{
	public partial class AddModel : UserControl
	{
		private const string NamePlaceholder = "Name";
		private const string FigureListPlaceholder = "Figures";
		private const string MaterialListPlaceholder = "Materials";

		private const string NoMaterialSelectedErrorMessage = "No Material was Selected";
		private const string NoFigureSelectedErrorMessage = "No Figure was Selected";

		private ModelHome _modelHome;

		private MaterialController _materialController;
		private FigureController _figureController;
		private ModelController _modelController;

		private Client _currentClient;

		public AddModel(ModelHome modelHome, MainController mainController, Client currentClient)
		{
			_modelHome = modelHome;
			_currentClient = currentClient;

			InitializeControllers(mainController);
			InitializeComponent();
		}

		private void InitializeControllers(MainController mainController)
		{
			_modelController = mainController.ModelController;
			_materialController = mainController.MaterialController;
			_figureController = mainController.FigureController;
		}

		private void picCard_Paint(object sender, PaintEventArgs e)
		{
			PopulateComboBoxes();
		}

		private void PopulateComboBoxes()
		{
			List<Figure> figures = _figureController.ListFigures(_currentClient);
			List<Material> materials = _materialController.ListMaterials(_currentClient);

			ClearComboBoxes();

			AddItems(figures, materials);

		}

		private void ClearComboBoxes()
		{
			cmbFigures.Items.Clear();
			cmbMaterials.Items.Clear();
		}

		private void AddItems(List<Figure> figures, List<Material> materials)
		{
			foreach (Figure figure in figures)
			{
				cmbFigures.Items.Add(figure.Name);
			}

			foreach (Material material in materials)
			{
				cmbMaterials.Items.Add(material.Name);
			}
		}

		private void SaveModel()
		{
			if (string.IsNullOrEmpty(cmbMaterials.Text))
			{
				MessageBox.Show(NoMaterialSelectedErrorMessage);
				return;
			}

			if (string.IsNullOrEmpty(cmbFigures.Text))
			{
				MessageBox.Show(NoFigureSelectedErrorMessage);
				return;
			}

			try
			{
				Model newModel = CreateModel();

				_modelController.AddModel(newModel, _currentClient.Username);
				_modelHome.GoToModelList();

				ResetPlaceholders();
			}
			catch (InvalidModelInputException ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private Model CreateModel()
		{
			return new Model()
			{
				Material = _materialController.GetMaterial(_currentClient, cmbMaterials.Text),
				Figure = _figureController.GetFigure(_currentClient, cmbFigures.Text),
				Name = txtInputName.Text,
				ShowPreview = rbtnCreatePreview.Checked,
			};
		}



		private void Save()
		{
			SaveModel();
		}

		private void Cancel()
		{
			_modelHome.GoToModelList();
			ResetPlaceholders();
		}

		private void ResetPlaceholders()
		{
			InputUtils.ResetPlaceholder(ref txtInputName, NamePlaceholder);
			InputUtils.ResetPlaceholder(ref lblMaterialsList, MaterialListPlaceholder);
			InputUtils.ResetPlaceholder(ref lblFiguresList, FigureListPlaceholder);
		}

		private void picRectangleFieldCancel_Click(object sender, EventArgs e)
		{
			Cancel();
		}
		private void lblCancel_Click(object sender, EventArgs e)
		{
			Cancel();
		}

		private void picRectangleFieldSave_Click(object sender, EventArgs e)
		{
			Save();
		}

		private void lblSave_Click(object sender, EventArgs e)
		{
			Save();
		}

		private void picDropDownFigures_Click(object sender, EventArgs e)
		{
			InputUtils.ShowComboBox(ref cmbFigures);

		}

		private void lblFiguresList_Click(object sender, EventArgs e)
		{
			InputUtils.ShowComboBox(ref cmbFigures);
		}

		private void picDarkRectangleFigureList_Click(object sender, EventArgs e)
		{
			InputUtils.ShowComboBox(ref cmbFigures);
		}

		private void picDropDownMaterial_Click(object sender, EventArgs e)
		{
			InputUtils.ShowComboBox(ref cmbMaterials);
		}
		private void picDarkRectangleMaterialList_Click(object sender, EventArgs e)
		{
			InputUtils.ShowComboBox(ref cmbMaterials);
		}

		private void lblMaterialsList_Click(object sender, EventArgs e)
		{
			InputUtils.ShowComboBox(ref cmbMaterials);
		}

		private void txtInputName_Enter(object sender, EventArgs e)
		{
			InputUtils.RemovePlaceHolder(ref txtInputName, NamePlaceholder);
		}

		private void txtInputName_Leave(object sender, EventArgs e)
		{
			InputUtils.SetPlaceHolder(ref txtInputName, NamePlaceholder);
		}


		private void cmbFigures_SelectedIndexChanged(object sender, EventArgs e)
		{
			lblFiguresList.Text = cmbFigures.Text;
		}

		private void cmbMaterials_SelectedIndexChanged(object sender, EventArgs e)
		{
			lblMaterialsList.Text = cmbMaterials.Text;
		}
	}
}
