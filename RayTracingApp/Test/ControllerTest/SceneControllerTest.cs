using Microsoft.VisualStudio.TestTools.UnitTesting;
using Controller;

namespace Test.ControllerTest
{
    [TestClass]
    public class SceneControllerTest
    {
        [TestMethod]
        public void CreateSceneController_OkTest()
        {
            SceneController sceneController = new SceneController(); 
        }
    }
}
