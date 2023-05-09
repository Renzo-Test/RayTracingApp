using Controller;
using MemoryRepository.Exceptions;
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
    public partial class FigureList : UserControl
    {
        private FigureHome _figureHome;

        private FigureController _figureController;
        private MainController _mainController;

        private Client _currentClient;

        public FigureList(FigureHome figureHome, MainController mainController, Client currentClient)
        {
            _figureHome = figureHome;

            InitializeControllers(mainController, currentClient);

            InitializeComponent();
        }

        public void PopulateItems()
        {

            List<Figure> figures = _figureController.ListFigures(_currentClient.Username);

            flyFigureList.Controls.Clear();

            foreach (Sphere sphere in figures)
            {
                FigureListItem item = new FigureListItem(this, _mainController, sphere);
                flyFigureList.Controls.Add(item);
            }

        }

        private void InitializeControllers(MainController mainController, Client currentClient)
        {
            _mainController = mainController;
            _figureController = mainController.FigureController;
            _currentClient = currentClient;
        }

        private void FigureList_Paint(object sender, PaintEventArgs e)
        {
            PopulateItems();
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
