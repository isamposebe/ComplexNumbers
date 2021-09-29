using System;
using ComplexNumbersLib;
using Xunit;

namespace ComplexNumbersLibTests
{
	public class ComplexNumbersTest
	{
		[Fact]
		public void EqualityTest()
		{
			var z1 = new Complex(2, 4);
			var z2 = new Complex(2, 4);

			Assert.True(z1 == z2);
		}

		[Fact]
		public void InequalityTest()
		{
			var z1 = new Complex(2, 4);
			var z2 = new Complex(7, -1);

			Assert.True(z1 != z2);
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

			Assert.Equal("0",      z1.ToString());
			Assert.Equal("-3",     z2.ToString());
			Assert.Equal("5 + 7i", z3.ToString());
			Assert.Equal("5 - 7i", z4.ToString());
			Assert.Equal("-7i",    z5.ToString());
			Assert.Equal("i",      z6.ToString());
		}

		[Fact]
		public void AbsoluteValueTest()
		{
			throw new NotImplementedException();
		}

		[Fact]
		public void ArgumentTest()
		{
			throw new NotImplementedException();
		}

		[Fact]
		public void ConjugateTest()
		{
			throw new NotImplementedException();
		}

		[Fact]
		public void AdditionTest()
		{
			throw new NotImplementedException();
		}

		[Fact]
		public void SubtractionTest()
		{
			throw new NotImplementedException();
		}

		[Fact]
		public void MultiplicationTest()
		{
			throw new NotImplementedException();
		}

		[Fact]
		public void ExponentiationTest()
		{
			throw new NotImplementedException();
		}

		[Fact]
		public void SqrtTest()
		{
			throw new NotImplementedException();
		}

		[Fact]
		public void NaturalLogarithmTest()
		{
			throw new NotImplementedException();
		}
	}
}
