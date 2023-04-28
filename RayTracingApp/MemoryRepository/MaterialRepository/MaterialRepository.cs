using IRepository;
using MemoryRepository.Exceptions;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
