using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double c;


            Console.Write("Informe o primeiro Valor: ");
            a = double.Parse(Console.ReadLine());

            Console.Write("Informe o segundo Valor: ");
            b = double.Parse(Console.ReadLine());

            Console.Write("Informe o terceiro Valor: ");
            c = double.Parse(Console.ReadLine());

            if (a == b)
            {
                if (a == c)
                {
                    Console.WriteLine("Os valores informados são idênticos");
                }
                else
                {
                    if (a > c)
                    {
                        Console.WriteLine("O 1° e o 2° Valor são os maiores");
                    }
                    else
                    {
                        Console.WriteLine("O maior valor informado é 3° valor");
                    }
                }
            }
            else
            {
                if (a == c)
                {
                    if (a > b)
                    {
                        Console.WriteLine("O 1° e o 3° Valor são os maiores");
                    }
                    else
                    {
                        Console.WriteLine("O maior valor informado é o 2° Valor");
                    }
                }
                else
                {
                    if (a == c)
                    {
                        if (b > a)
                        {
                            Console.WriteLine("O 2° e o 3° Valor São os Maiores");
                        }
                        else
                        {
                            Console.WriteLine("O Maior valor informado é o 1° Valor");
                        }
                    }
                    else
                    {
                        if (a > b)
                        {
                            if (a > c)
                            {
                                Console.WriteLine("O Maior valor informado é o 1° Valor");
                            }
                            else
                            {
                                Console.WriteLine("O Maior valor informado é o 2° Valor");
                            }
                        }
                        else
                        {
                            if (b > c)
                            {
                                Console.WriteLine("O Maior valor informado é o 2° Valor");
                            }
                            else
                            {
                                Console.WriteLine("O Maior valor informado é o 3° Valor");
                            }
                        }
                    }
                }
            }
        }
    }
}
