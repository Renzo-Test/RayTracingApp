using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

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
