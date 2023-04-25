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
            InitializeAtributes(material);

            _materialController = materialController;
            _currentClient = material.Owner;
        }

        private void InitializeAtributes(Material material)
        {
            InitializeColorAtributes(material);

            lblMaterialName.Text = material.Name;

        }

        private void InitializeColorAtributes(Material material)
        {
            int red = material.Color.Red;
            int green = material.Color.Green;
            int blue = material.Color.Blue;

            lblRGB.Text = $"Red: {red} - Green: {green} - Blue: {blue}";

            picMaterialColor.BackColor = System.Drawing.Color.FromArgb(red, green, blue);
        }

        private void picIconX_Click(object sender, EventArgs e)
        {
            /*TODO CORRECTLY USE MODELS*/
            _materialController.RemoveMaterial(lblMaterialName.Text, _currentClient, new List<Model>());
        }
    }
}
