
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
            newScene.Owner = username;
            Repository.AddScene(newScene);
        }
    }
}
