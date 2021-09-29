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

		public static bool operator ==(Complex z1, Complex z2)
		{
			return (z1.Real == z2.Real) && (z1.Imaginary == z2.Imaginary);
		}

		public static bool operator !=(Complex z1, Complex z2)
		{
			return (z1.Real != z2.Real) || (z1.Imaginary != z2.Imaginary);
		}
	}
}
