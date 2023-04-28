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
    public partial class picAddModel : UserControl
    {
        private ModelHome _modelHome;

        private ModelController _modelController;
        private Client _currentClient;

        public picAddModel(ModelHome modelHome, ModelController modelController, Client currentClient)
        {
            _modelHome = modelHome;
            _modelController = modelController;
            _currentClient = currentClient;

            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            _modelHome.GoToAddModel();
        }
    }
}
