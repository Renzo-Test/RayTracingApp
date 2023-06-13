using Controller.Exceptions;
using DBRepository;
using Domain;
using Domain.Exceptions;
using IRepository;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace Controller
{
	public class SceneController
	{
		public IRepositoryScene Repository;

		private const string DefaultDatabase = "RayTracingAppDB";
		public SceneController(string dbName = DefaultDatabase)
		{
			Repository = new SceneRepository()
			{
				DBName = dbName,
			};
		}

		public void AddScene(Scene newScene, Client client)
		{
			try
			{
				SceneChecker(newScene, client);
				newScene.Owner = client;
				Repository.AddScene(newScene);
			}
			catch (InvalidSceneInputException ex)
			{
				throw new InvalidSceneInputException(ex.Message);
			}
		}

		public void SaveSceneCameraAtributes(Scene scene)
		{
			Repository.SaveSceneCameraAtributes(scene);
		}

		public void UpdateSceneName(Scene scene, Client currentClient, string newName)
		{
			try
			{
				Scene newScene = new Scene()
				{
					Name = newName,
					Owner = scene.Owner
				};

				SceneChecker(newScene, currentClient);

				Repository.UpdateSceneName(scene, newName);
			}
			catch (InvalidSceneInputException ex)
			{
				throw new InvalidSceneInputException(ex.Message);
			}
		}

		public void UpdateLastModificationDate(Scene scene)
		{
			scene.LastModificationDate = TodayDate();
		}

		public void UpdateLastRenderDate(Scene scene)
		{
			scene.LastRenderDate = TodayDate();
		}

		public List<Scene> ListScenes(Client client)
		{
			return Repository.GetScenesByClient(client);
		}

		public void RemoveScene(string name, Client client)
		{
			List<Scene> userScenes = ListScenes(client);
			Scene removeScene = userScenes.Find(Scene => Scene.Name.Equals(name));
			Repository.RemoveScene(removeScene);
		}

		public Scene CreateBlankScene(Client currentClient)
		{
			string owner = currentClient.Username;
			int fov = currentClient.DefaultFov;
			Vector lookFrom = currentClient.DefaultLookFrom;
			Vector lookAt = currentClient.DefaultLookAt;

			Scene scene = new Scene(owner, fov, lookFrom, lookAt);
			return scene;
		}

		public void UpdatePreview(Scene scene, Bitmap img)
		{
			Repository.UpdateScenePreview(scene, img);
		}

		public void UpdateModels(Scene scene, PosisionatedModel posisionatedModel)
		{
			Repository.UpdateSceneModels(scene, posisionatedModel);
		}

		public void RemoveModel(Scene scene, PosisionatedModel posisionatedModel)
		{
			Repository.RemoveSceneModels(scene, posisionatedModel);
		}

		public void UpdateModelsCoordinate(PosisionatedModel model, Vector coords)
		{
			Repository.UpdateModelsCoordinate(model, coords);
		}

		public List<PosisionatedModel> GetPosisionatedModels(Scene scene)
		{
			return Repository.GetPosisionatedModels(scene);
		}

		private void SceneChecker(Scene scene, string username)
		{
			if (SceneNameExist(scene, username))
			{
				string AlreadyExistingSceneMessage = $"Scene with name {scene.Name} already exists";
				throw new AlreadyExistingSceneException(AlreadyExistingSceneMessage);
			}
		}

		private bool SceneNameExist(Scene newScene, string username)
		{
			List<Scene> clientScenes = Repository.GetScenesByClient(username);
			return clientScenes.Find(scene => scene.Name.Equals(newScene.Name)) is object;
		}

		private static string TodayDate()
		{
			return DateTime.Now.ToString("HH:mm:ss - dd/MM/yyyy");
		}
	}
}
