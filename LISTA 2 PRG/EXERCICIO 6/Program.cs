using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2Ex6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double p;
            double h;
            double relacao;

            Console.Write("Informe o Peso (Kg): ");
            p = double.Parse(Console.ReadLine());

            Console.Write("Informe a altura (m): ");
            h = double.Parse(Console.ReadLine());

            relacao = p / Math.Pow(h, 2);

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
    }
}
