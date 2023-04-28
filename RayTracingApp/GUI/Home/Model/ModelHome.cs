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

        public ModelHome(ModelController modelController, FigureController figureController, MaterialController materialController, Client currentClient)
        {
            InitializeComponent();
            _addModelPanel = new AddModel(this, modelController, figureController, materialController, currentClient);
            _modelListPanel = new ModelList(this, modelController, currentClient);
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

    }
}
