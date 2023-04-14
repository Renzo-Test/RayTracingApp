using Model.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Color
    {
        private int _red;

        public int Red
        {
            get => _red;
            set
            {
                if (value < 0 || value > 255)
                {
                    throw new InvalidColorNumberException("Color's number must not be smaller than 0 or greater than 255");
                }
                _red = value;
            }
        }

    }
}
