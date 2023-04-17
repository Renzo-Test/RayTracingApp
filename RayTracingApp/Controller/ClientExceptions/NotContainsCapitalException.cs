using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller.ClientExceptions
{
    public class NotContainsCapitalException : InvalidCredentialsException
    {
        public NotContainsCapitalException(string message) : base(message) { }
    }
}
