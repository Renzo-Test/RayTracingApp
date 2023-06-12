using DBRepository.Exceptions;
using Domain;
using IRepository;
using System.Collections.Generic;
using System.Linq;

namespace DBRepository
{
	public class FigureRepository : IRepositoryFigure
	{
		private const string NotFoundFigureMessage = "Figure was not found";

		public string DBName { get; set; } = "RayTracingAppDB";

		public void AddFigure(Figure figure)
		{
			using (var context = new AppContext(DBName))
			{
				context.Figures.Add(figure);
				context.SaveChanges();
			}
		}

		public List<Figure> GetFiguresByClient(string username)
		{
			using (var context = new AppContext(DBName))
			{
				return context.Figures.Where(figure => figure.Owner.Equals(username)).ToList();
			}
		}

		public void RemoveFigure(Figure figure)
		{
			using (var context = new AppContext(DBName))
			{
				Figure deleteFigure = context.Figures.FirstOrDefault(f => f.Id == figure.Id);

				if (deleteFigure is null)
				{
					throw new NotFoundFigureException(NotFoundFigureMessage);
				}

				context.Figures.Remove(deleteFigure);
				context.SaveChanges();
			}
		}

		public void UpdateFigureName(Figure figure, string newName)
		{
			using (var context = new AppContext(DBName))
			{
				Figure updateFigure = context.Figures.FirstOrDefault(f => f.Id == figure.Id);
				updateFigure.Name = newName;
				context.SaveChanges();
			}
		}
	}
}
