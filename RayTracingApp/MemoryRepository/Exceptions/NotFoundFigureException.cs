using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryRepository.Exceptions
{
    public class NotFoundFigureException : Exception
    {
        public NotFoundFigureException(string message) : base(message) { }
    }
}
