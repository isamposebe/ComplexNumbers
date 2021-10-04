using ComplexNumbersLib;
using System;

namespace ComplexNumbersConsole
{
    class Program
    {
        static void Main(string[] args)
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
    }
}
