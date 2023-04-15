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
        private List<Material> _materials;

        public MaterialRepository()
        {
            _materials = new List<Material>();
        }

        public void AddMaterial(Material newMaterial)
        {
            _materials.Add(newMaterial);
        }

        public List<Material> GetMaterialsByClient(string username)
        {
            List<Material> foundMaterials = _materials.FindAll(material => material.Owner.Equals(username));

            if(foundMaterials is null)
            {
                string NotFoundMaterialMessage = $"no material with owner: {username} was found";
                throw new NotFoundMaterialException(NotFoundMaterialMessage);
            }

            return foundMaterials;
        }

        public void RemoveMaterial(Material material)
        {
            _materials.Remove(material);
        }
    }
}
