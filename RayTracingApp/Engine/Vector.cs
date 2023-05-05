using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Vector
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Vector Add(Vector vector)
        {
            return new Vector()
            {
                X = this.X + vector.X,
                Y = this.Y + vector.Y,
                Z = this.Z + vector.Z
            };
        }

        public Vector Substract(Vector vector)
        {
            return new Vector()
            {
                X = this.X - vector.X,
                Y = this.Y - vector.Y,
                Z = this.Z - vector.Z
            };
        }

        public Vector Multiply(double multiplier)
        {
            return new Vector()
            {
                X = this.X * multiplier,
                Y = this.Y * multiplier,
                Z = this.Z * multiplier
            };
        }

        public Vector Divide(double divisor)
        {
            return new Vector()
            {
                X = this.X / divisor,
                Y = this.Y / divisor,
                Z = this.Z / divisor
            };
        }

        public void AddFrom(Vector vector)
        {
            this.X += vector.X;
            this.Y += vector.Y;
            this.Z += vector.Z;
        }

        public void SubstractFrom(Vector vector)
        {
            this.X -= vector.X;
            this.Y -= vector.Y;
            this.Z -= vector.Z;
        }
    }
}
