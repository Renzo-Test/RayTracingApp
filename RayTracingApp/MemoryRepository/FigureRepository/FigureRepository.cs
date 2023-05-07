using IRepository;
using Models;
using System.Collections.Generic;

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
