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
    public partial class AddFigure : UserControl
    {
        private FigureHome _figureHome;

        public AddFigure(FigureHome figureHome)
        {
            _figureHome = figureHome;
            InitializeComponent();
        }
    }
}
