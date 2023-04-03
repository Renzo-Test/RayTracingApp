﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class ClientPasswordController : ClientController
    {
        public bool CheckIfContainsNumber(String password)
        {
            bool result = false;

            foreach (char c in password)
            {
                result = result || int.TryParse(c.ToString(), out _);
            }

            return result;
        }

        public bool CheckIfContainsCapital(String password)
        {
            return password.Any(char.IsUpper);
        }

        public bool CheckIfLengthInRange(string password)
        {
            return password.Length >= 5 && password.Length <= 25;
        }
    }
}
