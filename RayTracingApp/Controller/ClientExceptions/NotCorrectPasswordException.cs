using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller.ClientExceptions
{
    public class NotCorrectPasswordException : InvalidCredentialsException
    {
        public NotCorrectPasswordException(string message) : base(message) { }
    }
}
