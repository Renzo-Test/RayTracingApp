using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Exceptions
{
    public class InvalidColorNumberException : Exception
    {
        public InvalidColorNumberException(string message) : base(message) { }
    }
}
