﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller.Exceptions
{
    public class NotInExpectedRangeException : InvalidCredentialsException
    {
        public NotInExpectedRangeException(string message) : base(message) { }
    }
}