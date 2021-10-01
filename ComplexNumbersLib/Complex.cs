using System;

namespace ComplexNumbersLib
{
	public class Complex
	{
		public double Real;
		public double Imaginary;

		/// <summary>
		/// Constructs a complex number with both real and
		/// imaginary parts equal to zero.
		/// </summary>
		public Complex() => (Real, Imaginary) = (0, 0);

		/// <summary>
		/// Constructs a complex number with the imaginary
		/// part equal to zero.
		/// </summary>
		/// <param name="real">Real part</param>
		public Complex(double real) => (Real, Imaginary) = (real, 0);

		/// <summary>
		/// Constructs a complex number.
		/// </summary>
		/// <param name="real">Real part</param>
		/// <param name="imaginary">Imaginary part</param>
		public Complex(double real, double imaginary) => (Real, Imaginary) = (real, imaginary);

		/// <summary>
		/// Returns 1 as a complex number.
		/// </summary>
		/// <returns>The value of 1</returns>
		public static Complex One
		{
			get => new Complex(1, 0);
		}

		/// <summary>
		/// Returns an imaginary unit.
		/// </summary>
		/// <returns>Imaginary unit</returns>
		public static Complex ImaginaryUnit
		{
			get => new Complex(0, 1);
		}

		public override string ToString()
		{
			if (Imaginary == 0)
				return Real.ToString();

			if (Real == 0)
			{
				if (Imaginary == 1)
					return "i";
				else if (Imaginary == -1)
					return "-i";
				else
					return $"{Imaginary}i";
			}

			if (Imaginary == 1)
				return $"{Real} + i";
			else if (Imaginary == -1)
				return $"{Real} - i";
			else
				return $"{Real} {(Imaginary >= 0 ? "+" : "-")} {Math.Abs(Imaginary)}i";
		}

		public static bool operator ==(Complex z, Complex w)
		{
			return (z.Real == w.Real) && (z.Imaginary == w.Imaginary);
		}

		public static bool operator !=(Complex z, Complex w)
		{
			return (z.Real != w.Real) || (z.Imaginary != w.Imaginary);
		}

		public static bool operator ==(Complex z, double x)
		{
			return z.Imaginary == 0 && z.Real == x;
		}

		public static bool operator !=(Complex z, double x)
		{
			return z.Imaginary != 0 || z.Real != x;
		}

		public static bool operator ==(double x, Complex z)
		{
			return z.Imaginary == 0 && z.Real == x;
		}

		public static bool operator !=(double x, Complex z)
		{
			return z.Imaginary != 0 || z.Real != x;
		}

		public static Complex operator +(Complex z)
		{
			return new Complex(z.Real, z.Imaginary);
		}

		public static Complex operator -(Complex z)
		{
			return new Complex(-z.Real, -z.Imaginary);
		}

		public static Complex operator +(Complex z, Complex w)
		{
			return new Complex(z.Real + w.Real, z.Imaginary + w.Imaginary);
		}

		public static Complex operator -(Complex z, Complex w)
		{
			return new Complex(z.Real - w.Real, z.Imaginary - w.Imaginary);
		}

		public static Complex operator *(Complex z, Complex w)
		{
			return new Complex(
				z.Real*w.Real - z.Imaginary*w.Imaginary,
				z.Imaginary*w.Real + z.Real*w.Imaginary
			);
		}

		public static Complex operator *(Complex z, double x)
		{
			return new Complex(z.Real * x, z.Imaginary * x);
		}

		public static Complex operator *(double x, Complex z)
		{
			return new Complex(x * z.Real, x * z.Imaginary);
		}

		public static Complex operator /(Complex z, Complex w)
		{
			var mul = 1 / (w.Real*w.Real + w.Imaginary*w.Imaginary);

			return new Complex(
				(z.Real*w.Real + z.Imaginary*w.Imaginary) * mul,
				(z.Imaginary*w.Real - z.Real*w.Imaginary) * mul
			);
		}

		public static Complex operator /(Complex z, double x)
		{
			return new Complex(z.Real / x, z.Imaginary / x);
		}

		public static Complex operator /(double x, Complex z)
		{
			var mul = x / (z.Real*z.Real + z.Imaginary*z.Imaginary);

			return new Complex(
				z.Real * mul,
				-z.Imaginary * mul
			);
		}

		public double Arg()
		{
			var arg = Math.Acos(Real / Abs());

			if (Imaginary < 0)
				arg = -arg;

			return arg;
		}

		public double Abs()
		{
			return Math.Sqrt(Real * Real + Imaginary * Imaginary);
		}

		public double AbsSqr()
		{
			return Real * Real + Imaginary * Imaginary;
		}

		public Complex Conjugate()
		{
			return new Complex(Real, -Imaginary);
		}

		public Complex Pow(double power)
		{
			double newArgument = Arg() * power;
			double newAbsoluteValue = Math.Pow(Abs(), power);

			return new Complex(
				newAbsoluteValue * Math.Cos(newArgument),
				newAbsoluteValue * Math.Sin(newArgument)
			);
		}

		public Complex Sqrt()
		{
			return Pow(0.5);
		}

		public Complex Log()
		{
			return new Complex(Math.Log(AbsSqr())/2, Arg());
		}
	}
}
