using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {   //Declaração de variáveis
            int v1;
            int v2;
            Console.Write("Digite o valor 1: ");
            v1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor 2: ");
            v2 = int.Parse(Console.ReadLine());
            if (v1 > v2)
                Console.WriteLine("O valor {0} é maior que {1}", v1, v2);
            else
                Console.WriteLine("O valor {0} é maior que {1}", v2, v1);
        }
    }
}
