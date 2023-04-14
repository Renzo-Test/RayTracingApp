using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MemoryRepository.MaterialRepository;

namespace Test.MemoryRepositoryTest
{
    [TestClass]
    public class MaterialRepositoryTest
    {
        [TestMethod]
        public void CreateMaterialRepository_OkTest()
        {
            MaterialRepository _materialRepository = new MaterialRepository();
        }
    }
}
