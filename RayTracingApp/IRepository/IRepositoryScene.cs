using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRepository
{
    public interface IRepositoryScene
    {
        List<Scene> GetScenesByClient(string username);
        void AddScene(Scene scene);
        void RemoveScene(Scene scene);
    }
}
