using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {//Declaração de variáveis
            int b;
            int h;
            int a;
            Console.Write("Informe a base do retângulo: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Informe a altura do retângulo: ");
            h = int.Parse(Console.ReadLine());
            a = b * h;
            if (a > 100)
            {
                Console.WriteLine("O valor da área é: {0}", a);
                Console.WriteLine("Terreno Grande");
            }
            else

                Console.WriteLine("O valor da área é: {0}", a);
        }
    }
}
