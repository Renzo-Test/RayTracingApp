using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IRepository;
using Model;

namespace MemoryRepository
{
    public class FigureRepository : IRepositoryFigure
    {
        private List<Figure> _figureList;

        public FigureRepository()
        {
            _figureList = new List<Figure>();
        }

        public List<Figure> GetFiguresByClient(string username)
        {
            return _figureList;
        }

        public void AddFigure(Figure newFigure)
        {
            _figureList.Add(newFigure);
        }

        public void RemoveFigure(Figure figure)
        {
            _figureList.Remove(figure);
        }
    }
}
