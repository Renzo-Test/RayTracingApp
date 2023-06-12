using Controller.Exceptions;
using DBRepository;
using DBRepository.Exceptions;
using Domain;
using Domain.Exceptions;
using IRepository;
using System.Collections.Generic;

namespace Controller
{
	public class FigureController
	{
		public IRepositoryFigure Repository;

		private const string DefaultDatabase = "RayTracingAppDB";
		public FigureController(string dbName = DefaultDatabase)
		{
			Repository = new FigureRepository()
			{
				DBName = dbName,
			};
		}

		public List<Figure> ListFigures(Client client)
		{
			return Repository.GetFiguresByClient(client);
		}

		public void AddFigure(Figure figure, Client client)
		{
			try
			{
				RunFigureChecker(figure, client);
				figure.Owner = client.Username;
				Repository.AddFigure(figure);
			}
			catch (InvalidFigureInputException ex)
			{
				throw new InvalidFigureInputException(ex.Message);
			}
		}

		public void RemoveFigure(string figureName, string username, List<Model> models)
		{
			Figure deleteFigure = Repository.GetFiguresByClient(username).Find(figure => figure.Name.Equals(figureName));

			if (deleteFigure is null)
			{
				string NotFoundFigureMessage = $"Figure with name {figureName} was not found";
				throw new NotFoundFigureException(NotFoundFigureMessage);
			}

			Model foundModel = models.Find(model => model.Figure.Name.Equals(figureName));
			if (foundModel is object)
			{
				string FigureUsedByModelMessage = $"Figure with name {figureName} is used by a model";
				throw new FigureUsedByModelException(FigureUsedByModelMessage);
			}
			Repository.RemoveFigure(deleteFigure);
		}

		public Figure GetFigure(string username, string name)
		{
			Figure getFigure = ListFigures(username).Find(fig => fig.Name.Equals(name));

			if (getFigure is null)
			{
				throw new NotFoundFigureException($"Figure with name {name} was not found");
			}

			return getFigure;
		}

		public void UpdateFigureName(Figure figure, string currentClient, string newName)
		{
			try
			{
				Sphere updateSphere = (Sphere)figure;
				Sphere newFigure = new Sphere()
				{
					Name = newName,
					Owner = updateSphere.Owner,
					Radius = updateSphere.Radius
				};

				RunFigureChecker(newFigure, currentClient);

				Repository.UpdateFigureName(figure, newName);
			}
			catch (InvalidFigureInputException ex)
			{
				throw new InvalidFigureInputException(ex.Message);
			}
		}

		private void RunFigureChecker(Figure figure, Client client)
		{
			if (FigureNameExist(figure.Name, client.Username))
			{
				string AlreadyExsitingFigureMessage = $"Figure with name {figure.Name} already exists";
				throw new AlreadyExistingFigureException(AlreadyExsitingFigureMessage);
			}

			FigurePropertiesAreValid(figure);
		}

		private bool FigureNameExist(string name, string ownerName)
		{
			List<Figure> clientFigures = Repository.GetFiguresByClient(ownerName);
			return clientFigures.Find(figure => figure.Name.Equals(name)) is object;
		}

		private void FigurePropertiesAreValid(Figure figure)
		{
			try
			{
				figure.FigurePropertiesAreValid();
			}

			catch (InvalidFigureInputException ex)
			{
				throw new InvalidFigureInputException(ex.Message);
			}
		}
	}
}
