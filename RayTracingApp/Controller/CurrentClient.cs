﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class CurrentClient
    {
        public string Username { get; set; } = string.Empty;

        public bool IsLoggedIn()
        {
            return Username != string.Empty;
        }

    }
}
