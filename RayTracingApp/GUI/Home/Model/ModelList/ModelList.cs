using Controller;
using Domain;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GUI
{
	public partial class ModelList : UserControl
	{
		private ModelHome _modelHome;

		private MainController _mainController;
		private ModelController _modelController;
		private Client _currentClient;

		public ModelList(ModelHome modelHome, MainController mainController, Client currentClient)
		{
			_modelHome = modelHome;
			_mainController = mainController;
			_modelController = mainController.ModelController;
			_currentClient = currentClient;

			InitializeComponent();
		}
		public void PopulateItems()
		{
			List<Model> models = _modelController.ListModels(_currentClient);

			flyModelList.Controls.Clear();

			foreach (Model model in models)
			{
				ModelListItem item = new ModelListItem(this, _mainController, model);
				flyModelList.Controls.Add(item);
			}
		}

		private void picAddModel_Click(object sender, EventArgs e)
		{
			_modelHome.GoToAddModel();
		}
		private void lblAddModel_Click(object sender, EventArgs e)
		{
			_modelHome.GoToAddModel();
		}

		private void picIconPlus_Click(object sender, EventArgs e)
		{
			_modelHome.GoToAddModel();
		}

		private void ModelList_Paint(object sender, PaintEventArgs e)
		{
			PopulateItems();
		}
	}
}
