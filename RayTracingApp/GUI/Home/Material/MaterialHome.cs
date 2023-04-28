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
    public partial class MaterialHome : UserControl
    {
        private UserControl _addMaterialPanel;
        private UserControl _materialListPanel;

        public MaterialHome(MainController mainController, Client currentClient)
        {
            InitializeComponent();
            _materialListPanel = new MaterialList(this, mainController.MaterialController, currentClient);
            _addMaterialPanel = new AddMaterial(this, mainController.MaterialController, currentClient);
            flyMaterialHome.Controls.Add(_materialListPanel);
        }

        public void GoToAddMaterial()
        {
            flyMaterialHome.Controls.Clear();
            flyMaterialHome.Controls.Add(_addMaterialPanel);
        }

        public void GoToMaterialList()
        {
            flyMaterialHome.Controls.Clear();
            flyMaterialHome.Controls.Add(_materialListPanel);
        }
    }
}
