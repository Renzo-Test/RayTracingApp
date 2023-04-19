using System;

namespace Models
{
    public abstract class Figure
    {
        public String Owner { get; set; }
        public String Name { get; set; }

        public abstract void FigurePropertiesAreValid();
    }
}
