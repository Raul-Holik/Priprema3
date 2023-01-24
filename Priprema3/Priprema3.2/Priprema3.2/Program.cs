using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Priprema3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char znak = ' ';
            int pon, najPon = 0;
            Console.WriteLine("Unesite riječ:");
            string sH = Console.ReadLine();
            for (int i = 0; i < sH.Length; i++)
            {
                pon = 0;
                for (int j = 0; j < sH.Length; j++)
                    if (sH[i] == sH[j])
                        pon++;
                if (pon > najPon)
                {
                    znak = sH[i];
                    najPon = pon;
                }
            }
            Console.WriteLine("Znak: "+znak+" se pojavio najviše puta, "+najPon+ " puta.");

            Console.ReadKey();
        }
    }
}
