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
        private const string ColorErrorMessage = "Color's number must not be smaller than 0 or greater than 255";
        private int _red;
        private int _green;

        public int Red
        {
            get => _red;
            set
            {
                if (IsValid(value))
                {
                    throw new InvalidColorNumberException(ColorErrorMessage);
                }
                _red = value;
            }
        }

        public int Green
        {
            get => _green;
            set
            {
                if (IsValid(value))
                {
                    throw new InvalidColorNumberException(ColorErrorMessage);
                }
                _green = value;
            }
        }

        private static bool IsValid(int value)
        {
            return value < 0 || value > 255;
        }
    }
}
