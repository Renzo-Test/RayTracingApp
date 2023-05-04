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
    public partial class ModelHome : UserControl
    {
        private UserControl _addModelPanel;
        private UserControl _modelListPanel;

        public ModelHome(MainController mainController, Client currentClient)
        {
            InitializeComponent();
            _addModelPanel = new AddModel(this, mainController, currentClient);
            _modelListPanel = new ModelList(this, mainController.ModelController, currentClient);
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
