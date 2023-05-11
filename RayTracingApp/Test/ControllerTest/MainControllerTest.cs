using Controller;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test.ControllerTest
{
	[TestClass]
	public class MainControllerTest
	{
		[TestMethod]
		public void CreateMainController_OkTest()
		{
			MainController controller = new MainController();
		}

		[TestMethod]
		public void SetClientController_OkTest()
		{
			MainController controller = new MainController();
			ClientController clientController = new ClientController();
			controller.ClientController = clientController;

			Assert.AreEqual(clientController, controller.ClientController);
		}

		[TestMethod]
		public void SetFigureController_OkTest()
		{
			MainController controller = new MainController();
			FigureController figureController = new FigureController();
			controller.FigureController = figureController;

			Assert.AreEqual(figureController, controller.FigureController);
		}

		[TestMethod]
		public void SetMaterialController_OkTest()
		{
			MainController controller = new MainController();
			MaterialController materialController = new MaterialController();
			controller.MaterialController = materialController;

			Assert.AreEqual(materialController, controller.MaterialController);
		}

		[TestMethod]
		public void SetModelController_OkTest()
		{
			MainController controller = new MainController();
			ModelController modelController = new ModelController();
			controller.ModelController = modelController;

			Assert.AreEqual(modelController, controller.ModelController);
		}

		[TestMethod]
		public void SetSceneController_OkTest()
		{
			MainController controller = new MainController();
			SceneController sceneController = new SceneController();
			controller.SceneController = sceneController;

			Assert.AreEqual(sceneController, controller.SceneController);
		}
	}
}
