using Controller.Exceptions;
using IRepository;
using MemoryRepository;
using Domain;
using Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;

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

		public void UpdateSceneName(Scene scene, string currentClient, string newName)
		{
			try
			{
				Scene newScene = new Scene()
				{
					Name = newName,
					Owner = scene.Owner
				};

				SceneChecker(newScene, currentClient);

				scene.Name = newName;
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
		public List<Scene> ListScenes(string username)
		{
			return Repository.GetScenesByClient(username);
		}

		public void RemoveScene(string name, string username)
		{
			List<Scene> userScenes = ListScenes(username);
			Scene removeScene = userScenes.Find(Scene => Scene.Name.Equals(name));
			Repository.RemoveScene(removeScene);
		}

		public List<Model> GetAvailableModels(Scene scene, List<Model> ownerModels)
		{
			List<Model> usedModels = new List<Model>();
			foreach (PosisionatedModel posModel in scene.PosisionatedModels)
			{
				usedModels.Add(posModel.Model);
			}

			return ownerModels.Except(usedModels).ToList();
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
			return DateTime.Now.ToString("hh:mm:ss - dd/MM/yyyy");
		}
    }
}
