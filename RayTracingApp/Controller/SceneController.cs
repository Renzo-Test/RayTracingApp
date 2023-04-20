using Controller.SceneExceptions;
using Models;
using IRepository;
using MemoryRepository.Exceptions;
using MemoryRepository;
using System.Collections.Generic;

namespace Controller
{
    public class SceneController
    {
        public IRepositoryScene Repository;

        public SceneController() 
        {
            Repository = new SceneRepository();
        }

        public void AddScene(Scene newScene, string username)
        {
            if (newScene.Name.Equals(""))
            {
                throw new EmptyNameException("Scene's name must not be empty");
            }
            if (newScene.Name.StartsWith(" "))
            {
                throw new InvalidSpacePositionException("Scene's name must not start or end with blank space");
            }
            if (newScene.Name.EndsWith(" "))
            {
                throw new InvalidSpacePositionException("Scene's name must not start or end with blank space");
            }


            try
            {
                List<Scene> clientScenes = Repository.GetScenesByClient(username);
                clientScenes.Find(scene => scene.Name.Equals(newScene.Name));
            }
            catch (NotFoundSceneException)
            {
                newScene.Owner = username;
                Repository.AddScene(newScene);
                return;
            }

            throw new AlreadyExistingSceneException($"Scene with name {newScene.Name} already exists");
        }
    }
}
