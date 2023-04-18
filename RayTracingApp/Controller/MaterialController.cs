using Controller.MaterialExceptions;
using IRepository;
using MemoryRepository.Exceptions;
using MemoryRepository.MaterialRepository;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class MaterialController
    {
        private const string EmptyNameMessage = "Material's name must not be empty";
        private const string NotAlphanumericMessage = "Material's name must not start or end with blank space";
        private const string SpaceCharacterConstant = " ";
        public IRepositoryMaterial Repository;

        public MaterialController()
        {
            Repository = new MaterialRepository();
        }
        public List<Material> ListMaterials(string username)
        {
            return Repository.GetMaterialsByClient(username);
        }

        public void AddMaterial(Material material, string username)
        {
            try
            {
                RunMaterialChecker(material, username);

                material.Owner = username;
                Repository.AddMaterial(material);
            }
            catch (InvalidMaterialInputException ex)
            {
                throw new InvalidMaterialInputException(ex.Message);

            }
            
        }
        public void RemoveMaterial(string name, string username)
        {
            Material deleteMaterial = Repository.GetMaterialsByClient(username).Find(mat => mat.Name.Equals(name));

            if (deleteMaterial is null)
            {
                string NotFoundMaterialMessage = $"Material with name {name} was not found";
                throw new NotFoundMaterialException(NotFoundMaterialMessage);

            }

            Repository.RemoveMaterial(deleteMaterial);
        }

        private void RunMaterialChecker(Material material, string username)
        {
            if (MaterialNameExist(material, username))
            {
                string AlreadyExsitingMaterialMessage = $"Material with name {material.Name} already exists";
                throw new AlreadyExsitingMaterialException(AlreadyExsitingMaterialMessage);
            }

            RunNameIsSpacedChecker(material);
            RunNameIsEmptyChecker(material);
        }

        private static void RunNameIsEmptyChecker(Material material)
        {
            if(material.Name.Equals(string.Empty))
            {
                throw new EmptyNameException(EmptyNameMessage);
            }
        }

        private static void RunNameIsSpacedChecker(Material material)
        {
            if(material.Name.StartsWith(SpaceCharacterConstant) || material.Name.EndsWith(SpaceCharacterConstant))
            {
                throw new NotAlphanumericException(NotAlphanumericMessage);
            }
        }

        private bool MaterialNameExist(Material material, string username)
        {
            try
            {
                List<Material> clientMaterials = Repository.GetMaterialsByClient(username);

                return clientMaterials.Find(mat => mat.Name.Equals(material.Name)) is object;
            }
            catch(NotFoundMaterialException)
            {
                return false;
            }
            
        }
    }
}
