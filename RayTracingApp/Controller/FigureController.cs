using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class FigureController
    {
        public bool CheckNameIsNotEmpty(string figureName)
        {
            return !string.IsNullOrEmpty(figureName);
        }

        public bool CheckNameHasNoSpaces(string figureName)
        {
            return true;
        }
    }
}
