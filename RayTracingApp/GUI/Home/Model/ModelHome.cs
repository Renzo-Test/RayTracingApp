using Controller;
using Domain;
using System.Windows.Forms;

namespace GUI
{
	public partial class ModelHome : UserControl
	{
		private UserControl _addModelPanel;
		private UserControl _modelListPanel;

		public ModelHome(MainController mainController, Client currentClient)
		{
			InitializeComponent();
			_addModelPanel = new AddModel(this, mainController, currentClient);
			_modelListPanel = new ModelList(this, mainController, currentClient);
			flyModelHome.Controls.Add(_modelListPanel);
		}

		public void GoToAddModel()
		{
			flyModelHome.Controls.Clear();
			flyModelHome.Controls.Add(_addModelPanel);
		}

		public void GoToModelList()
		{
			flyModelHome.Controls.Clear();
			flyModelHome.Controls.Add(_modelListPanel);
		}

		private void flyModelHome_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
