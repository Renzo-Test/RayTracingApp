using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IRepository;
using MemoryRepository.Exceptions;
using Models;

namespace MemoryRepository
{
    public class FigureRepository : IRepositoryFigure
    {
        private readonly List<Figure> _figures;

        public FigureRepository()
        {
            _figures = new List<Figure>();
        }

        public List<Figure> GetFiguresByClient(string username)
        {
            List<Figure> foundFigures = _figures.FindAll(figure => figure.Owner.Equals(username));
            return foundFigures;
        }

        public void AddFigure(Figure newFigure)
        {
            _figures.Add(newFigure);
        }

        public void RemoveFigure(Figure figure)
        {
            _figures.Remove(figure);
        }

    }
}
