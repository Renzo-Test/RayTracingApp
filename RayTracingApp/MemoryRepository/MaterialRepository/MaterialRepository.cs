using IRepository;
using Models;
using System.Collections.Generic;

namespace MemoryRepository.MaterialRepository
{
	public class MaterialRepository : IRepositoryMaterial
	{
		private readonly List<Material> _materials;

		public MaterialRepository()
		{
			_materials = new List<Material>();
		}
		public List<Material> GetMaterialsByClient(string username)
		{
			List<Material> foundMaterials = _materials.FindAll(material => material.Owner.Equals(username));
			return foundMaterials;
		}

		public void AddMaterial(Material newMaterial)
		{
			_materials.Add(newMaterial);
		}

		public void RemoveMaterial(Material material)
		{
			_materials.Remove(material);
		}
	}
}
