using IRepository;
using MemoryRepository.MaterialRepository;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class MaterialController
    {
        public IRepositoryMaterial Repository;

        public MaterialController()
        {
            Repository = new MaterialRepository();
        }

        public void AddMaterial(Material material, string username)
        {
            if (IsValid(material, username))
            {
                throw new NullReferenceException();
            }

            material.Owner = username;
            Repository.AddMaterial(material);
        }

        private bool IsValid(Material material, string username)
        {
            return MaterialNameExist(material, username) || NameIsSpaced(material) || NameIsEmpty(material);
        }

        private static bool NameIsEmpty(Material material)
        {
            return material.Name.Equals("");
        }

        private bool MaterialNameExist(Material material, string username)
        {
            return Repository.GetMaterialsByClient(username).Find(mat => mat.Owner.Equals(username) && mat.Name.Equals(material.Name)) is object;
        }

        private static bool NameIsSpaced(Material material)
        {
            return material.Name.StartsWith(" ") || material.Name.StartsWith(" ");
        }
    }
}
