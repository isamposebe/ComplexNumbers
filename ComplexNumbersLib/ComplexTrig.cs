using System;

namespace ComplexNumbersLib
{
    public class ComplexTrig
    {
        private const double PI_2 = Math.PI / 2;

        private double _argument;
        private double _magnitude;

        /// <summary>
        /// Argument property that normalizes the argument value.
        /// </summary>
        public double Argument
        {
            get => _argument;
            set => _argument = NormalizedArgument(value);
        }

        /// <summary>
        /// Magnitude property that checks for negative values.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when the magnitude is set to a negative number</exception>
        public double Magnitude
        {
            get => _magnitude;

            set
            {
                if (value >= 0)
                    _magnitude = value;
                else
                    throw new ArgumentOutOfRangeException("Magnitude can't be negaive.");
            }
        }


        public double Real
        {
            get => Magnitude * Math.Cos(Argument);
        }

        public double Imaginary
        {
            get => Magnitude * Math.Sin(Argument);
        }

        /// <summary>
        /// Modulo operation.
        /// </summary>
        /// <param name="x">Dividend</param>
        /// <param name="y">Divisor</param>
        /// <returns></returns>
        private static double Mod(double x, double y)
        {
            var remainder = x % y;

            if (remainder < 0)
                remainder += y;

            return remainder;
        }

        /// <summary>
        /// Normalizes the argument of a complex number by mapping
        /// it to the range [0; 𝜏).
        /// </summary>
        /// <param name="arg">Argument of a complex number</param>
        /// <returns>Normalized argument</returns>
        public static double NormalizedArgument(double arg)
        {
            return Mod(arg, Math.Tau);
        }

        /// <summary>
        /// Constructs a complex number with both real and
        /// imaginary parts equal to zero.
        /// </summary>
        public ComplexTrig() => (Argument, Magnitude) = (0, 0);

        /// <summary>
        /// Constructs a complex number with the magnitude
        /// equal to one.
        /// </summary>
        /// <param name="argument">Real part</param>
        public ComplexTrig(double argument) => (Argument, Magnitude) = (argument, 1);

        /// <summary>
        /// Constructs a complex number.
        /// </summary>
        /// <param name="argument">Argument</param>
        /// <param name="magnitude">Magnitude</param>
        public ComplexTrig(double argument, double magnitude) => (Argument, Magnitude) = (argument, magnitude);

        /// <summary>
        /// Returns 0 as a complex number.
        /// </summary>
        /// <returns>The value of 0</returns>
        public static ComplexTrig Zero
        {
            get => new();
        }

        /// <summary>
        /// Returns 1 as a complex number.
        /// </summary>
        /// <returns>The value of 1</returns>
        public static ComplexTrig One
        {
            get => new(0);
        }

        /// <summary>
        /// Returns an imaginary unit.
        /// </summary>
        /// <returns>Imaginary unit</returns>
        public static ComplexTrig ImaginaryUnit
        {
            get => new(PI_2, 1);
        }

        public override bool Equals(object obj)
        {
            return ReferenceEquals(this, obj);
        }

        public override int GetHashCode()
        {
            return Argument.GetHashCode() ^ Magnitude.GetHashCode();
        }

        public override string ToString()
        {
            return $"(θ: {Argument}; r: {Magnitude})";
        }

        public static bool operator ==(ComplexTrig z, ComplexTrig w)
        {
            return (NormalizedArgument(z.Argument) == NormalizedArgument(w.Argument)) && (z.Magnitude == w.Magnitude);
        }

        public static bool operator !=(ComplexTrig z, ComplexTrig w)
        {
            return (NormalizedArgument(z.Argument) != NormalizedArgument(w.Argument)) || (z.Magnitude != w.Magnitude);
        }

        public static bool operator ==(ComplexTrig z, double x)
        {
            if (x >= 0)
                return NormalizedArgument(z.Argument) == 0 && z.Magnitude == x;
            else
                return NormalizedArgument(z.Argument) == Math.PI && z.Magnitude == -x;
        }

        public static bool operator !=(ComplexTrig z, double x)
        {
            return !(z == x);
        }

        public static bool operator ==(double x, ComplexTrig z)
        {
            return z == x;
        }

        public static bool operator !=(double x, ComplexTrig z)
        {
            return z != x;
        }

