using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2Ex8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double l1;
            double l2;
            double l3;

            Console.Write("Informe o primeiro valor: ");
            l1 = double.Parse(Console.ReadLine());

            Console.Write("Informe o segundo valor: ");
            l2 = double.Parse(Console.ReadLine());

            Console.Write("Informe o terceir valor: ");
            l3 = double.Parse(Console.ReadLine());

            l1 = Math.Pow(l1, 2);
            l2 = Math.Pow(l2, 2);
            l3 = Math.Pow(l3, 2);

            if ((l1 + l2) == l3)
            {
                Console.WriteLine("Formam um Triângulo Retângulo");
            }
            else
            {
                if ((l3 + l2) == l1)
                {
                    Console.WriteLine("Formam um Triângulo Retângulo");
                }
                else
                {
                    if ((l1 + l3) == l2)
                    {
                        Console.WriteLine("Formam um Triângulo Retângulo");
                    }
                    else
                    {
                        Console.WriteLine("Não Formam um Triângulo Retângulo");
                    }
                }
            }
        }
    }
}
