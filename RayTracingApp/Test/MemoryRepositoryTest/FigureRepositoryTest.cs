using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MemoryRepository;

namespace Test.MemoryRepositoryTest
{
    [TestClass]
    public class FigureRepositoryTest
    {
        FigureRepository _figureRepository;

        [TestMethod]
        public void CreateFigureRepository_OkTest()
        {
            _figureRepository = new FigureRepository();
        }

        [TestMethod]
        public void GetFigures_OkTest() 
        {
            _figureRepository = new FigureRepository();
            Assert.IsNotNull(_figureRepository.GetFigures());
        }
    }
}
