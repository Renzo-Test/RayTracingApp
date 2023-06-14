using Domain;
using System.Collections.Generic;
using System.Drawing;

namespace IRepository
{
	public interface IRepositoryScene
	{
		void AddScene(Scene scene, Client client);
		void RemoveScene(Scene scene);
		void UpdateSceneName(Scene scene, string newName);
		void SaveSceneCameraAtributes(Scene scene);
		void UpdateScenePreview(Scene scene, Bitmap preview);
		void UpdateSceneModels(Scene scene, PosisionatedModel model);
		void RemoveSceneModels(Scene scene, PosisionatedModel model);
		void UpdateModelsCoordinate(PosisionatedModel model, Vector coords);
		List<Scene> GetScenesByClient(Client client);
		List<PosisionatedModel> GetPosisionatedModels(Scene scene);
	}
}
