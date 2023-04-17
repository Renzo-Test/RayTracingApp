using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Models;
using System.Collections;
using System.Linq;
using System.Collections.Generic;
using MemoryRepository.Exceptions;
using MemoryRepository;

namespace Test.MemoryRepositoryTest
{
    [TestClass]
    public class ModelRepositoryTest
    {
        [TestMethod]
        public void CreateModelRepositoryOk_Test()
        {
            ModelRepository modelRepository = new ModelRepository();
        }
    }
}
