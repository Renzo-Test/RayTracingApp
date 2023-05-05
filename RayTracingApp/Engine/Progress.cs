using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Progress
    {
        public long LinesCount { get; set; }

        public void Count()
        {
            LinesCount = 5000;
        }
    }
}
