using DBRepository.Exceptions;
using Domain;
using IRepository;
using System.Collections.Generic;
using System.Data.Entity;
using System.Drawing;
using System.Linq;

namespace DBRepository
{
	public class SceneRepository : IRepositoryScene
	{
		private const string NotFoundSceneMessage = "Scene was not found or already deleted";

		public string DBName { get; set; } = "RayTracingAppDB";

		public void AddScene(Scene scene, Client client)
		{
			using (var context = new AppContext(DBName))
			{
				Client sceneClient = context.Clients.FirstOrDefault(c => c.Id == client.Id);
				scene.Owner = sceneClient;
				List<PosisionatedModel> posModels = context.PosisionatedModels.Where(pm => pm.SceneId == scene.Id).ToList();
				scene.PosisionatedModels = posModels;

				context.Scenes.Add(scene);
				context.SaveChanges();
			}
		}

		public List<Scene> GetScenesByClient(Client client)
		{
			using (var context = new AppContext(DBName))
			{
				return context.Scenes.Where(scene => scene.Owner.Id.Equals(client.Id))
					.Include(scene => scene.Owner)
					.Include(scene => scene.PosisionatedModels)
					.ToList();
			}
		}

		public void RemoveScene(Scene scene)
		{
			using (var context = new AppContext(DBName))
			{
				Scene deleteScene = context.Scenes.FirstOrDefault(s => s.Id == scene.Id);

				if (deleteScene is null)
				{
					throw new NotFoundSceneException(NotFoundSceneMessage);
				}

				context.Scenes.Remove(deleteScene);
				context.SaveChanges();
			}
		}

		public void UpdateSceneName(Scene scene, string newName)
		{
			using (var context = new AppContext(DBName))
			{
				Scene updateScene = context.Scenes.FirstOrDefault(s => s.Id == scene.Id);
				updateScene.Name = newName;
				context.SaveChanges();
			}
		}

		public void SaveSceneCameraAtributes(Scene scene)
		{
			using (var context = new AppContext(DBName))
			{
				Scene updateScene = context.Scenes.FirstOrDefault(s => s.Id == scene.Id);
				updateScene.LensAperture = scene.LensAperture;
				updateScene.LookAt = scene.LookAt;
				updateScene.LookFrom = scene.LookFrom;
				updateScene.Fov = scene.Fov;
				updateScene.LastModificationDate = scene.LastModificationDate;
				updateScene.LastRenderDate = scene.LastRenderDate;
				context.SaveChanges();
			}
		}

		public void UpdateScenePreview(Scene scene, Bitmap preview)
		{
			using (var context = new AppContext(DBName))
			{
				scene.SetPreview(preview);

				Scene updateScene = context.Scenes.FirstOrDefault(s => s.Id == scene.Id);
				updateScene.SetPreview(preview);
				context.SaveChanges();
			}
		}

		public void UpdateSceneModels(Scene scene, PosisionatedModel model)
		{
			using (var context = new AppContext(DBName))
			{
				Scene updateScene = context.Scenes.FirstOrDefault(s => s.Id == scene.Id);
				model.ModelScene = updateScene;
				model.SceneId = updateScene.Id;

				Model DbModel = context.Models.FirstOrDefault(s => s.Id == model.Model.Id);

				Figure fig = context.Figures.FirstOrDefault(m => m.Id == model.Model.Figure.Id);
				Material mat = context.Materials.FirstOrDefault(m => m.Id == model.Model.Material.Id);

				DbModel.Figure = fig;
				DbModel.Material = mat;

				model.Model = DbModel;

				updateScene.PosisionatedModels.Add(model);
				context.SaveChanges();
			}
		}

		public void UpdateModelsCoordinate(PosisionatedModel model, Vector coords)
		{
			using (var context = new AppContext(DBName))
			{
				PosisionatedModel updateModel = context.PosisionatedModels.Where(pm => pm.Id == model.Id).FirstOrDefault();
				updateModel.Position = coords;

				context.SaveChanges();
			}
		}

		public void RemoveSceneModels(Scene scene, PosisionatedModel model)
		{
			using (var context = new AppContext(DBName))
			{
				Scene updateScene = context.Scenes.FirstOrDefault(s => s.Id == scene.Id);
				PosisionatedModel deleteModel = context.PosisionatedModels.Where(pm => pm.SceneId == scene.Id).FirstOrDefault();
				context.PosisionatedModels.Remove(deleteModel);

				context.SaveChanges();
			}
		}

		public List<PosisionatedModel> GetPosisionatedModels(Scene scene)
		{
			using (var context = new AppContext(DBName))
			{
				return context.PosisionatedModels.Where(pm => pm.SceneId.Equals(scene.Id))
						.Include(pm => pm.Model)
						.Include(pm => pm.Model.Figure)
						.Include(pm => pm.Model.Material)
						.Include(pm => pm.ModelScene)
						.ToList();
			}
		}
	}
}
