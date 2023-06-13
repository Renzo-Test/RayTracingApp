using Domain;
using System.Collections.Generic;

namespace IRepository
{
	public interface IRepositoryFigure
	{
		List<Figure> GetFiguresByClient(Client client);
		void AddFigure(Figure figure, Client client);
		void RemoveFigure(Figure figure);
		void UpdateFigureName(Figure figure, string newName);
	}
}
