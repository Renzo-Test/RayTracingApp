﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Client
    {
        public String Username { get; set; }
        public String Password { get; set; }
        public String RegisterDate { get; } = DateTime.Today.ToString("dd/MM/yyyy");
    }
}
