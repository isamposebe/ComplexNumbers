using ComplexNumbersLib;
using System;
using Xunit;

namespace ComplexNumbersLibTests
{
    public class ComplexNumbersTest
    {
        private static double FloatingPointTolerance = 1e-6;

        private static bool AreEqualWithTolerance(Complex z, Complex w)
        {
            var diff = z - w;

            return
                Math.Abs(diff.Real) <= FloatingPointTolerance &&
                Math.Abs(diff.Imaginary) <= FloatingPointTolerance;
        }

        [Fact]
        public void EqualityTest()
        {
            var z = new Complex(2, 4);
            var w = new Complex(2, 4);

            Assert.True(z == w);
        }

        [Fact]
        public void InequalityTest()
        {
            var z = new Complex(2, 4);
            var w = new Complex(7, -1);

            Assert.True(z != w);
        }

        [Fact]
        public void ToStringTest()
        {
            var z1 = new Complex();
            var z2 = new Complex(-3);
            var z3 = new Complex(5, 7);
            var z4 = new Complex(5, -7);
            var z5 = new Complex(0, -7);
            var z6 = new Complex(0, 1);

            Assert.Equal("0", z1.ToString());
            Assert.Equal("-3", z2.ToString());
            Assert.Equal("5 + 7i", z3.ToString());
            Assert.Equal("5 - 7i", z4.ToString());
            Assert.Equal("-7i", z5.ToString());
            Assert.Equal("i", z6.ToString());
        }

        [Fact]
        public void RoundTest()
        {
            var z = new Complex(Math.PI, Math.E);

            var expected = new Complex(3.1416, 2.7183);
            var actual = z.Round(4);

            Assert.True(expected == actual);
        }

        [Fact]
        public void ArgumentTest()
        {
            var z = -Complex.ImaginaryUnit;

            var expected = -Math.PI / 2;
            var actual = z.Arg();

            Assert.True(expected == actual);
        }

        [Fact]
        public void AbsoluteValueTest()
        {
            // Pythagorean triple

            var z = new Complex(3, 4);

            var expected = 5;
            var actual = z.Abs();

            Assert.True(expected == actual);
        }

        [Fact]
        public void ConjugateTest()
        {
            var z = new Complex(-4, 5);

            var expected = new Complex(-4, -5);
            var actual = z.Conjugate();

            Assert.True(expected == actual);
        }

        [Fact]
        public void AdditionTest()
        {
            var z = new Complex(-3, 1);
            var w = new Complex(7, 2);

            var expected = new Complex(4, 3);
            var actual = z + w;

            Assert.True(expected == actual);
        }

        [Fact]
        public void SubtractionTest()
        {
            var z = new Complex(-3, 1);
            var w = new Complex(7, 2);

            var expected = new Complex(-10, -1);
            var actual = z - w;

            Assert.True(expected == actual);
        }

        [Fact]
        public void MultiplicationTest()
        {
            var z = new Complex(-3, 4);
            var w = new Complex(-3, -4);

            var expected = 25;
            var actual = z * w;

            Assert.True(expected == actual);
        }

        [Fact]
        public void DivisonTest()
        {
            var z = new Complex(7, 11);
            var w = new Complex(4, -1);

            var expected = new Complex(1, 3);
            var actual = z / w;

            Assert.True(expected == actual);
        }

        [Fact]
        public void PowerTest()
        {
            var z = Complex.ImaginaryUnit;

            var expected = -Complex.ImaginaryUnit;
            var actual = z.Pow(3);

            Assert.True(AreEqualWithTolerance(expected, actual));
        }

        [Fact]
        public void SqrtTest()
        {
            var z = -Complex.One;

            var expected = Complex.ImaginaryUnit;
            var actual = z.Sqrt();

            Assert.True(AreEqualWithTolerance(expected, actual));
        }

        [Fact]
        public void NaturalLogarithmTest()
        {
            // Euler's identity e^(i*pi) + 1 = 0

            var z = -Complex.One;

            var expected = Complex.ImaginaryUnit * Math.PI;
            var actual = z.Log();

            Assert.True(expected == actual);
        }

        [Fact]
        public void ExponentiationTest()
        {
            // Euler's identity e^(i*pi) + 1 = 0

            var z = Complex.ImaginaryUnit * Math.PI;

            var expected = -Complex.One;
            var actual = z.Exp();

            Assert.True(AreEqualWithTolerance(expected, actual));
        }
    }
}
