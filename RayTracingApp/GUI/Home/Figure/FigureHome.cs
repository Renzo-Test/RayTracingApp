using Controller;
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
    public partial class FigureHome : UserControl
    {
        private UserControl _addFigurePanel;
        private UserControl _figureListPanel;

        public FigureHome(MainController mainController, Client currentClient)
        {
            InitializeComponent();
            _addFigurePanel = new AddFigure(this, mainController.FigureController, currentClient);
            _figureListPanel = new FigureList(this, mainController, currentClient);
            flyFigureHome.Controls.Add(_figureListPanel);
        }

        public void GoToAddFigure()
        {
            flyFigureHome.Controls.Clear();
            flyFigureHome.Controls.Add(_addFigurePanel);
        }

        public void GoToFigureList()
        {
            flyFigureHome.Controls.Clear();
            flyFigureHome.Controls.Add(_figureListPanel);
        }

    }
}
