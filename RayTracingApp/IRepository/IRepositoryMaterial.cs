using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRepository
{
    public interface IRepositoryMaterial
    {
        List<Material> GetMaterialsByClient(string username);
        void AddMaterial(Material material);
        void RemoveMaterial(Material material);
    }
}
