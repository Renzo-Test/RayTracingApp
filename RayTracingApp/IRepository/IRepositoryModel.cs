using Domain;
using System.Collections.Generic;
using System.Drawing;

namespace IRepository
{
	public interface IRepositoryModel
	{
		List<Model> GetModelsByClient(string username);
		void AddModel(Model model, Client client);
		void RemoveModel(Model model);
		void UpdateModelName(Model model, string newName);
		void UpdatePreview(Model model, Image preview);
	}
}
