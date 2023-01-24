using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Priprema3._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, max = 1;
            Console.WriteLine("Upišite prvi broj:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Upišite drugi broj:");
            b = Convert.ToInt32(Console.ReadLine());
            c = a < b ? a : b;
            for (int i = c; i >= 1; i--)
                if (a % i == 0 && b % i == 0)
                {
                    max = i;
                    break;
                }
            Console.WriteLine(max);

            Console.ReadKey();
        }
    }
}
