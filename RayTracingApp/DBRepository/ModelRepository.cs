using DBRepository.Exceptions;
using Domain;
using IRepository;
using System.Collections.Generic;
using System.Data.Entity;
using System.Drawing;
using System.Linq;

namespace DBRepository
{
	public class ModelRepository : IRepositoryModel
	{
		private const string NotFoundModelMessage = "Model was not found or already deleted";

		public string DBName { get; set; } = "RayTracingAppDB";

		public void AddModel(Model model, Client client)
		{
			using (var context = new AppContext(DBName))
			{
				Client modelClient = context.Clients.FirstOrDefault(c => c.Id == client.Id);
				model.Owner = modelClient;
				Material material = context.Materials.FirstOrDefault(m => m.Id.Equals(model.Material.Id));
				model.Material = material;
				Figure figure = context.Figures.FirstOrDefault(f => f.Id.Equals(model.Figure.Id));
				model.Figure = figure;

				context.Models.Add(model);
				context.SaveChanges();
			}
		}

		public List<Model> GetModelsByClient(Client client)
		{
			using (var context = new AppContext(DBName))
			{
				return context.Models.Where(model => model.Owner.Id.Equals(client.Id))
					.Include(model => model.Owner)
					.Include(model => model.Material)
					.Include(model => model.Figure)
					.ToList();
			}
		}

		public void RemoveModel(Model model)
		{
			using (var context = new AppContext(DBName))
			{
				Model deleteModel = context.Models.FirstOrDefault(m => m.Id == model.Id);

				if (deleteModel is null)
				{
					throw new NotFoundModelException(NotFoundModelMessage);
				}

				context.Models.Remove(deleteModel);
				context.SaveChanges();
			}
		}

		public void UpdateModelName(Model model, string newName)
		{
			using (var context = new AppContext(DBName))
			{
				Model updateModel = context.Models.FirstOrDefault(m => m.Id == model.Id);
				updateModel.Name = newName;
				context.SaveChanges();
			}
		}

		public void UpdatePreview(Model model, Image preview)
		{
			using (var context = new AppContext(DBName))
			{
				Model updateModel = context.Models.FirstOrDefault(m => m.Id == model.Id);
				updateModel.SetPreview(preview);
				context.SaveChanges();
			}
		}
	}
}
