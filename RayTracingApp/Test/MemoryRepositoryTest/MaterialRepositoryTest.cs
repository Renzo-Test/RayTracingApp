using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MemoryRepository;

namespace Test.MemoryRepositoryTest
{
    [TestClass]
    public class Class1
    {
        [TestMethod]
        public void CreateMaterialRepository_OkTest()
        {
            MaterialRepository _materialRepository = new MaterialRepository();
        }
    }
}
