﻿using Controller.MaterialExceptions;
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
            if(material.Name.Equals(""))
            {
                throw new EmptyNameException("Material's name must not be empty");
            }
        }

        private static void RunNameIsSpacedChecker(Material material)
        {
            if(material.Name.StartsWith(" ") || material.Name.EndsWith(" "))
            {
                throw new NotAlphanumericException("Material's name must not start or end with blank space");
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

        public void RemoveMaterial(string name, string username)
        {
            Material deleteMaterial = Repository.GetMaterialsByClient(username).Find(mat => mat.Name.Equals(name));

            if(deleteMaterial is null)
            {
                string NotFoundMaterialMessage = $"Material with name {name} was not found";
                throw new NotFoundMaterialException(NotFoundMaterialMessage);

            }

            Repository.RemoveMaterial(deleteMaterial);
        }
    }
}
