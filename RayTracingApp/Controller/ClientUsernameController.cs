﻿using IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class ClientUsernameController : ClientController
    {
        private IRepositoryClient _repo;

        public ClientUsernameController()
        {
            _repo = base.Repository;
        }

        public bool CheckIfClientExists(string username)
        {
            try
            {
                _repo.GetPassword(username);
                return true;
            }
            catch (NullReferenceException)
            {
                return false;
            }

        }

        public bool CheckIfLengthInRange(string username)
        {
            return username.Length >= 3 && username.Length <= 20;
        }

        //alphanumeric includes non special characters and no spaces 
        public bool CheckIfAlphanumeric(string username)
        {
            return true;
        }
    }
}
