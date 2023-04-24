using Controller;
using MemoryRepository.Exceptions;
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
    public partial class FigureList : UserControl
    {
        private FigureHome _figureHome;

        private FigureController _figureController;
        private Client _currentClient;

        public FigureList(FigureHome figureHome, FigureController figureController, Client currentClient)
        {
            _figureHome = figureHome;
            _figureController = figureController;
            _currentClient = currentClient;

            InitializeComponent();
        }

        private void FigureList_Paint(object sender, PaintEventArgs e)
        {
            PopulateItems();
        }

        public void PopulateItems()
        {

            List<Figure> figures;

            try
            {
               figures = _figureController.ListFigures(_currentClient.Username);
            }
            catch (NotFoundFigureException)
            {
                return;
            }

            flyFigureList.Controls.Clear();

            foreach (Sphere sphere in figures)
            {
                FigureListItem item = new FigureListItem(_figureController, sphere);
                flyFigureList.Controls.Add(item);
            }

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
