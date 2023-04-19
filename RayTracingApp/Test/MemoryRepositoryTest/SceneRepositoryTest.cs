using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Models;


namespace Test.MemoryRepositoryTest
{
    [TestClass]
    public class SceneRepositoryTest
    {
        [TestMethod]
        public void CreateSceneRepository_OkTest()
        {
            SceneRepository _sceneRepository = new SceneRepository();
        }
    }
}
