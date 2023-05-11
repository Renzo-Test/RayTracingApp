using IRepository;
using Domain;
using System.Collections.Generic;
using MemoryRepository.Exceptions;

namespace MemoryRepository
{
    public class FigureRepository : IRepositoryFigure
    {
        private const string NotFoundFigureMessage = "Figure was not found or already deleted";
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
            if (!_figures.Remove(figure))
            {
                throw new NotFoundFigureException(NotFoundFigureMessage);
            }
            else
            {
                _figures.Remove(figure);
            }
        }

    }
}
