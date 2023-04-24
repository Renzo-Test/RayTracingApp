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
    public partial class FigureList : UserControl
    {
        private FigureHome _figureHome;

        public FigureList(FigureHome figureHome)
        {
            _figureHome = figureHome;
            InitializeComponent();
        }

        private void picAddFigure_Click(object sender, EventArgs e)
        {
            _figureHome.GoToAddFigure();
        }

        private void lblAddFigure_Click(object sender, EventArgs e)
        {
            _figureHome.GoToAddFigure();
        }

        private void picIconPlus_Click(object sender, EventArgs e)
        {
            _figureHome.GoToAddFigure();
        }
    }
}
