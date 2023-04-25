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
    public partial class MaterialListItem : UserControl
    {
        private MaterialController _materialController;
        private string _currentClient;

        public MaterialListItem(MaterialController materialController, Material material)
        {
            InitializeComponent();

            lblMaterialName.Text = material.Name;
            lblRGB.Text = $"Red: {material.Color.Red} - Green: {material.Color.Green} - Blue: {material.Color.Blue}";
            
            picMaterialColor.BackColor = System.Drawing.Color.FromArgb(material.Color.Red, material.Color.Green, material.Color.Blue);

            _materialController = materialController;
            _currentClient = material.Owner;
        }

        private void picIconX_Click(object sender, EventArgs e)
        {
            /*TODO CORRECTLY USE MODELS*/
            _materialController.RemoveMaterial(lblMaterialName.Text, _currentClient, new List<Model>());
        }
    }
}
