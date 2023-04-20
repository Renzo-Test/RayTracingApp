using Controller.SceneExceptions;
using Models;
using IRepository;
using MemoryRepository.Exceptions;
using MemoryRepository;
using System.Collections.Generic;
using System;

namespace Controller
{
    public class SceneController
    {
        private const string EmptyNameMessage = "Scene's name must not be empty";
        private const string SpaceCharacterConstant = " ";
        private const string StartOrEndWithSpaceMessage = "Scene's name must not start or end with blank space";
        public IRepositoryScene Repository;

        public SceneController() 
        {
            Repository = new SceneRepository();
        }

        public void AddScene(Scene newScene, string username)
        {
            try
            {
                SceneChecker(newScene, username);

                newScene.Owner = username;
                Repository.AddScene(newScene);
            }
            catch (InvalidSceneInputException ex)
            {
                throw new InvalidSceneInputException(ex.Message);
            }
        }

        private void SceneChecker(Scene scene, string username)
        {
            if (SceneNameExist(scene, username))
            {
                string AlreadyExistingSceneMessage = $"Scene with name {scene.Name} already exists";
                throw new AlreadyExistingSceneException(AlreadyExistingSceneMessage);
            }

            NameIsEmpty(scene);
            NameStartOrEndWithSpace(scene);
        }

        private bool SceneNameExist(Scene newScene, string username)
        {
            try
            {
                List<Scene> clientScenes = Repository.GetScenesByClient(username);
                return clientScenes.Find(scene => scene.Name.Equals(newScene.Name)) is object;
            }
            catch (NotFoundSceneException)
            {
                return false;
            }
        }

        private static void NameIsEmpty(Scene scene)
        {
            if (scene.Name.Equals(string.Empty))
            {
                throw new EmptyNameException(EmptyNameMessage);
            }
        }

        private static void NameStartOrEndWithSpace(Scene scene)
        {
            if (scene.Name.StartsWith(SpaceCharacterConstant) || scene.Name.EndsWith(SpaceCharacterConstant))
            {
                throw new InvalidSpacePositionException(StartOrEndWithSpaceMessage);
            }
        }

        public void UpdateLastModificationDate(Scene scene)
        {
            scene.LastModificationDate = DateTime.Now.ToString("hh:mm:ss - dd/MM/yyyy");
        }
    }
}
