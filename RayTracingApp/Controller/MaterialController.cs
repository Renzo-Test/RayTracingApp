using Controller.MaterialExceptions;
using IRepository;
using MemoryRepository.Exceptions;
using MemoryRepository.MaterialRepository;
using Models;
using System;
using System.Collections.Generic;

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

        public Material GetMaterial(string username, string name)
        {
            Material getMaterials = ListMaterials(username).Find(mat => mat.Name.Equals(name));
            
            if(getMaterials is null)
            {
                throw new NotFoundMaterialException($"Material with name {name} was not found");
            }

            return getMaterials;
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
            if (material.Name.Equals(string.Empty))
            {
                throw new EmptyNameException(EmptyNameMessage);
            }
        }

        private static void RunNameIsSpacedChecker(Material material)
        {
            if (material.Name.StartsWith(SpaceCharacterConstant) || material.Name.EndsWith(SpaceCharacterConstant))
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
            catch (NotFoundMaterialException)
            {
                return false;
            }

        }

        public void RemoveMaterial(string materialName, string username, List<Model> models)
        {
            Material deleteMaterial = Repository.GetMaterialsByClient(username).Find(mat => mat.Name.Equals(materialName));

            if (deleteMaterial is null)
            {
                string NotFoundMaterialMessage = $"Material with name {materialName} was not found";
                throw new NotFoundMaterialException(NotFoundMaterialMessage);
            }

            Model foundModel = models.Find(model => model.Material.Name.Equals(materialName));
            if (foundModel is object)
            {
                string MaterialUsedByModelMessage = $"Material with name {materialName} is used by a model";
                throw new MaterialUsedByModelException(MaterialUsedByModelMessage);
            }

            Repository.RemoveMaterial(deleteMaterial);
        }

    }
}
