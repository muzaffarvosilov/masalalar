using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Begin12
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, p;

            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            p = c + a + b;

            Console.WriteLine("c=" + c);
            Console.WriteLine("p=" + p);
            Console.ReadKey();
        }
    }
}
