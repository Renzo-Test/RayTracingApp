using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public abstract class Figure
    {
        public String Owner { get; set; }
        public String Name { get; set; }

        public abstract void FigurePropertiesAreValid();
    }
}
