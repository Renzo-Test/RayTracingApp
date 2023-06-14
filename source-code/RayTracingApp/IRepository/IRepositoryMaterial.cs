using Domain;
using System.Collections.Generic;

namespace IRepository
{
	public interface IRepositoryMaterial
	{
		List<Material> GetMaterialsByClient(Client client);
		void AddMaterial(Material material, Client client);
		void RemoveMaterial(Material material);
		void UpdateMaterialName(Material material, string newName);
	}
}
