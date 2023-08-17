using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número para a tabuada (0 a 10): ");
            int numero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"A tabuada solicitada foi: {numero}\n");

            for (int i = 0; i <= 10; i++)
            {
                int resultado = numero * i;
                Console.WriteLine($"{numero} x {i} = {resultado}");
            }
        }
    }
}
