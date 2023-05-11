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
			controller.ClientController = figureController;

			Assert.AreEqual(figureController, controller.FigureController);
		}
	}
}
