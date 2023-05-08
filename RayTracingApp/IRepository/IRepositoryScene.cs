using Domain;
using System.Collections.Generic;

namespace IRepository
{
	public interface IRepositoryScene
	{
		List<Scene> GetScenesByClient(string username);
		void AddScene(Scene scene);
		void RemoveScene(Scene scene);
	}
}
