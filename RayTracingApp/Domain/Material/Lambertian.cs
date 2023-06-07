using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Lambertian : Material
    {
        public Lambertian() : base(MaterialEnum.Lambertian) { }
    }
}
