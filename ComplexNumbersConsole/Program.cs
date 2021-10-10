using ComplexNumbersLib;
using System;

namespace ComplexNumbersConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 - Complex");
            Console.WriteLine("2 - ComplexTrig");
            Console.Write(">");

            var mode = int.Parse(Console.ReadLine());

            switch (mode)
			{
                case 1:
                    ComplexDemo();
                    break;

                case 2:
                    ComplexTrigDemo();
                    break;

                default:
                    Console.WriteLine("Invalid mode");
                    break;
			}
        }

        private static void ComplexDemo()
		{
            var z = new Complex();
            var w = new Complex();

            Console.Write("Re(z) = ");
            z.Real = double.Parse(Console.ReadLine());

            Console.Write("Im(z) = ");
            z.Imaginary = double.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Re(w) = ");
            w.Real = double.Parse(Console.ReadLine());

            Console.Write("Im(w) = ");
            w.Imaginary = double.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("z + w = {0}", z + w);
            Console.WriteLine("z - w = {0}", z - w);
            Console.WriteLine("z * w = {0}", z * w);
            Console.WriteLine("z / w = {0}", z / w);
            Console.WriteLine("z ^ Re(w) = {0}", z.Pow(w.Real));
            Console.WriteLine("|z| = {0}", z.Abs());
            Console.WriteLine("Arg(z) = {0}", z.Arg());
            Console.WriteLine("z* = {0}", z.Conjugate());
            Console.WriteLine("Sqrt(z) = {0}", z.Sqrt());
            Console.WriteLine("Log(z) = {0}", z.Log());
            Console.WriteLine("Exp(z) = {0}", z.Exp());
        }

        private static void ComplexTrigDemo()
        {
            var z = new ComplexTrig();
            var w = new ComplexTrig();

            Console.Write("Arg(z) = ");
            z.Argument = double.Parse(Console.ReadLine());

            Console.Write("|z| = ");
            z.Magnitude = double.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Arg(w) = ");
            w.Argument = double.Parse(Console.ReadLine());

            Console.Write("|w| = ");
            w.Magnitude = double.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("z + w = {0}", z + w);
            Console.WriteLine("z - w = {0}", z - w);
            Console.WriteLine("z * w = {0}", z * w);
            Console.WriteLine("z / w = {0}", z / w);
            Console.WriteLine("z ^ Re(w) = {0}", z.Pow(w.Real));
            Console.WriteLine("z* = {0}", z.Conjugate());
            Console.WriteLine("Sqrt(z) = {0}", z.Sqrt());
            Console.WriteLine("Log(z) = {0}", z.Log());
            Console.WriteLine("Exp(z) = {0}", z.Exp());
        }
    }
}
