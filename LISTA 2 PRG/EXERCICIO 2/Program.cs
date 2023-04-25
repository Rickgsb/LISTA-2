using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HENRIQUE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            Console.Write("Digite o valor a: ");
            a=double.Parse(Console.ReadLine());
            Console.Write("Digite o valor b: ");
            b=double.Parse(Console.ReadLine());
            if (a == b) 
            Console.WriteLine(" Os valores são iguais");
            else
            if (a > b) 
            Console.WriteLine("O valor A é maior que B");
            else
            Console.WriteLine("O valor A é menor que B");

        }
    }
}
