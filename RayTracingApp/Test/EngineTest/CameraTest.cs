using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test.EngineTest
{
    [TestClass]
    public class CameraTest
    {
        [TestMethod]
        public void CanCreateCamera_OkTest()
        {
            Vector newVector = new Vector()
            {
                X = 10,
                Y = 20,
                Z = 30
            };

            int fieldOfView = 10;
            double aspectRatio = 10;

            Camera camera = new Camera(newVector, newVector, newVector, fieldOfView, aspectRatio);
        }
    }
}
