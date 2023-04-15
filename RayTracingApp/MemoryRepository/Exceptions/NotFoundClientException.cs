using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MemoryRepository.Exceptions
{
    public class NotFoundClientException : Exception
    {
        public NotFoundClientException(string message) : base(message) { }
    }
}
