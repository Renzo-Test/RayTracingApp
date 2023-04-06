using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MemoryRepository;
using Model;

namespace Test.MemoryRepositoryTest
{
    [TestClass]
    public class FigureRepositoryTest
    {
        private FigureRepository _figureRepository;

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

        [TestMethod]
        public void AddFigure_OkTest()
        {
            _figureRepository = new FigureRepository();
            Figure newFigure = new Figure()
            {
                Name = "Test"
            };

            _figureRepository.AddFigure(newFigure);
            CollectionAssert.Contains((System.Collections.ICollection)_figureRepository, newFigure);
            
        }
    }
}
