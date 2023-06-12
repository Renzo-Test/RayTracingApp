using DBRepository.Exceptions;
using Domain;
using IRepository;
using System.Collections.Generic;
using System.Linq;

namespace DBRepository
{
	public class MaterialRepository : IRepositoryMaterial
	{
		private const string NotFoundMaterialMessage = "Material was not found or already deleted";

		public string DBName { get; set; } = "RayTracingAppDB";

		public List<Material> GetMaterialsByClient(Client client)
		{
			using (var context = new AppContext(DBName))
			{
				return context.Materials.Where(material => material.Owner.Equals(client.Username)).ToList();
			}
		}

		public void AddMaterial(Material newMaterial)
		{
			using (var context = new AppContext(DBName))
			{
				context.Materials.Add(newMaterial);
				context.SaveChanges();
			}
		}

		public void RemoveMaterial(Material material)
		{
			using (var context = new AppContext(DBName))
			{
				Material deleteMaterial = context.Materials.FirstOrDefault(m => m.Id == material.Id);

				if (deleteMaterial is null)
				{
					throw new NotFoundMaterialException(NotFoundMaterialMessage);
				}

				context.Materials.Remove(deleteMaterial);
				context.SaveChanges();
			}
		}

		public void UpdateMaterialName(Material material, string newName)
		{
			using (var context = new AppContext(DBName))
			{
				Material updateMaterial = context.Materials.FirstOrDefault(m => m.Id == material.Id);
				updateMaterial.Name = newName;
				context.SaveChanges();
			}
		}
	}
}
