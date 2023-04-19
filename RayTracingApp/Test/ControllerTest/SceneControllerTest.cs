using Microsoft.VisualStudio.TestTools.UnitTesting;
using Controller;
using Models;

namespace Test.ControllerTest
{
    [TestClass]
    public class SceneControllerTest
    {
        private SceneController _sceneController;

        [TestInitialize]
        public void TestInitialize()
        {
            _sceneController = new SceneController();
        }

        [TestMethod]
        public void CreateSceneController_OkTest()
        {
            SceneController sceneController = new SceneController(); 
        }

        [TestMethod]
        public void AddScene_OkTest()
        {
            Scene newScene = new Scene();

            _sceneController.AddScene(newScene, "ownerName");

            CollectionAssert.Contains(_sceneController.Repository.GetScenesByClient("ownerName"), newScene);
        }
    }
}
