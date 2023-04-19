using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Models;
using MemoryRepository;

namespace Test.MemoryRepositoryTest
{
    [TestClass]
    public class SceneRepositoryTest
    {
        private SceneRepository _sceneRepository;

        [TestMethod]
        public void CreateSceneRepository_OkTest()
        {
            _sceneRepository = new SceneRepository();
        }
    }
}
