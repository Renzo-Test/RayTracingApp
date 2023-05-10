using System;

namespace Domain
{
	public class Vector
	{
		public double X { get; set; }
		public double Y { get; set; }
		public double Z { get; set; }

		public Color Color()
		{
			Color vectorColor = new Color()
			{
				Red = AxisToColor(X),
				Green = AxisToColor(Y),
				Blue = AxisToColor(Z),
			};

			return vectorColor;
		}

		private int AxisToColor(double axis)
		{
			return (int)Math.Abs(Math.Round(axis * 255));
		}

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
			if (divisor == 0) return new Vector();

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

		public void ScaleUpBy(double multiplier)
		{
			this.X *= multiplier;
			this.Y *= multiplier;
			this.Z *= multiplier;
		}

		public void ScaleDownBy(double divisor)
		{
			this.X /= divisor;
			this.Y /= divisor;
			this.Z /= divisor;
		}

		public double Dot(Vector vector)
		{
			return (X * vector.X) + (Y * vector.Y) + (Z * vector.Z);
		}

		public Vector Cross(Vector vector)
		{
			return new Vector()
			{
				X = Y * vector.Z - Z * vector.Y,
				Y = Z * vector.X - X * vector.Z,
				Z = X * vector.Y - Y * vector.X
			};
		}

		public double SquaredLength()
		{
			return (X * X) + (Y * Y) + (Z * Z);
		}

		public double Length()
		{
			return Math.Sqrt(SquaredLength());
		}

		public Vector GetUnit()
		{
			return Divide(Length());
		}

		public override string ToString()
		{
			return $"({X},{Y},{Z})";
		}
	}
}
