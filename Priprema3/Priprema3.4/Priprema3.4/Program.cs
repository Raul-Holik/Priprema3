using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Priprema3._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int br;
            Console.WriteLine("Upišite neki pozitivni broj:");
            br = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < br; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
                
            }
            Console.ReadKey();
        }
    }
}
