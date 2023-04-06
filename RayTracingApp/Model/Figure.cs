using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Figure
    {
        public Client Owner { get; } = new Client();
        public String Name { get; set; }
    }
}
