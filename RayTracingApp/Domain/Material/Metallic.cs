using Domain.Exceptions;
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
        public const string NotValidBlurMessage = "Blur value must be greater or equal than 0.0";
        public double Blur
        {
            get { return _blur; }
            set
            {
                try
                {
                    RunBlurIsValidChecker(value);
                    _blur = value;
                }
                catch(InvalidMaterialInputException ex)
                {
                    throw new InvalidMaterialInputException(ex.Message);
                }
            }
        }
        public Metallic() : base(MaterialEnum.Metallic) { }
        private static void RunBlurIsValidChecker(double value) 
        {
            if (value < 0.0) 
            {
                throw new InvalidMaterialInputException(NotValidBlurMessage);
            }
        }
    }
}
