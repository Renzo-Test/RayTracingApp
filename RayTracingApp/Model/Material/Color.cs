using Models.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Color
    {
        private const string ColorErrorMessage = "Color's number must not be smaller than 0 or greater than 255";
        private int _red;
        private int _green;
        private int _blue;

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

        public int Blue
        {
            get => _blue;
            set
            {
                if (IsValid(value))
                {
                    throw new InvalidColorNumberException(ColorErrorMessage);
                }
                _blue = value;
            }
        }

        private static bool IsValid(int value)
        {
            return value < 0 || value > 255;
        }
    }
}
