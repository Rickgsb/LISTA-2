using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2Ex9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double p;
            char sexo;
            double h;
            double relacao;


            Console.Write("Informe o Peso (Kg): ");
            p = double.Parse(Console.ReadLine());

            Console.Write("Informe a Sexo (Feminino (f) ou Masculino (m)): ");
            sexo = char.Parse(Console.ReadLine());

            Console.Write("Informe a altura (m): ");
            h = double.Parse(Console.ReadLine());

            Console.WriteLine("");

            relacao = p / Math.Pow(h, 2);

            if (sexo == 'm')
            {
                if (relacao < 20)
                {
                    Console.WriteLine("Abaixo do Peso");
                }
                else
                {
                    if (relacao < 25)
                    {
                        Console.WriteLine("Peso Ideal");
                    }
                    else
                    {
                        Console.WriteLine("Acima do Peso");
                    }
                }
            }
            if (sexo == 'f')
            {
                if (relacao < 19)
                {
                    Console.WriteLine("Abaixo do Peso");
                }
                else
                {
                    if (relacao < 24)
                    {
                        Console.WriteLine("Peso Ideal");
                    }
                    else
                    {
                        Console.WriteLine("Acima do Peso");
                    }
                }
            }
        }
    }
}
