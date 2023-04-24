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
    public partial class MaterialList : UserControl
    {
        private MaterialHome _materialHome;
        public MaterialList(MaterialHome materialHome)
        {
            _materialHome = materialHome;
            InitializeComponent();
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
