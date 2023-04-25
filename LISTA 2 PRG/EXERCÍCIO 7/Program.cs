using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2Ex7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double l1;
            double l2;
            double l3;


            Console.Write("Digite o 1º Valor: ");
            l1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o 2º Valor: ");
            l2 = double.Parse(Console.ReadLine());

            Console.Write("Digite o 3º Valor: ");
            l3 = double.Parse(Console.ReadLine());

            Console.WriteLine("");

            if ((l1 + l2) > l3)
            {
                if ((l2 + l3) > l1)
                {
                    if ((l1 + l3) > l2)
                    {
                        if (l1 == l2)
                        {
                            if (l2 == l3)
                            {
                                Console.WriteLine("Triângulo Equilatero");
                            }
                            else
                            {
                                Console.WriteLine("Triângulo Isósceles");
                            }
                        }
                        else
                        {
                            if (l1 == l3)
                            {
                                Console.WriteLine("Triângulo Isósceles");
                            }
                            else
                            {
                                if (l2 == l3)
                                {
                                    Console.WriteLine("Triângulo Isósceles");
                                }
                                else
                                {
                                    Console.WriteLine("Triângulo Escaleno");
                                }
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Não Formam um Triângulo");
                    }
                }
                else
                {
                    Console.WriteLine("Não Formam um Triângulo");
                }
            }
            else
            {
                Console.WriteLine("Não Formam um Triângulo");
            }
        }
    }
}
