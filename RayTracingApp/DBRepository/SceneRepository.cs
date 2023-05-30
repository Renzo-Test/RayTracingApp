using Domain;
using MemoryRepository.Exceptions;
using IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBRepository
{
    public class SceneRepository : IRepositoryScene
    {
        private const string NotFoundSceneMessage = "Scene was not found or already deleted";
        public string DBName { get; set; } = "RayTracingAppDB";
        public void AddScene(Scene scene)
        {
            using (var context = new AppContext(DBName)) 
            {
                context.Scenes.Add(scene);
                context.SaveChanges();
            }
        }

        public List<Scene> GetScenesByClient(string username)
        {
            throw new NotImplementedException();
        }

        public void RemoveScene(Scene scene)
        {
            throw new NotImplementedException();
        }
    }
}