        public static ComplexTrig operator +(ComplexTrig z)
        {
            return new ComplexTrig(z.Argument, z.Magnitude);
        }

        public static ComplexTrig operator -(ComplexTrig z)
        {
            return new ComplexTrig(z.Argument + Math.PI, z.Magnitude);
        }

        public static ComplexTrig operator +(ComplexTrig z, ComplexTrig w)
        {
            var re = z.Real + w.Real;
            var im = z.Imaginary + w.Imaginary;

            var arg = Math.Atan2(im, re);
            var mag = Math.Sqrt(re * re + im * im);

            return new ComplexTrig(arg, mag);
        }

        public static ComplexTrig operator +(ComplexTrig z, double x)
        {
            var re = z.Real + x;
            var im = z.Imaginary;

            var arg = Math.Atan2(im, re);
            var mag = Math.Sqrt(re * re + im * im);

            return new ComplexTrig(arg, mag);
        }

        public static ComplexTrig operator +(double x, ComplexTrig z)
        {
            return z + x;
        }

        public static ComplexTrig operator -(ComplexTrig z, ComplexTrig w)
        {
            return z + (-w);
        }

        public static ComplexTrig operator -(ComplexTrig z, double x)
        {
            return z + (-x);
        }

        public static ComplexTrig operator -(double x, ComplexTrig z)
        {
            return x + (-z);
        }

        public static ComplexTrig operator *(ComplexTrig z, ComplexTrig w)
        {
            return new ComplexTrig(z.Argument + w.Argument, z.Magnitude * w.Magnitude);
        }

        public static ComplexTrig operator *(ComplexTrig z, double x)
        {
            var mag = z.Magnitude * x;

            if (mag >= 0)
                return new ComplexTrig(z.Argument, mag);
            else
                return new ComplexTrig(z.Argument + Math.PI, -mag);
        }

        public static ComplexTrig operator *(double x, ComplexTrig z)
        {
            return z * x;
        }

        public static ComplexTrig operator /(ComplexTrig z, ComplexTrig w)
        {
            return new ComplexTrig(z.Argument - w.Argument, z.Magnitude / w.Magnitude);
        }

        public static ComplexTrig operator /(ComplexTrig z, double x)
        {
            return z * (1 / x);
        }

        public static ComplexTrig operator /(double x, ComplexTrig z)
        {
            if (x >= 0)
                return new ComplexTrig(-z.Argument, x / z.Magnitude);
            else
                return new ComplexTrig(Math.PI - z.Argument, x / z.Magnitude);
        }

        /// <summary>
        /// Rounds the complex number components to a specified
        /// number of fractional digits.
        /// </summary>
        /// <param name="decimals">Number of fractional digits</param>
        /// <returns>Rounded complex number</returns>
        public ComplexTrig Round(int decimals)
        {
            return new ComplexTrig(
                Math.Round(Argument, decimals),
                Math.Round(Magnitude, decimals)
            );
        }

        /// <summary>
        /// Calculates the complex conjugate.
        /// </summary>
        /// <returns>Conjugate</returns>
        public ComplexTrig Conjugate()
        {
            return new ComplexTrig(-Argument, Magnitude);
        }

        /// <summary>
        /// Raises a complex number to a real power.
        /// </summary>
        /// <param name="power">Power</param>
        /// <returns>Principal product of exponentiation</returns>
        public ComplexTrig Pow(double power)
        {
            return new ComplexTrig(Argument * power, Math.Pow(Magnitude, power));
        }

        /// <summary>
        /// Calculates the principal square root of a complex number.
        /// </summary>
        /// <returns>Principal square root</returns>
        public ComplexTrig Sqrt()
        {
            return Pow(0.5);
        }

        /// <summary>
        /// Calculates the natural logarithm of a complex number.
        /// </summary>
        /// <returns>Natural logarithm</returns>
        public ComplexTrig Log()
        {
            var re = Math.Log(Magnitude);
            var im = Argument;

            return new ComplexTrig(Math.Atan2(im, re), Math.Sqrt(re * re + im * im));
        }

        /// <summary>
        /// Calculates the natural exponent of a complex number.
        /// </summary>
        /// <returns>Natural exponent</returns>
        public ComplexTrig Exp()
        {
            return new ComplexTrig(Imaginary, Math.Exp(Real));
        }
    }
}
