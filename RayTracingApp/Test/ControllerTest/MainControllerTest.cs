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
	}
}
