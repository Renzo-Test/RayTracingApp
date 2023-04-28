using Controller;
using Models;
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
    public partial class ModelList : UserControl
    {
        private ModelHome _modelHome;

        private ModelController _modelController;
        private Client _currentClient;

        public ModelList(ModelHome modelHome, ModelController modelController, Client currentClient)
        {
            _modelHome = modelHome;
            _modelController = modelController;
            _currentClient = currentClient;

            InitializeComponent();
        }

        private void picAddModel_Click(object sender, EventArgs e)
        {
            _modelHome.GoToAddModel();
        }

        private void ModelList_Paint(object sender, PaintEventArgs e)
        {
            PopulateItems();
        }
        public void PopulateItems()
        {

            List<Model> models;

            try
            {
                models = _modelController.ListModels(_currentClient.Username);
            }
            catch (Exception)
            {
                return;
            }

            flyModelList.Controls.Clear();

            foreach (Model model in models)
            {
                ModelListItem item = new ModelListItem(_modelController, model);
                flyModelList.Controls.Add(item);
            }

        }
    }
}
