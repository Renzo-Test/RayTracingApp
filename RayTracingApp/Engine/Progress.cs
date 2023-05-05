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
        public long ExpectedLines { get; set; }

        public void Count()
        {
            LinesCount++;
        }

        public long Calculate()
        {
            return (LinesCount * 100) / ExpectedLines;
        }
    }
}
