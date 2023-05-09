using Domain;
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
    public partial class AvailableModelItem : UserControl
    {
        public AvailableModelItem(Model model)
        {
            InitializeComponent();
            lblModelName.Text = model.Name;
        }

        private void AvailableModelItem_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
