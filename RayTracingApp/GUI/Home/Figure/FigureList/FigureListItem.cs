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
    public partial class FigureListItem : UserControl
    {

        public FigureListItem()
        {
            InitializeComponent();
        }

        private string _figureName;
        public string FigureName 
        { 
            get => _figureName; 
            set 
            {
                _figureName = value;
                lblFigureName.Text = "aa";
            }
        }

        private int _radius;
        public int Radius
        {
            get => _radius;
            set
            {
                _radius = value;
                lblRadius.Text = $"Radius: {value}";
            }
        }


    }
}
