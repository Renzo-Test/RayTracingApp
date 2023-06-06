using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Metallic : Material
    {
        private double _blur;
        public double Blur { get { return _blur; } set { _blur = value; } }
        public Metallic() : base(MaterialEnum.Metallic) { }

    }
}
