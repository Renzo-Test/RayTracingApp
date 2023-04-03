﻿using System;
using Controller;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;

namespace Test.Controller
{
    [TestClass]
    public class ClienControllerTest
    {
        private ClientController _controller;

        [TestMethod]
        public void CanCreateClientSignController_OkTest()
        {
            _controller = new ClientController();
        }

        [TestMethod]
        public void CheckSignUp_Gomez_GomezSecret1_OkTest()
        {
            _controller = new ClientController();
            bool result = _controller.SignUp("Gomez", "GomezSecret1");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CheckSignUp_GomezQuestionMark_GomezSecret1_OkTest()
        {
            _controller = new ClientController();
            bool result = _controller.SignUp("Gomez?", "GomezSecret1");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CheckSignUp_Go_GomezSecret1_OkTest()
        {
            _controller = new ClientController();
            bool result = _controller.SignUp("Go", "GomezSecret1");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CheckSignUp_Gomez_gomezsecret1_OkTest()
        {
            _controller = new ClientController();
            bool result = _controller.SignUp("Gomez", "gomezsecret1");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CheckSignUp_Gomez_GomezSecret_OkTest()
        {
            _controller = new ClientController();
            bool result = _controller.SignUp("Gomez", "GomezSecret");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CheckSignUp_Gomez_Gom1_OkTest()
        {
            _controller = new ClientController();
            bool result = _controller.SignUp("Gomez", "Gom1");
            Assert.IsFalse(result);
        }

                
        [TestMethod]
        public void CheckIfClientExists_EmptyString_OkTest()
        {
            _controller = new ClientController();
            bool result = _controller.CheckIfClientExists("");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CheckIfClientExists_Gomez_OkTest()
        {
            _controller = new ClientController();

            Client _client = new Client()
            {
                Username = "Gomez",
            };

            _controller.Repository.AddClient(_client);
            
            bool result = _controller.CheckIfClientExists("Gomez");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CheckIfClientExists_NotFoundUser_OkTest()
        {
            _controller = new ClientController();

            bool result = _controller.CheckIfClientExists("NotFoundUser");
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CheckSignUp_AlreadyExisting_Gomez_GomezSecret1_OkTest()
        {
            _controller = new ClientController();
            _controller.SignUp("Gomez", "GomezSecret1");
            bool result = _controller.SignUp("Gomez", "GomezSecret1");
            Assert.IsFalse(result);
        }


    }
}
