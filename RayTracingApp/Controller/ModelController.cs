using Controller.ModelExceptions;
using IRepository;
using MemoryRepository;
using MemoryRepository.Exceptions;
using Models;
using System;
using System.Collections.Generic;

namespace Controller
{
    public class ModelController
    {
        public IRepositoryModel Repository;
        public ModelController()
        {
            Repository = new ModelRepository();
        }

        public List<Model> ListModels(string username)
        {
            return Repository.GetModelsByClient(username);
        }
        public void AddModel(Model model, string username)
        {
            try
            {
                RunModelChecker(model, username);
                model.Owner = username;
                Repository.AddModel(model);
            }
            catch (InvalidModelInputException ex)
            {
                throw new InvalidModelInputException(ex.Message);
            }
        }

        public void RemoveModel(string name, string username)
        {
            Model deleteModel = Repository.GetModelsByClient(username).Find(mod => mod.Name.Equals(name));
            if (deleteModel is null)
            {
                string NotFoundModelMessage = $"Model with name {name} was not found";
                throw new NotFoundMaterialException(NotFoundModelMessage);
            }

            Repository.RemoveModel(deleteModel);
        }
        private void RunModelChecker(Model model, string username)
        {
            if (ModelNameExist(model, username))
            {
                string AlreadyExistingModelName = $"Model with name {model.Name} already exist";
                throw new AlreadyExistingModelException(AlreadyExistingModelName);
            }
        }

        private bool ModelNameExist(Model model, string username)
        {
            List<Model> clientModels = Repository.GetModelsByClient(username);
            return clientModels.Find(mod => mod.Name.Equals(model.Name)) is object;
        }
        public Model GetModel(string username, string name)
        {
            Model getModel = ListModels(username).Find(mod => mod.Name.Equals(name));

            if (getModel is null)
            {
                throw new NotFoundModelException($"Model with name {name} was not found");
            }

            return getModel;

        }
    }
}
