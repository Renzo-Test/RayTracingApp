using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MemoryRepository;

namespace Test.MemoryRepositoryTest
{
    [TestClass]
    public class FigureRepositoryTest
    {
        [TestMethod]
        public void CreateFigureRepository_OkTest()
        {
            FigureRepository _figureRepository = new FigureRepository();
        }
    }
}
