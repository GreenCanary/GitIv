using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitIv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("x = ");
            double x = Double.Parse(Console.ReadLine());
            Console.WriteLine("y = " + (Math.Sin(x) - Math.Cos(x)) / 5);
            Console.Write("Press any key to exit the program");
            Console.ReadKey();
        }
    }
}
