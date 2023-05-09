using IRepository;
using Domain;
using System.Collections.Generic;
using MemoryRepository.Exceptions;

namespace MemoryRepository.MaterialRepository
{
    public class MaterialRepository : IRepositoryMaterial
    {
        private const string NotFoundMaterialMessage = "Material was not found or already deleted";
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
            if (!_materials.Remove(material))
            {
                throw new NotFoundMaterialException(NotFoundMaterialMessage);
            }
            else
            {
                _materials.Remove(material);
            }
        }
    }
}
