using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller.ClientExceptions
{
    public class AlreadyExistingClientException : InvalidCredentialsException
    {
        public AlreadyExistingClientException(string message) : base(message) { }
    }
}
