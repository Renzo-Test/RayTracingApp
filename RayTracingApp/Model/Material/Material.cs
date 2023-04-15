using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public abstract class Material
    {
        public string Owner { get; set; }
        public string Name { get; set; }
        public Color Color { get; set; }
    }
}
