using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryRepository.Exceptions
{
    public class NotFoundSceneException : Exception
    {
        public NotFoundSceneException(string message) : base(message) { }
    }
}
