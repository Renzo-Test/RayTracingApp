using Domain;
using IRepository;
using MemoryRepository.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBRepository
{
    public class MaterialRepository : IRepositoryMaterial
    {
        private const string NotFoundMaterialMessage = "Material was not found or already deleted";

        public string DBName { get; set; } = "RayTracingAppDB";


        public List<Material> GetMaterialsByClient(string username)
        {
            using (var context = new AppContext(DBName))
            {
                return context.Materials.Where(material => material.Owner.Equals(username)).ToList();
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
        }
    }
}
