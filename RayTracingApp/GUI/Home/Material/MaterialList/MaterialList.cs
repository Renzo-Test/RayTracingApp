using Controller;
using Domain;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GUI
{
	public partial class MaterialList : UserControl
	{
		private MaterialHome _materialHome;

		private MaterialController _materialController;
		private MainController _mainController;

		private Client _currentClient;
		public MaterialList(MaterialHome materialHome, MainController mainController, Client currentClient)
		{
			_currentClient = currentClient;
			_materialHome = materialHome;

			InitializeControllers(mainController);

			InitializeComponent();
		}

		public void PopulateItems()
		{

			List<Material> materials = _materialController.ListMaterials(_currentClient);

			flyMaterialList.Controls.Clear();

			foreach (Material material in materials)
			{
				MaterialListItem item = new MaterialListItem(this, _mainController, material);
				flyMaterialList.Controls.Add(item);
			}

		}
		private void InitializeControllers(MainController mainController)
		{
			_mainController = mainController;
			_materialController = mainController.MaterialController;
		}

		private void MaterialList_Paint(object sender, PaintEventArgs e)
		{
			PopulateItems();
		}

		private void picAddMaterial_Click(object sender, EventArgs e)
		{
			_materialHome.GoToAddMaterial();
		}

		private void lblAddMaterial_Click(object sender, EventArgs e)
		{
			_materialHome.GoToAddMaterial();
		}

		private void picIconPlus_Click(object sender, EventArgs e)
		{
			_materialHome.GoToAddMaterial();
		}

	}
}
