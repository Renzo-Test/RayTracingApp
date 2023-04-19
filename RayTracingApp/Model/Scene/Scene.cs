using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Scene
    {
        public string Owner { get; set; }
        public string Name { get; set; }
        public string RegisterTime { get; set; } = DateTime.Now.ToString("hh:mm:ss - yyyy/MM/dd");
    }
}
