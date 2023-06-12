﻿using DBRepository.Exceptions;
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

		public void AddModel(Model newModel)
		{
			using (var context = new AppContext(DBName))
			{
				Material material = context.Materials.FirstOrDefault(m => m.Id.Equals(newModel.Material.Id));
				newModel.Material = material;
				Figure figure = context.Figures.FirstOrDefault(f => f.Id.Equals(newModel.Figure.Id));
				newModel.Figure = figure;

				context.Models.Add(newModel);
				context.SaveChanges();
			}
		}

		public List<Model> GetModelsByClient(string username)
		{
			using (var context = new AppContext(DBName))
			{
				return context.Models.Where(model => model.Owner.Equals(username))
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
