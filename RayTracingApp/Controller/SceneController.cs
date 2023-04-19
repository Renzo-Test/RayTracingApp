using Controller.SceneExceptions;
using Models;
using IRepository;
using MemoryRepository;

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

            newScene.Owner = username;
            Repository.AddScene(newScene);
        }
    }
}
